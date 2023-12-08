namespace ReflectionExample
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.ComponentModel;
    using System.Data;
    using System.Reflection;
    using System.Text;
    using System.Linq;

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
            FillGridView();
            instance = this;

        }
        private void cbObList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objectname = string.Empty + ((ComboBox)sender).SelectedItem;
            var type = assb.GetType(objectname);
            DisplayType(type, objectname);
        }
        private void FillGridView()
        {
            var par = Repo();
            dynamic content = JsonConvert.DeserializeObject(par);

            var dd = (from ii in (content["Devices"] as IEnumerable<dynamic>) select new { DeviceId = ii["DeviceId"], Model = ii["Model"], Name = ii["Name"] })
                .Where(predicate => predicate.DeviceId != null && (string.Empty + predicate?.DeviceId).Contains(((textBox1.Text.Length>0) ?textBox1.Text: (string.Empty + predicate?.DeviceId))))
                .ToList();
            dataGridView1.DataSource = ToDataTable(dd);
        }
        private void DisplayType<T>(T obj, string obname)
        {
            StringBuilder sb = new StringBuilder();
            Type thetype = typeof(T);

            sb.AppendLine("Type: " + obname);
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


        private DataTable ToDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();

            //special handling for value types and string
            if (typeof(T).IsValueType || typeof(T).Equals(typeof(string)))
            {

                DataColumn dc = new DataColumn("Value");
                table.Columns.Add(dc);
                foreach (T item in data)
                {
                    DataRow dr = table.NewRow();
                    dr[0] = item;
                    table.Rows.Add(dr);
                }
            }
            else
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                foreach (PropertyDescriptor prop in properties)
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        try
                        {
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                        }
                        catch (Exception ex)
                        {
                            row[prop.Name] = DBNull.Value;
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        private string Repo()
        {
            return $@"{{

Devices:[
        {{
            ""Category"": ""DM"",
            ""DeviceId"": ""@E-c44268000042"",
            ""Model"": ""HD-PS622"",
            ""Name"": ""HD-PS622-C44268000042"",
            ""RebootReason"": ""poweron""
        }},
        {{
            ""Category"": ""DM"",
            ""DeviceId"": ""@E-FD123412341"",
            ""Model"": ""JU-OEIUW"",
            ""Name"": ""JU-OEIUW-FD123412341"",
            ""RebootReason"": ""poweron""
        }},
        {{
            ""Category"": ""DM"",
            ""DeviceId"": ""@E-SD13241234"",
            ""Model"": ""IU-YIYASD"",
            ""Name"": ""IU-YIYASD-SD13241234"",
            ""RebootReason"": ""poweron""
        }},
        {{
            ""Category"": ""DM"",
            ""DeviceId"": ""@E-YT342352455"",
            ""Model"": ""TR-EOIUWQ"",
            ""Name"": ""TR-EOIUWQ-YT342352455"",
            ""RebootReason"": ""poweron""
        }},
        {{
            ""Category"": ""DM"",
            ""DeviceId"": ""@E-ER1241234"",
            ""Model"": ""RW-DAKLSJDAL"",
            ""Name"": ""RW-DAKLSJDAL-ER1241234"",
            ""RebootReason"": ""poweron""
        }}
		]
}}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillGridView();
        }
    }



}
