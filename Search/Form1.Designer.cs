namespace Search
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCountvalue = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelCountvalue
            // 
            this.labelCountvalue.Location = new System.Drawing.Point(63, 15);
            this.labelCountvalue.Name = "labelCountvalue";
            this.labelCountvalue.Size = new System.Drawing.Size(44, 13);
            this.labelCountvalue.TabIndex = 5;
            this.labelCountvalue.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(13, 15);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Count : ";
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(13, 41);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(775, 394);
            this.listBoxSearch.TabIndex = 3;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCountvalue);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.listBoxSearch);
            this.Name = "FormSearch";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCountvalue;
        private System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.ListBox listBoxSearch;
    }
}

