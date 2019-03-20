using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace GKProxy
{
    public partial class ProxyOutput : Form
    {
        BackgroundWorker Worker = new BackgroundWorker();
        public ProxyOutput()
        {
            InitializeComponent();
        }

        private void ProxyOutput_Load(object sender, EventArgs e)
        {
            MyProxy.Start();

            Worker.DoWork += backgroundWorkerUpdateProxyOutput_DoWork;
            Worker.WorkerSupportsCancellation = true;
            Worker.RunWorkerAsync();
        }

        private bool closePending;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Worker.IsBusy)
            {
                Worker.CancelAsync();
                return;
            }
            base.OnFormClosing(e);
        }


        private void backgroundWorkerUpdateProxyOutput_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!Worker.CancellationPending)
            {
                if (MyProxy._list.Count > 0)
                {
                    if (!IsHandleCreated)
                    {
                        CreateHandle();
                    }

                    void Actionlabel() => labelCountvalue.Text = MyProxy._list.Count.ToString();
                    labelCountvalue.Invoke((Action) Actionlabel);

                    void Actionlistbox() =>
                    listBoxOutput.DataSource = MyProxy._list;
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
