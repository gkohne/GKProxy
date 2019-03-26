using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MyProxy;

namespace GKProxy
{
    public partial class ProxyOutput : Form
    {
        private BackgroundWorker WorkerUI = new BackgroundWorker();
        private BackgroundWorker WorkerListToDB = new BackgroundWorker();

        public ProxyOutput()
        {
            InitializeComponent();
        }

        private void ProxyOutput_Load(object sender, EventArgs e)
        {
            //Process.Start(@"cmd.exe", @"/k ..\..\..\MyProxy\bin\Debug\MyProxy.exe");
            SQL.CreateDatabase();
            TheProxy.Start();

            WorkerUI.DoWork += BackgroundWorkerUiUpdateProxyOutputDoWork;
            WorkerUI.WorkerSupportsCancellation = true;
            WorkerUI.RunWorkerAsync();

            WorkerListToDB.DoWork += BackgroundWorkerListtoDB_DoWork;
            WorkerListToDB.WorkerSupportsCancellation = true;
            WorkerListToDB.RunWorkerAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (WorkerListToDB.IsBusy)
            {
                WorkerListToDB.CancelAsync();
            }

            if (WorkerUI.IsBusy)
            {
                WorkerUI.CancelAsync();
                TheProxy.Stop();
                TheProxy._list.Clear();
                return;
            }

            base.OnFormClosing(e);
        }

        private void BackgroundWorkerUiUpdateProxyOutputDoWork(object sender, DoWorkEventArgs e)
        {
            while (!WorkerUI.CancellationPending)
            {
                if (TheProxy._list.Count > 0)
                {
                    if (!IsHandleCreated)
                    {
                        CreateHandle();
                    }

                    List<string> data = SQL.ReadData("Data");
                    List<string> newList = TheProxy._list;
                    newList = newList.Except(data).ToList();

                    if (newList.Count > 0)
                    {
                        void Actionlabel() => labelCountvalue.Text = data.Count.ToString();
                        labelCountvalue.Invoke((Action) Actionlabel);

                        listBoxOutput.DataSource = null;

                        void Actionlistbox() => listBoxOutput.DataSource = data;
                        listBoxOutput.Invoke((Action) Actionlistbox);
                    }
                }

                Thread.Sleep(1000);
            }
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectionOutput.Text = listBoxOutput.GetItemText(listBoxOutput.SelectedItem);
        }

        private void BackgroundWorkerListtoDB_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);

            while (WorkerListToDB.IsBusy)
            {
                List<string> list = TheProxy._list;

                if (list.Count != 0)
                {
                    List<string> newList = list;
                    List<string> dataList = new List<string>();

                    var data = SQL.ReadData("Data");

                    if (data != null)
                    {
                        dataList = new List<string>(data);
                    }

                    newList = newList.Except(dataList).ToList();

                    if (newList.Count != 0)
                    {
                        SQL.ListToDB(newList);
                    }
                }

                Thread.Sleep(1000);
            }

        }
    }
}
