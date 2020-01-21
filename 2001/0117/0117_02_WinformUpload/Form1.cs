using FileDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0117_02_WinformUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<FilePathVO> list = null;
            CallService service = new CallService();
            dataGridView1.DataSource = await service.GetListAsync<List<FilePathVO>>("GetFileInfo");
        } // 파일 목록 가져오기
        private void button3_Click(object sender, EventArgs e)
        {
            CallService service = new CallService();
            bool bFlag = service.LocalDownLoad(textBox2.Text);
            if (bFlag)
            {
                MessageBox.Show("다운로드 완료!");
            }
            else MessageBox.Show("다운로드 실패!");
        } // 다운로드 버튼
        private async void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CallService service = new CallService();
                string localfilename = openFileDialog1.FileName;

                Random rand = new Random();
                string uploadfilename = "Image" + rand.Next(99999).ToString();// localfilename.Substring(localfilename.LastIndexOf("\\") + 1, localfilename.LastIndexOf("."))

                bool bflag = await service.ServerUpload(localfilename, uploadfilename);


                if (bflag) MessageBox.Show("업로드 완료!");
                else MessageBox.Show("업로드 실패!");

            }
        } // 업로드 버튼
    }
}
