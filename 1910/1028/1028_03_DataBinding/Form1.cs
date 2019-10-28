using _1028_01_ADO.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1028_03_DataBinding
{
    public partial class Form1 : Form
    {
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("이름", "Name", dataGridView1, typeof(string), 100, null, true);
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("이메일", "Email", dataGridView1, typeof(string), 200, null, true);
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("생일", "Birth", dataGridView1, typeof(DateTime), 200, null, true);
            Utility_1028.UtiliyClass.AddNewColumnToDataGridView("가족수", "Family", dataGridView1, typeof(byte), 100, null, true);
            LoadData();

            this.bindingNavigator1.BindingSource = this.bindingSource1;

            this.dataGridView1.DataSource = this.bindingSource1;
            this.txtName.DataBindings.Add("Text", this.bindingSource1, "Name");
            this.dtpBirth.DataBindings.Add("Text", this.bindingSource1, "Birth");
            this.txtEmail.DataBindings.Add("Text", this.bindingSource1, "Email");
            this.nudFamily.DataBindings.Add("Text", this.bindingSource1, "Family");
        }

        // 조회
        private void LoadData()
        {
            MemberInfoService service = new MemberInfoService();
            dt = service.SelectAll(); // 프로퍼티명과 같으면 바인딩됨
            service.Dispose();

            this.bindingSource1.DataSource = dt;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            // Save DataSource
            MemberInfoService service = new MemberInfoService();

            DataRow[] insRows = dt.Select(null, null, DataViewRowState.Added); // 추가
            foreach (var dr in insRows)
            {
                MemberInfoVO item = SetMemberInfoVO(dr);
                service.Insert(item);
            }
            DataRow[] upsRows = dt.Select(null, null, DataViewRowState.ModifiedCurrent); //수정
            foreach (var dr in upsRows)
            {
                MemberInfoVO item = SetMemberInfoVO(dr);
                service.Update(item);
            }
            DataRow[] delRows = dt.Select(null, null, DataViewRowState.Deleted); //삭제
            foreach (var dr in delRows)
            {
                MemberInfoVO item = SetDelMemberInfoVO(dr);
                service.Delete(item);
            }

            service.Dispose();
        }
        private MemberInfoVO SetDelMemberInfoVO(DataRow dr)
        {
            return new MemberInfoVO()
            {
                Name = dr["Name", DataRowVersion.Original].ToString()
                ,
                Birth = Convert.ToDateTime(dr["Birth", DataRowVersion.Original].ToString())
                ,
                Email = dr["Email", DataRowVersion.Original].ToString()
                ,
                Family = Convert.ToByte(dr["Family", DataRowVersion.Original])
            };
        }

        private MemberInfoVO SetMemberInfoVO(DataRow dr)
        {
            return new MemberInfoVO()
            {
                Name = dr["Name"].ToString()
                ,
                Birth = Convert.ToDateTime(dr["Birth"].ToString())
                ,
                Email = dr["Email"].ToString()
                ,
                Family = Convert.ToByte(dr["Family"])
            };
        }
    }
}
