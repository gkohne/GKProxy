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
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.backgroundWorkerUpdateProxyOutput = new System.ComponentModel.BackgroundWorker();
            this.textBoxSelectionOutput = new System.Windows.Forms.TextBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.labelSelectedItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCountvalue
            // 
            this.labelCountvalue.Location = new System.Drawing.Point(62, 12);
            this.labelCountvalue.Name = "labelCountvalue";
            this.labelCountvalue.Size = new System.Drawing.Size(44, 13);
            this.labelCountvalue.TabIndex = 5;
            this.labelCountvalue.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 12);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Count : ";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(15, 52);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(506, 433);
            this.listBoxOutput.TabIndex = 6;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // backgroundWorkerUpdateProxyOutput
            // 
            this.backgroundWorkerUpdateProxyOutput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdateProxyOutput_DoWork);
            // 
            // textBoxSelectionOutput
            // 
            this.textBoxSelectionOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectionOutput.Location = new System.Drawing.Point(527, 52);
            this.textBoxSelectionOutput.Multiline = true;
            this.textBoxSelectionOutput.Name = "textBoxSelectionOutput";
            this.textBoxSelectionOutput.Size = new System.Drawing.Size(414, 433);
            this.textBoxSelectionOutput.TabIndex = 7;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(12, 36);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(48, 13);
            this.labelHistory.TabIndex = 8;
            this.labelHistory.Text = "History : ";
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.Location = new System.Drawing.Point(529, 36);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(81, 13);
            this.labelSelectedItem.TabIndex = 9;
            this.labelSelectedItem.Text = "Selected Item : ";
            // 
            // ProxyOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 495);
            this.Controls.Add(this.labelSelectedItem);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.textBoxSelectionOutput);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.labelCountvalue);
            this.Controls.Add(this.labelCount);
            this.Name = "ProxyOutput";
            this.Text = "ProxyOutput";
            this.Load += new System.EventHandler(this.ProxyOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCountvalue;
        private System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.ListBox listBoxOutput;
        public System.ComponentModel.BackgroundWorker backgroundWorkerUpdateProxyOutput;
        public System.Windows.Forms.TextBox textBoxSelectionOutput;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Label labelSelectedItem;
    }
}