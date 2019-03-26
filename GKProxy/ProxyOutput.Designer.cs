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
            this.backgroundWorkerListtoDB = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelCountvalue
            // 
            this.labelCountvalue.Location = new System.Drawing.Point(83, 15);
            this.labelCountvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountvalue.Name = "labelCountvalue";
            this.labelCountvalue.Size = new System.Drawing.Size(59, 16);
            this.labelCountvalue.TabIndex = 5;
            this.labelCountvalue.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(16, 15);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 17);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Count : ";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 16;
            this.listBoxOutput.Location = new System.Drawing.Point(20, 64);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(673, 532);
            this.listBoxOutput.TabIndex = 6;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // backgroundWorkerUpdateProxyOutput
            // 
            this.backgroundWorkerUpdateProxyOutput.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerUiUpdateProxyOutputDoWork);
            // 
            // textBoxSelectionOutput
            // 
            this.textBoxSelectionOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectionOutput.Location = new System.Drawing.Point(703, 64);
            this.textBoxSelectionOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSelectionOutput.Multiline = true;
            this.textBoxSelectionOutput.Name = "textBoxSelectionOutput";
            this.textBoxSelectionOutput.Size = new System.Drawing.Size(551, 532);
            this.textBoxSelectionOutput.TabIndex = 7;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(16, 44);
            this.labelHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(64, 17);
            this.labelHistory.TabIndex = 8;
            this.labelHistory.Text = "History : ";
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.Location = new System.Drawing.Point(705, 44);
            this.labelSelectedItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(105, 17);
            this.labelSelectedItem.TabIndex = 9;
            this.labelSelectedItem.Text = "Selected Item : ";
            // 
            // backgroundWorkerListtoDB
            // 
            this.backgroundWorkerListtoDB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerListtoDB_DoWork);
            // 
            // ProxyOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 609);
            this.Controls.Add(this.labelSelectedItem);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.textBoxSelectionOutput);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.labelCountvalue);
            this.Controls.Add(this.labelCount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerListtoDB;
    }
}