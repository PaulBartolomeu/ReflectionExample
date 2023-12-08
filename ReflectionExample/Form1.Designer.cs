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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 600);
            Controls.Add(panel1);
            Controls.Add(txtClassDetails);
            Controls.Add(cbObList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbObList;
        private TextBox txtClassDetails;
        private Panel panel1;
    }
}
