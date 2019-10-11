using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1004_Practice01_SaveFileForm
{
    public struct FactoryLog
    {
        public string date;
        public string worker;
        public string machine;
        public string product;
        public int quantity;

        public FactoryLog(string date, string worker, string machine, string product, int quantity)
        {
            this.date = date;
            this.worker = worker;
            this.machine = machine;
            this.product = product;
            this.quantity = quantity;
        }
        public FactoryLog(string[] reads)
        {
            this.date = reads[0];
            this.worker = reads[1];
            this.machine = reads[2];
            this.product = reads[3];
            this.quantity = int.Parse(reads[4]);
        }

        public override string ToString()
        {
            return string.Format("{0,-10}|{1,10}|{2,10}|{3,10}|{4,10}", date, worker, machine, product, quantity);
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool editmode = false;
        int editNum = -1;
        List<FactoryLog> factoryLogs;
        string filePath;
        private void Form1_Load(object sender, EventArgs e)
        {
            factoryLogs = new List<FactoryLog>();

            nuQty.Maximum = int.MaxValue;
            //MessageBox.Show(DateTime.Now.ToShortDateString());
            filePath = @"C:\" + DateTime.Now.ToShortDateString() + ".txt";
            dtWork.Value = DateTime.Now;

            Dictionary<string, string> dicCboWorker = new Dictionary<string, string>();
            dicCboWorker.Add("201001", "홍길동");
            dicCboWorker.Add("201002", "임꺽정");
            dicCboWorker.Add("201003", "유재석");
            dicCboWorker.Add("201004", "김구라");

            cboWorker.DataSource = new BindingSource(dicCboWorker, null);
            cboWorker.DisplayMember = "Value";
            cboWorker.ValueMember = "Key";
            cboWorker.SelectedIndex = 0;

            Dictionary<string, string> dicCboMachine = new Dictionary<string, string>();
            dicCboMachine.Add("A1", "A1");
            dicCboMachine.Add("B1", "B1");
            dicCboMachine.Add("A3", "A3");
            dicCboMachine.Add("A4", "A4");

            cboMachine.DataSource = new BindingSource(dicCboMachine, null);
            cboMachine.DisplayMember = "Value";
            cboMachine.ValueMember = "Key";
            cboMachine.SelectedIndex = 0;

            Dictionary<string, string> dicCboProduct = new Dictionary<string, string>();
            dicCboProduct.Add("A001", "꼬깔콘");
            dicCboProduct.Add("B001", "치토스");
            dicCboProduct.Add("A003", "포카칩");
            dicCboProduct.Add("A004", "칙촉");

            cboProduct.DataSource = new BindingSource(dicCboProduct, null);
            cboProduct.DisplayMember = "Value";
            cboProduct.ValueMember = "Key";
            cboProduct.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (editmode)
            {
                factoryLogs.RemoveAt(editNum);
                factoryLogs.Insert(editNum, new FactoryLog(dtWork.Text, cboWorker.SelectedValue.ToString(),
                    cboMachine.SelectedValue.ToString(),
                    cboProduct.SelectedValue.ToString(),
                    Convert.ToInt32(nuQty.Value)));
            }
            else
            {
                factoryLogs.Add(
                    new FactoryLog(dtWork.Text, cboWorker.SelectedValue.ToString(),
                    cboMachine.SelectedValue.ToString(),
                    cboProduct.SelectedValue.ToString(),
                    Convert.ToInt32(nuQty.Value)));
            }
            ReplaceListBox1();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cboWorker.SelectedIndex = 1;
            cboProduct.SelectedIndex = 1;
            cboMachine.SelectedIndex = 1;
            nuQty.Value = 0;
            editNum = -1;
            editmode = false;
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (var item in factoryLogs)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void DtWork_ValueChanged(object sender, EventArgs e)
        {
            if (dtWork.Value != DateTime.Now)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, false))
                {
                    foreach (var item in factoryLogs)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                }
            }
            filePath = @"C:\" + dtWork.Text + ".txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string read;
                    string[] reads;
                    StringBuilder stringBuilder = new StringBuilder();
                    factoryLogs.Clear();
                    while ((read = streamReader.ReadLine()) != null)
                    {
                        reads = read.Replace(" ", "").Split('|');
                        if (reads.Length != 5)
                        {
                            MessageBox.Show("잘못 저장된 파일입니다.");
                            return;
                        }
                        factoryLogs.Add(new FactoryLog(reads));
                    }
                }
            }
            ReplaceListBox1();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            editmode = true;
            editNum = listBox1.SelectedIndex;
            FactoryLog factoryLog = factoryLogs[editNum];
            cboWorker.SelectedValue = factoryLog.worker;
            cboMachine.SelectedValue = factoryLog.machine;
            cboProduct.SelectedValue = factoryLog.product;
            nuQty.Value = factoryLog.quantity;
        }

        private void ReplaceListBox1()
        {
            listBox1.Items.Clear();
            foreach (var item in factoryLogs)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
