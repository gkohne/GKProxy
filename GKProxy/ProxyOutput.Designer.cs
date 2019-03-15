namespace GKProxy
{
    partial class ProxyOutput
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCountvalue
            // 
            this.labelCountvalue.Location = new System.Drawing.Point(62, 9);
            this.labelCountvalue.Name = "labelCountvalue";
            this.labelCountvalue.Size = new System.Drawing.Size(44, 13);
            this.labelCountvalue.TabIndex = 5;
            this.labelCountvalue.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 9);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Count : ";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(13, 25);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(827, 419);
            this.textBoxOutput.TabIndex = 6;
            // 
            // ProxyOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 456);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelCountvalue);
            this.Controls.Add(this.labelCount);
            this.Name = "ProxyOutput";
            this.Text = "ProxyOutput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCountvalue;
        private System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.TextBox textBoxOutput;
    }
}