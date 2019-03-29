using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Repeater;

namespace GKProxy
{
    public partial class ProxyOutput : Form
    {
        private BackgroundWorker WorkerUI = new BackgroundWorker();

        public ProxyOutput()
        {
            InitializeComponent();
        }

        private void ProxyOutput_Load(object sender, EventArgs e)
        {
            Sql.CreateDatabase();
            MyProxy.Start();

            WorkerUI.DoWork += BackgroundWorkerUiUpdateProxyOutputDoWork;
            WorkerUI.WorkerSupportsCancellation = true;
            WorkerUI.RunWorkerAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (WorkerUI.IsBusy)
            {
                WorkerUI.CancelAsync();
                MyProxy.Stop();
                return;
            }

            base.OnFormClosing(e);
        }

        private void BackgroundWorkerUiUpdateProxyOutputDoWork(object sender, DoWorkEventArgs e)
        {
            while (!WorkerUI.CancellationPending)
            {
                if (!IsHandleCreated)
                {
                    CreateHandle();
                }

                List<string> data = Sql.ReadData("Data");

                if (labelCountvalue.Text != data.Count.ToString())
                {
                    void Actionlabel() => labelCountvalue.Text = data.Count.ToString();
                    labelCountvalue.Invoke((Action)Actionlabel);

                    listBoxOutput.DataSource = null;

                    void Actionlistbox() => listBoxOutput.DataSource = data;
                    listBoxOutput.Invoke((Action)Actionlistbox);
                }
                Thread.Sleep(1000);
            }
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectionOutput.Text = listBoxOutput.GetItemText(listBoxOutput.SelectedItem);
        }

        private void buttonRepeater_Click(object sender, EventArgs e)
        {
            FormRepeater repeater = new FormRepeater();
            repeater.Show();
        }
    }
}
