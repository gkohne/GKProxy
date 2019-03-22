namespace GKProxy
{
    partial class FormGKProxy
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
            this.buttonRepeater = new System.Windows.Forms.Button();
            this.buttonProxy = new System.Windows.Forms.Button();
            this.buttonSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRepeater
            // 
            this.buttonRepeater.Location = new System.Drawing.Point(17, 16);
            this.buttonRepeater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRepeater.Name = "buttonRepeater";
            this.buttonRepeater.Size = new System.Drawing.Size(213, 124);
            this.buttonRepeater.TabIndex = 0;
            this.buttonRepeater.Text = "Repeater";
            this.buttonRepeater.UseVisualStyleBackColor = true;
            this.buttonRepeater.Click += new System.EventHandler(this.buttonRepeater_Click);
            // 
            // buttonProxy
            // 
            this.buttonProxy.Location = new System.Drawing.Point(17, 159);
            this.buttonProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProxy.Name = "buttonProxy";
            this.buttonProxy.Size = new System.Drawing.Size(213, 102);
            this.buttonProxy.TabIndex = 1;
            this.buttonProxy.Text = "Proxy";
            this.buttonProxy.UseVisualStyleBackColor = true;
            this.buttonProxy.Click += new System.EventHandler(this.buttonProxy_Click);
            // 
            // buttonSQL
            // 
            this.buttonSQL.Location = new System.Drawing.Point(17, 292);
            this.buttonSQL.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(213, 102);
            this.buttonSQL.TabIndex = 2;
            this.buttonSQL.Text = "SQL";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // FormGKProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonSQL);
            this.Controls.Add(this.buttonProxy);
            this.Controls.Add(this.buttonRepeater);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGKProxy";
            this.Text = "GKProxy";
            this.Load += new System.EventHandler(this.FormGKProxy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRepeater;
        private System.Windows.Forms.Button buttonProxy;
        private System.Windows.Forms.Button buttonSQL;
    }
}

