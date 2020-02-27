using _0123_01_CheckBox.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0123_01_CheckBox
{
    public partial class Form1 : Form
    {
        CheckBox headercheck = new CheckBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDate();
        }

        private void InitControls()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            // 0 : 첫번째  -1 : 헤더
            Point headerlocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headercheck.Location = new Point(headerlocation.X + 8, headerlocation.Y + 2);
            headercheck.BackColor = Color.White;
            headercheck.Size = new Size(18, 18);
            headercheck.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headercheck);
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["chk"] is DataGridViewCheckBoxCell chkbox)
                {
                    chkbox.Value = headercheck.Checked;
                }
            }
        }

        private void GetDate()
        {
            EmployeeService service = new EmployeeService();
            dataGridView1.DataSource = service.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> chkEmpID = new List<int>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(item.Cells["chk"].EditedFormattedValue);
                if (isCellChecked)
                    chkEmpID.Add(Convert.ToInt32(item.Cells[1].Value));
            }
            MessageBox.Show(string.Join(", ", chkEmpID));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.EndEdit();
            if (e.RowIndex > -1 && e.ColumnIndex == 0) // check칼럼만 클릭했을 경우
            {
                //dataGridView1.SelectedRows[0].Cells["chk"].Value = !Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["chk"].Value);
                bool isChecked = true;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (!Convert.ToBoolean(item.Cells["chk"].EditedFormattedValue)) // 현재 Edit이건 아니건 값을 가져온다
                    {
                        isChecked = false;
                        break;
                    }
                }
                headercheck.Checked = isChecked;
            }
        }
    }
}
