using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1002_01_SaveFileForm
{
    public partial class Form2 : Form
    {
        struct DailyWork
        {
            public string WorkDate;
            public string Worker;
            public string WorkMachine;
            public string WorkProduct;
            public int WorkQty;

            public DailyWork(string date, string worker, string machine, string product, int qty)
            {
                WorkDate = date;
                Worker = worker;
                WorkMachine = machine;
                WorkProduct = product;
                WorkQty = qty;
            }
            public DailyWork(string[] str)
            {
                WorkDate = str[0];
                Worker = str[1];
                WorkMachine = str[2];
                WorkProduct = str[3];
                WorkQty = int.Parse(str[4]);
            }
        }

        List<DailyWork> workList = new List<DailyWork>();
        bool editMode = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            initComboBinding();
            DtWork_ValueChanged(null, null);
        }

        private void initComboBinding()
        {
            var cboDic = new Dictionary<string, string>();
            cboDic.Add("201001", "홍길동");
            cboDic.Add("201002", "임꺽정");
            cboDic.Add("201003", "유재석");
            cboDic.Add("201004", "김구라");

            cboWorker.DataSource = new BindingSource(cboDic, null);
            cboWorker.DisplayMember = "Value";
            cboWorker.ValueMember = "Key";
            cboWorker.SelectedIndex = -1;

            cboDic = new Dictionary<string, string>();
            cboDic.Add("A1", "A1");
            cboDic.Add("B1", "B1");
            cboDic.Add("A3", "A3");
            cboDic.Add("A4", "A4");

            cboMachine.DataSource = new BindingSource(cboDic, null);
            cboMachine.DisplayMember = "Value";
            cboMachine.ValueMember = "Key";
            cboMachine.SelectedIndex = -1;

            cboDic = new Dictionary<string, string>();
            cboDic.Add("A001", "꼬깔콘");
            cboDic.Add("B001", "치토스");
            cboDic.Add("A003", "포카칩");
            cboDic.Add("A004", "칙촉");

            cboProduct.DataSource = new BindingSource(cboDic, null);
            cboProduct.DisplayMember = "Value";
            cboProduct.ValueMember = "Key";
            cboProduct.SelectedIndex = -1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string date = dtWork.Value.ToShortDateString();
            string worker = cboWorker.SelectedValue.ToString();
            string machine = cboMachine.SelectedValue.ToString();
            string product = cboProduct.SelectedValue.ToString();
            int qty = (int)nuQty.Value;

            if (editMode)
            {
                int idx = listBox1.SelectedIndex;

                DailyWork workItem = new DailyWork(date, worker, machine, product, qty);
                workList[idx] = workItem;
                listBox1.Items[idx] = string.Format("{0}|{1}|{2}|{3}|{4}", date, worker, machine, product, qty);
            }
            else
            {
                DailyWork workItem = new DailyWork(date, worker, machine, product, qty);
                workList.Add(workItem);
                listBox1.Items.Add(string.Format("{0}|{1}|{2}|{3}|{4}", date, worker, machine, product, qty));
            }
        }

        private void DtWork_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            workList.Clear();
            ClearValue();

            //해당하는 작업일자의 파일이 있다면 읽어서 List를 채운다.
            ReadWorkFile();
        }

        private void ClearValue()
        {
            cboWorker.SelectedIndex = -1;
            cboMachine.SelectedIndex = -1;
            cboProduct.SelectedIndex = -1;
            nuQty.Value = 0;

            editMode = false;
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            string cdate = dtWork.Value.ToString("yyyyMMdd");
            string format = "{0,10}|{1,-10}|{2,-10}|{3,-15}|{4,10}";
            string line;

            using (StreamWriter wr = new StreamWriter(@"C:\Temp\" + cdate + ".txt"))
            {
                foreach (DailyWork workItem in workList)
                {
                    line = string.Format(format, workItem.WorkDate, workItem.Worker, workItem.WorkMachine, workItem.WorkProduct, workItem.WorkQty);
                    wr.WriteLine(line);
                }
            }
        }

        private void ReadWorkFile()
        {
            string cdate = dtWork.Value.ToString("yyyyMMdd");
            string line;

            if (!File.Exists(@"C:\Temp\" + cdate + ".txt"))
                return;

            using (StreamReader rdr = new StreamReader(@"C:\Temp\" + cdate + ".txt"))
            {
                while ((line = rdr.ReadLine()) != null)
                {
                    string[] workArr = line.Replace(" ","").Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries); // 변경
                    if (workArr.Length == 5) // 정상 파일인지 확인
                    {
                        //DailyWork workItem = new DailyWork(workArr[0], workArr[1], workArr[2], workArr[3], int.Parse(workArr[4]));
                        DailyWork workItem = new DailyWork(workArr);
                        workList.Add(workItem);
                    }
                }
            }

            foreach (DailyWork workItem in workList)
            {
                listBox1.Items.Add(string.Format("{0}|{1}|{2}|{3}|{4}", workItem.WorkDate, workItem.Worker, workItem.WorkMachine, workItem.WorkProduct, workItem.WorkQty));
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            DailyWork workItem = workList[listBox1.SelectedIndex];

            cboWorker.SelectedValue = workItem.Worker;
            cboMachine.SelectedValue = workItem.WorkMachine;
            cboProduct.SelectedValue = workItem.WorkProduct;
            nuQty.Value = workItem.WorkQty;

            editMode = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearValue();
        }
    }
}
