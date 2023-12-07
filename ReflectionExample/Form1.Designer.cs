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
            SuspendLayout();
            // 
            // cbObList
            // 
            cbObList.FormattingEnabled = true;
            cbObList.Location = new Point(29, 46);
            cbObList.Name = "cbObList";
            cbObList.Size = new Size(357, 23);
            cbObList.TabIndex = 0;
            cbObList.SelectedIndexChanged += cbObList_SelectedIndexChanged;
            // 
            // txtClassDetails
            // 
            txtClassDetails.Location = new Point(29, 86);
            txtClassDetails.Multiline = true;
            txtClassDetails.Name = "txtClassDetails";
            txtClassDetails.ReadOnly = true;
            txtClassDetails.ScrollBars = ScrollBars.Both;
            txtClassDetails.Size = new Size(357, 336);
            txtClassDetails.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(txtClassDetails);
            Controls.Add(cbObList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbObList;
        private TextBox txtClassDetails;
    }
}
