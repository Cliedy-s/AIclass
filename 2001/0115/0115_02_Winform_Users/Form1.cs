using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0115_02_Winform_Users
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            UserService service = new UserService();
            UserVO vo = await service.GetAsync<UserVO>($"GetUserInfo/{id}");

            lblid.Text = vo.id.ToString();
            txtAddress.Text = vo.Address;
            txtEmail.Text = vo.Email;
            txtName.Text = vo.Name;
            txtPhone.Text = vo.Mobile;
            chkIsActive.Checked = vo.IsActive;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO - visible false
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblid.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            dataGridView1.DataSource = await service.GetListAsync<List<UserVO>>("GetAllUsers");
            //dataGridView1.DataSource = await service.GetTAsync<List<UserVO>>("GetAllUsers");

            lblid.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            chkIsActive.Checked = false;
        } //조회 버튼
        private async void button2_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            Message<UserVO> message =
                await service.PostAsync<UserVO>
                ($"SaveUser", new UserVO() { id = 0, IsActive = chkIsActive.Checked, Address = txtAddress.Text, Email = txtEmail.Text, Mobile = txtPhone.Text, Name = txtName.Text });
            MessageBox.Show(message.ResultMessage);
            if (message.IsSuccess)
            {
                button1.PerformClick();
            }
        } //등록 버튼
        private async void button4_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            Message<UserVO> message =
                await service.PostAsync<UserVO>
                ($"SaveUser", new UserVO() { id = Convert.ToInt32(lblid.Text), IsActive = chkIsActive.Checked, Address = txtAddress.Text, Email = txtEmail.Text, Mobile = txtPhone.Text, Name = txtName.Text });
            MessageBox.Show(message.ResultMessage);
            if (message.IsSuccess) button1.PerformClick();
        } //수정 버튼
        private async void button3_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            DTO.Message msg = await service.GetAsync($"DelUser/{lblid.Text}");
            MessageBox.Show(msg.ResultMessage);
            if (msg.IsSuccess) button1.PerformClick();

        } //삭제 버튼

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
