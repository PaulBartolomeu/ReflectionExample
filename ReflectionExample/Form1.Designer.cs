namespace ReflectionExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbObList = new ComboBox();
            txtClassDetails = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbObList
            // 
            cbObList.FormattingEnabled = true;
            cbObList.Location = new Point(33, 61);
            cbObList.Margin = new Padding(3, 4, 3, 4);
            cbObList.Name = "cbObList";
            cbObList.Size = new Size(407, 28);
            cbObList.TabIndex = 0;
            cbObList.SelectedIndexChanged += cbObList_SelectedIndexChanged;
            // 
            // txtClassDetails
            // 
            txtClassDetails.Location = new Point(33, 115);
            txtClassDetails.Margin = new Padding(3, 4, 3, 4);
            txtClassDetails.Multiline = true;
            txtClassDetails.Name = "txtClassDetails";
            txtClassDetails.ReadOnly = true;
            txtClassDetails.ScrollBars = ScrollBars.Both;
            txtClassDetails.Size = new Size(516, 447);
            txtClassDetails.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(613, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 533);
            panel1.TabIndex = 2;
            panel1.TabStop = true;
            // 
            // button1
            // 
            button1.Location = new Point(969, 43);
            button1.Name = "button1";
            button1.Size = new Size(139, 42);
            button1.TabIndex = 3;
            button1.Text = "&Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(737, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(675, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(662, 204);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(729, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "DeviceID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 600);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(txtClassDetails);
            Controls.Add(cbObList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbObList;
        private TextBox txtClassDetails;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
