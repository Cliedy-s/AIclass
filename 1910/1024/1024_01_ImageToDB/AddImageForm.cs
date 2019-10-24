using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1024_01_ImageToDB
{
    public partial class AddImageForm : Form
    {
        public AddImageForm(string pid, string pname)
        {
            InitializeComponent();

            lblProductID.Text = pid;
            lblProductName.Text = pname;
            // TODO - lblProductID.Visible = false; // 개발 완료후
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            // 커서
            Cursor currentCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            // 파일 찾기
            try
            {
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName.ToString();
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Tag = openFileDialog1.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                this.Cursor = currentCursor;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("저장할 이미지를 선택하여 주세요");
                return;
            }

            Cursor currentCursor = this.Cursor;
            string destFile, sPath, sFileName, sExt;
            destFile = sPath = sFileName = sExt = string.Empty;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //경로 생성
                string localFile = pictureBox1.Tag.ToString().Replace("\\", "/");
                sPath = string.Format("productImage/{0}/", lblProductID.Text);
                sExt = localFile.Substring(localFile.LastIndexOf("."));
                sFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + sExt;

                // 폴더 생성
                DirectoryInfo dir = new DirectoryInfo(sPath);
                if (!dir.Exists)
                    dir.Create();

                // 파일 저장
                destFile = Path.Combine(Environment.CurrentDirectory.Replace("\\", "/"), sPath, sFileName); // 현재 exe가 실행중인 경로를 절대경로로
                File.Copy(pictureBox1.Tag.ToString(), destFile, true);

                // DB저장
                string strConn = ConfigurationManager.ConnectionStrings["imageadd"].ConnectionString;
                using(MySqlConnection conn = new MySqlConnection(strConn))
                {
                    string sql = string.Format("INSERT INTO productImage(productID, productImgFileName) VALUES({0}, '{1}'); ", lblProductID.Text, sPath + sFileName);

                    MySqlCommand comm = new MySqlCommand(sql, conn);

                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                MessageBox.Show("이미지가 성공적으로 저장되었습니다.");
                this.DialogResult = DialogResult.OK;
            }
            catch
            {

            }
            finally{
                this.Cursor = currentCursor;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("저장할 이미지를 선택하여 주세요");
                return;
            }

            Cursor currentCursor = this.Cursor;
            string destFile, sPath, sFileName, sExt;
            sPath = sFileName = string.Empty;


            try
            {
                this.Cursor = Cursors.WaitCursor;

                //경로 생성
                string localFile = pictureBox1.Tag.ToString().Replace("\\", "/");

                byte[] ImageData;
                FileStream fs = new FileStream(localFile, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                // DB저장
                string strConn = ConfigurationManager.ConnectionStrings["imageadd"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand comm = new MySqlCommand();
                    comm.CommandText = "INSERT INTO productImage(productID, productImage) VALUES(@productID, @productImage); ";
                    comm.Connection = conn;

                    comm.Parameters.Add(new MySqlParameter("@productID", MySqlDbType.Int32));
                    comm.Parameters.Add(new MySqlParameter("@productImage", MySqlDbType.LongBlob));

                    comm.Parameters["@productID"].Value = lblProductID.Text; // ? => 잘됨
                    comm.Parameters["@productImage"].Value = ImageData;

                    conn.Open();
                    int rowsAffected = comm.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("이미지가 성공적으로 저장되었습니다.");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                this.Cursor = currentCursor;
            }

        } // BLOP 저장
    }
}
