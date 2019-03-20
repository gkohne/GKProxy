using System;
using System.Windows.Forms;

namespace Repeater
{
    public partial class FormRepeater : Form
    {
        public FormRepeater()
        {
            InitializeComponent();
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            string responce = WebResponce.GetResponce(textBoxURL.Text, (WebResponce.Method)Enum.Parse(typeof(WebResponce.Method), comboBoxMethod.Text));

            textBoxRaw.Text = responce;
            webBrowserPreview.DocumentText = responce;

            buttonSend.Enabled = true;
        }

        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMethod.Text != string.Empty)
            {
                buttonSend.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"Please select a method");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
