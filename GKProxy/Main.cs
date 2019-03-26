using System;
using System.Windows.Forms;
using Repeater;

namespace GKProxy
{
    public partial class FormGKProxy : Form
    {
        public FormGKProxy()
        {
            InitializeComponent();
        }

        private void buttonRepeater_Click(object sender, EventArgs e)
        {
            FormRepeater repeater = new FormRepeater();
            repeater.Show();
        }

        private void buttonProxy_Click(object sender, EventArgs e)
        {
           ProxyOutput proxyOutput = new ProxyOutput();
           proxyOutput.Show();
        }

        private void FormGKProxy_Load(object sender, EventArgs e)
        {

        }
    }
}
