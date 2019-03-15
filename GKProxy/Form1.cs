using System;
using System.Windows.Forms;
using Repeater;

namespace GKProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRepeater_Click(object sender, EventArgs e)
        {
            FormRepeater repeater = new FormRepeater();
            repeater.Show();
        }
    }
}
