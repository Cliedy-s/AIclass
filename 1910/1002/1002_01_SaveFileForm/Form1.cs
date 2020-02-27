using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _1002_01_SaveFileForm
{
    public partial class Form1 : Form
    {
        List<DailyWork> list = new List<DailyWork>();
        bool updateMode = false;
        DailyWork tempDailyWork;

        public Form1()
        {
            InitializeComponent();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment appDeployment = ApplicationDeployment.CurrentDeployment;
                lblVersion.Text = $"Version : {appDeployment.CurrentVersion.ToString()}";
            }
            else
            {
                lblVersion.Text = "Version : NotDeploy";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dtpWorkDate.ShowUpDown = true;
            dtpWorkDate.Value = DateTime.Now;
            nudWorkQty.Maximum = int.MaxValue;

            Dictionary<string, string> dicWorker = new Dictionary<string, string>();
            dicWorker.Add("201001", "김홍홍");
            dicWorker.Add("201002", "박홍홍");
            dicWorker.Add("201003", "신홍홍");
            dicWorker.Add("201004", "이홍홍");
            cmbWorker.DataSource = new BindingSource(dicWorker, null);
            cmbWorker.DisplayMember = "Value";
            cmbWorker.ValueMember = "Key";
            cmbWorker.SelectedIndex = 0;

            Dictionary<string, string> dicWorkMachine = new Dictionary<string, string>();
            dicWorkMachine.Add("A1", "A1");
            dicWorkMachine.Add("A2", "A2");
            dicWorkMachine.Add("A3", "A3");
            dicWorkMachine.Add("A4", "A4");
            cmbWorkMachine.DataSource = new BindingSource(dicWorkMachine, null);
            cmbWorkMachine.DisplayMember = "Value";
            cmbWorkMachine.ValueMember = "Key";
            cmbWorkMachine.SelectedIndex = 0;

            Dictionary<string, string> dicWorkProduct = new Dictionary<string, string>();
            dicWorkProduct.Add("A001", "꼬깔콘");
            dicWorkProduct.Add("A002", "계란과자");
            dicWorkProduct.Add("A003", "초코파이");
            dicWorkProduct.Add("A004", "마카롱");
            cmbWorkProduct.DataSource = new BindingSource(dicWorkProduct, null);
            cmbWorkProduct.DisplayMember = "Value";
            cmbWorkProduct.ValueMember = "Key";
            cmbWorkProduct.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (updateMode)
                list.Remove(tempDailyWork);
            SetDailyWork();
            list.Add(tempDailyWork);
            ShowListView(dtpWorkDate.Text);
        }
        private void BtnCencel_Click(object sender, EventArgs e)
        {
            cmbWorker.SelectedIndex = 1;
            cmbWorkMachine.SelectedIndex = 1;
            cmbWorkProduct.SelectedIndex = 1;
            nudWorkQty.Value = 0;
            updateMode = false;
        }
        private void ShowListView(string date = "All")
        {
            listView.Items.Clear();
            foreach (var item in list)
            {
                if (date == "All" || item.WorkDate == date )
                {
                    listView.Items.Add(item);
                }
            }
        }

        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            //using (StreamWriter streamWriter = new StreamWriter(@"C:\" + dtpWorkDate.Value.ToString("yyyyMMdd") + "작업파일.txt"))
            using (StreamWriter streamWriter = new StreamWriter(@"C:\작업파일.txt"))
            {
                foreach (var item in list)
                {
                    streamWriter.WriteLine(item.ToFileString());
                }
            }

        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            string[] listviewstrs = listView.SelectedItem.ToString().Split('|');

            cmbWorker.SelectedValue = listviewstrs[1];
            cmbWorkMachine.SelectedValue = listviewstrs[2];
            cmbWorkProduct.SelectedValue = listviewstrs[3];
            nudWorkQty.Value = Convert.ToDecimal(listviewstrs[4]);

            updateMode = true;
            SetDailyWork();
        }
        private void SetDailyWork()
        {
            tempDailyWork = new DailyWork(
                dtpWorkDate.Text,
                cmbWorker.SelectedValue.ToString(),
                cmbWorkMachine.SelectedValue.ToString(),
                cmbWorkProduct.SelectedValue.ToString(),
                Convert.ToInt32(nudWorkQty.Value)
                );
        }

        private void DtpWorkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowListView(dtpWorkDate.Text);
        }
    }
    struct DailyWork
    {
        public string WorkDate;
        public string Worker;
        public string WorkMachine;
        public string WorkProduct;
        public int workQty;

        public DailyWork(string workDate, string worker, string workMachine, string workProduct, int workQty)
        {
            WorkDate = workDate;
            Worker = worker;
            WorkMachine = workMachine;
            WorkProduct = workProduct;
            this.workQty = workQty;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(WorkDate + "|");
            sb.Append(Worker + "|");
            sb.Append(WorkMachine + "|");
            sb.Append(WorkProduct + "|");
            sb.Append(workQty + "|");
            return sb.ToString().TrimEnd('|');
        }
        public string ToFileString()
        {
            return string.Format("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}", WorkDate, Worker, WorkMachine, WorkProduct, workQty);
        }

    }

}
