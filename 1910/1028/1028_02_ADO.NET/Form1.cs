using _1028_01_ADO.NET;
using System;
using System.Windows.Forms;


namespace _1028_02_ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 추가
            MemberInfoVO item = SetMemberInfoVO();

            MemberInfoService service = new MemberInfoService();
            service.Insert(item);
            service.Dispose();
            LoadData();
        }

        private MemberInfoVO SetMemberInfoVO()
        {
            return new MemberInfoVO()
            {
                Name = txtName.Text
                ,
                Birth = dtpBirth.Value
                ,
                Email = txtEmail.Text
                ,
                Family = Convert.ToByte(nudFamily.Value)
            };
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // 수정
            MemberInfoVO item = SetMemberInfoVO();

            MemberInfoService service = new MemberInfoService();
            service.Update(item);
            service.Dispose();
            LoadData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 조회
            LoadData();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // 삭제
            MemberInfoVO item = SetMemberInfoVO();

            MemberInfoService service = new MemberInfoService();
            service.Delete(item);
            service.Dispose();
            LoadData();
        }

        // 조회
        private void LoadData()
        {
            MemberInfoService service = new MemberInfoService();
            dataGridView1.DataSource = service.SelectAll(); // 프로퍼티명과 같으면 바인딩됨
            service.Dispose();

            txtName.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("이름", "Name", dataGridView1, typeof(string), 100, null, true);
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("이메일", "Email", dataGridView1, typeof(string), 200, null, true);
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("생일", "Birth", dataGridView1, typeof(DateTime), 200, null, true);
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("가족수", "Family", dataGridView1, typeof(byte), 100, null, true);
            LoadData();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                dtpBirth.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Birth"].Value);
                nudFamily.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Family"].Value);

                txtName.Enabled = false;
            }
        }
    }
}
