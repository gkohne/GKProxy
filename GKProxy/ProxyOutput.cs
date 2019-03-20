using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace GKProxy
{
    public partial class ProxyOutput : Form
    {
        public BackgroundWorker Worker = new BackgroundWorker();

        public ProxyOutput()
        {
            InitializeComponent();
        }

        private void ProxyOutput_Load(object sender, EventArgs e)
        {
            MyProxy.Start();
            Worker.DoWork += backgroundWorkerUpdateProxyOutput_DoWork;
            Worker.RunWorkerAsync();
        }


        private void backgroundWorkerUpdateProxyOutput_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (MyProxy._list.Count > 0)
                {
                    if (!IsHandleCreated)
                    {
                        CreateHandle();
                    }

                    void Actionlabel() => labelCountvalue.Text = MyProxy._list.Count.ToString();
                    labelCountvalue.Invoke((Action) Actionlabel);

                    listBoxOutput.DataSource = null;
                    void Actionlistbox() => listBoxOutput.DataSource = MyProxy._list;
                    labelCountvalue.Invoke((Action) Actionlistbox);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
