namespace ReflectionExample
{
    using System.Reflection;
    using System.Collections;
    using Crestron;
    using CrestronSharp;
    using System.Text;

    public partial class Form1 : Form
    {

        public static Form1 instance;
        private Assembly assb;
        public Form1()
        {
            InitializeComponent();

            assb = Assembly.LoadFrom(Path.Combine(AppContext.BaseDirectory, "SimplSharpProgrammingInterfaces.dll"));
            if (assb != null)
            {
                cbObList.DataSource = assb.GetTypes().ToList().Where(a => a.FullName != null && a.FullName.Contains(".")).ToList();
            }

            instance = this;
        }

        private void cbObList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objectname = string.Empty + ((ComboBox)sender).SelectedItem;
            var type = assb.GetType(objectname);
            DisplayType(type);
        }

        private void DisplayType<T>(T obj)
        {
            StringBuilder sb = new StringBuilder();
            Type thetype = typeof(T);
            sb.AppendLine(thetype.FullName);
            foreach (var props in thetype.GetProperties())
            {
                if (props != null) { sb.AppendLine("\tProperty: " + props.Name); }
            }
            foreach (var meth in thetype.GetMethods())
            {
                if (meth != null) { sb.AppendLine("\tMethod: " + meth.Name); }
            }
            this.txtClassDetails.Text = sb?.ToString();
        }
    }



    //public void DisplayObjectData<T>(T obj)
    //{

    //}

}
