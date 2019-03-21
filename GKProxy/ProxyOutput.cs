using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using MyProxy;

namespace GKProxy
{
    public partial class ProxyOutput : Form
    {
        private BackgroundWorker Worker = new BackgroundWorker();

        public ProxyOutput()
        {
            InitializeComponent();
        }

        private void ProxyOutput_Load(object sender, EventArgs e)
        {
            TheProxy.Start();

            Worker.DoWork += backgroundWorkerUpdateProxyOutput_DoWork;
            Worker.WorkerSupportsCancellation = true;
            Worker.RunWorkerAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Worker.IsBusy)
            {
                Worker.CancelAsync();
                TheProxy.Stop();
                TheProxy._list.Clear();
                return;
            }
            base.OnFormClosing(e);
        }

        private void backgroundWorkerUpdateProxyOutput_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!Worker.CancellationPending)
            {
                if (TheProxy._list.Count > 0)
                {
                    if (!IsHandleCreated)
                    {
                        CreateHandle();
                    }

                    void Actionlabel() => labelCountvalue.Text = TheProxy._list.Count.ToString();
                    labelCountvalue.Invoke((Action) Actionlabel);

                    listBoxOutput.DataSource = null;

                    void Actionlistbox() =>
                    listBoxOutput.DataSource = TheProxy._list;
                    listBoxOutput.Invoke((Action) Actionlistbox);
                }
                Thread.Sleep(1000);
            }
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectionOutput.Text = listBoxOutput.GetItemText(listBoxOutput.SelectedItem);
        }
    }
}
