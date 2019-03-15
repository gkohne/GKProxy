namespace Repeater
{
    partial class FormRepeater
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
            this.groupBoxResponce = new System.Windows.Forms.GroupBox();
            this.groupBoxRequest = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tabControlResponce = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxRaw = new System.Windows.Forms.TextBox();
            this.labelPOSTData = new System.Windows.Forms.Label();
            this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
            this.groupBoxResponce.SuspendLayout();
            this.groupBoxRequest.SuspendLayout();
            this.tabControlResponce.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResponce
            // 
            this.groupBoxResponce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResponce.Controls.Add(this.tabControlResponce);
            this.groupBoxResponce.Location = new System.Drawing.Point(600, 25);
            this.groupBoxResponce.Name = "groupBoxResponce";
            this.groupBoxResponce.Size = new System.Drawing.Size(601, 580);
            this.groupBoxResponce.TabIndex = 7;
            this.groupBoxResponce.TabStop = false;
            this.groupBoxResponce.Text = "Responce";
            // 
            // groupBoxRequest
            // 
            this.groupBoxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxRequest.Controls.Add(this.labelPOSTData);
            this.groupBoxRequest.Controls.Add(this.textBox2);
            this.groupBoxRequest.Controls.Add(this.textBoxURL);
            this.groupBoxRequest.Controls.Add(this.labelUrl);
            this.groupBoxRequest.Controls.Add(this.labelMethod);
            this.groupBoxRequest.Controls.Add(this.comboBoxMethod);
            this.groupBoxRequest.Controls.Add(this.buttonSend);
            this.groupBoxRequest.Location = new System.Drawing.Point(13, 25);
            this.groupBoxRequest.Name = "groupBoxRequest";
            this.groupBoxRequest.Size = new System.Drawing.Size(581, 580);
            this.groupBoxRequest.TabIndex = 8;
            this.groupBoxRequest.TabStop = false;
            this.groupBoxRequest.Text = "Request";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 141);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(566, 433);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "\"a=value1&b=value2\"";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(108, 84);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(464, 20);
            this.textBoxURL.TabIndex = 11;
            this.textBoxURL.Text = "https://www.google.com/";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(105, 67);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(38, 13);
            this.labelUrl.TabIndex = 10;
            this.labelUrl.Text = "URL : ";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(105, 17);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(52, 13);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Method : ";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.comboBoxMethod.Location = new System.Drawing.Point(108, 39);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethod.TabIndex = 8;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(9, 17);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 87);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send ";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tabControlResponce
            // 
            this.tabControlResponce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlResponce.Controls.Add(this.tabPage1);
            this.tabControlResponce.Controls.Add(this.tabPage2);
            this.tabControlResponce.Location = new System.Drawing.Point(6, 19);
            this.tabControlResponce.Name = "tabControlResponce";
            this.tabControlResponce.SelectedIndex = 0;
            this.tabControlResponce.Size = new System.Drawing.Size(589, 555);
            this.tabControlResponce.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxRaw);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowserPreview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxRaw
            // 
            this.textBoxRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRaw.Location = new System.Drawing.Point(0, -2);
            this.textBoxRaw.Multiline = true;
            this.textBoxRaw.Name = "textBoxRaw";
            this.textBoxRaw.Size = new System.Drawing.Size(578, 528);
            this.textBoxRaw.TabIndex = 0;
            // 
            // labelPOSTData
            // 
            this.labelPOSTData.AutoSize = true;
            this.labelPOSTData.Location = new System.Drawing.Point(6, 125);
            this.labelPOSTData.Name = "labelPOSTData";
            this.labelPOSTData.Size = new System.Drawing.Size(71, 13);
            this.labelPOSTData.TabIndex = 14;
            this.labelPOSTData.Text = "POST Data : ";
            // 
            // webBrowserPreview
            // 
            this.webBrowserPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserPreview.Location = new System.Drawing.Point(0, -2);
            this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPreview.Name = "webBrowserPreview";
            this.webBrowserPreview.ScriptErrorsSuppressed = true;
            this.webBrowserPreview.Size = new System.Drawing.Size(585, 531);
            this.webBrowserPreview.TabIndex = 0;
            // 
            // FormRepeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 604);
            this.Controls.Add(this.groupBoxRequest);
            this.Controls.Add(this.groupBoxResponce);
            this.Name = "FormRepeater";
            this.Text = "Repeater";
            this.groupBoxResponce.ResumeLayout(false);
            this.groupBoxRequest.ResumeLayout(false);
            this.groupBoxRequest.PerformLayout();
            this.tabControlResponce.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResponce;
        private System.Windows.Forms.GroupBox groupBoxRequest;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TabControl tabControlResponce;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxRaw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelPOSTData;
        private System.Windows.Forms.WebBrowser webBrowserPreview;
    }
}

