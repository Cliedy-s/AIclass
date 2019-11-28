using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1125_ListLinqSampleVO;
using Excel = Microsoft.Office.Interop.Excel;

namespace _1125_ListLinqSampleUI
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            #region ToolBarMerge
            this.Activated += new EventHandler(this.frmEmployee_Activated);
            this.Deactivate += new EventHandler(this.frmEmployee_Deactivate);
            this.FormClosing += new FormClosingEventHandler(this.frmEmployee_FormClosing);
            this.Shown += new EventHandler(this.frmEmployee_Shown);
            (this.MdiParent as MainForm).Save += SaveThisForm;
            #endregion

            InitControls();
            DataLoad();
        }
        #region ToolBarMerge
        private void MergeToolStrip()
        {
            MainForm mfrm = this.ParentForm as MainForm;
            mfrm.AppendToolStrip(this.toolStrip1);
            this.toolStrip1.Visible = false;

        }
        private void UnmergeToolStrip()
        {
            MainForm mfrm = this.ParentForm as MainForm;
            mfrm.RemoveToolStrip(this.toolStrip1);
        }
        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            MergeToolStrip();
        }
        private void frmEmployee_Shown(object sender, EventArgs e)
        {
            MergeToolStrip();
        }
        private void frmEmployee_Deactivate(object sender, EventArgs e)
        {
            UnmergeToolStrip();
        }
        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnmergeToolStrip();
            (this.MdiParent as MainForm).Save -= new EventHandler(SaveThisForm);
        }
        private void SaveThisForm(object sender, EventArgs e)
        {
            if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                MessageBox.Show("frmEmployee 저장");
        }
        #endregion
        List<EmployeeVO> allload;
        private void InitControls()
        {
            lblEmployeeID.Text = "";
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.picPicture.ImageLocation = "Images/kakaodefaultimage2.jpg";
            dtpBirthDate.Value = DateTime.Now.AddYears(-25);
        }
        private void DataLoad()
        {
            EmployeeService service = new EmployeeService();
            allload = service.GetAllEmployee();
            dgvEmployees.DataSource = allload;
        }

        StringBuilder sberror;
        private void btnRegisterText_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateRegistration())
                {
                    MessageBox.Show(sberror.ToString(), "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EmployeeVO vo = new EmployeeVO();
                vo.LastName = txtLastName.Text;
                vo.FirstName = txtFirstName.Text;
                vo.Title = txtTitle.Text;
                vo.BirthDate = dtpBirthDate.Value.ToShortDateString();
                vo.HireDate = dtpHireDate.Value.ToShortDateString();
                vo.HomePhone = txtHomePhone.Text.Trim();
                vo.Notes = txtNotes.Text.Trim();

                FileStream fs = new FileStream(picPicture.ImageLocation, FileMode.Open, FileAccess.Read);
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);
                vo.Photo = bImage;

                EmployeeService service = new EmployeeService();
                bool bResult = service.RegisterEmployee(vo);
                if (bResult)
                    MessageBox.Show("성공적으로 등록되었습니다.");
                else
                    MessageBox.Show("등록 중 오류가 발생하였습니다.");

                //txtFirstName txtLastName txtTitle dtpBirthDate dtpHireDate txtHomePhone txtNotes
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private bool ValidateRegistration()
        {
            sberror = new StringBuilder();
            string phonePattern = @"^\d{2,3}-\d{3,4}-\d{4}$";

            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()))
                sberror.Append("이름을 입력하세요.\n");
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
                sberror.Append("직책을 입력하세요.\n");
            if (string.IsNullOrEmpty(txtHomePhone.Text.Trim()))
                sberror.Append("전화번호을 입력하세요.\n");

            if (!Regex.IsMatch(txtHomePhone.Text, phonePattern))
                sberror.Append("전화 번호 형식이 아닙니다.\n");

            if (sberror.ToString() != string.Empty)
            {
                sberror.Insert(0, "등록실패\n");
                return false;
            }
            else
                return true;
        }

        private void btnPictrue_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPicture.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnRegisterSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateRegistration())
                {
                    MessageBox.Show(sberror.ToString(), "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EmployeeVO vo = new EmployeeVO();
                vo.LastName = txtLastName.Text;
                vo.FirstName = txtFirstName.Text;
                vo.Title = txtTitle.Text;
                vo.BirthDate = dtpBirthDate.Value.ToShortDateString();
                vo.HireDate = dtpHireDate.Value.ToShortDateString();
                vo.HomePhone = txtHomePhone.Text.Trim();
                vo.Notes = txtNotes.Text.Trim();

                FileStream fs = new FileStream(picPicture.ImageLocation, FileMode.Open, FileAccess.Read);
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);
                vo.Photo = bImage;

                EmployeeService service = new EmployeeService();
                bool bResult = service.RegisterEmployeeSP(vo);
                if (bResult)
                    MessageBox.Show("성공적으로 등록되었습니다.");
                else
                    MessageBox.Show("등록 중 오류가 발생하였습니다.");

                //txtFirstName txtLastName txtTitle dtpBirthDate dtpHireDate txtHomePhone txtNotes
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length > 0)
            {
                string keyword = txtSearch.Text.Trim();
                List<EmployeeVO> searchList = null;
                if (rdoTitle.Checked)
                    searchList
                        = (from item in allload
                           where item.Title.Contains(keyword)
                           select item
                           ).ToList();
                else if (rdoName.Checked)
                    searchList
                        = (from item in allload
                           where item.FirstName.Contains(keyword) || item.LastName.Contains(keyword)
                           select item
                           ).ToList();
                else if (rdoHireDateYear.Checked)
                    searchList
                           = (from item in allload
                              where item.HireDate.Substring(0, 4) == keyword
                              select item
                           ).ToList();
                dgvEmployees.DataSource = searchList;
            }
            else
                dgvEmployees.DataSource = allload;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataLoad();
            rdoHireDateYear.Checked = rdoName.Checked = rdoTitle.Checked = false;
            txtSearch.Text = "";
            dgvEmployees.DataSource = allload;
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int empID = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value);
            EmployeeService service = new EmployeeService();
            EmployeeVO emp = service.GetEmployeeById(empID);

            if (emp != null)
            { 
                lblEmployeeID.Text = emp.EmployeeID.ToString();
                txtFirstName2.Text = emp.FirstName;
                txtLastName2.Text = emp.LastName;
                txtTitle2.Text = emp.Title;
                dtpBirthDate2.Value = Convert.ToDateTime(emp.BirthDate);
                dtpHireDate2.Value = Convert.ToDateTime(emp.HireDate);
                txtHomePhone2.Text = emp.HomePhone;
                txtNotes2.Text = emp.Notes;
                if (emp.Photo != null && emp.Photo.Length > 0)
                {
                    TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                    picPicture2.Image = (Bitmap)(tc.ConvertFrom(emp.Photo));
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var dataList = dgvEmployees.DataSource as List<EmployeeVO>;
                Excel.Application excel = new Excel.Application();
                excel.Application.Workbooks.Add(true);

                // Column Name
                int cindex = 1;
                foreach (PropertyInfo property in typeof(EmployeeVO).GetProperties())
                {
                    //if (!property.Name.Equals("Photo"))
                    //{
                    excel.Cells[1, cindex] = property.Name;
                    cindex++;
                    //}
                }

                // Datas
                int rindex = 1;
                foreach (EmployeeVO emp in dataList)
                {
                    rindex++;
                    cindex = 1;
                    foreach (PropertyInfo property in typeof(EmployeeVO).GetProperties())
                    {
                        if (property.GetValue(emp, null) != null)
                        {
                            excel.Cells[rindex, cindex] = property.GetValue(emp, null).ToString();
                            cindex++;

                        }
                    }
                }
                // 파일 마무리
                //1.파일 보이게하기
                excel.Visible = true;
                Excel.Worksheet worksheet = excel.ActiveSheet as Excel.Worksheet;
                worksheet.Activate();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblEmployeeID.Text.Length < 1)
                return;
            try
            {
                EmployeeVO emp = new EmployeeVO();
                emp.EmployeeID = Convert.ToInt32(lblEmployeeID.Text);
                emp.LastName = txtLastName2.Text;
                emp.FirstName = txtFirstName2.Text;
                emp.Title = txtTitle2.Text;
                emp.BirthDate = dtpBirthDate2.Value.ToShortDateString();
                emp.HireDate = dtpHireDate2.Value.ToShortDateString();
                emp.HomePhone = txtHomePhone2.Text.Trim();
                emp.Notes = txtNotes2.Text.Trim();

                // 이미지를 변경하지 않았을 경우 PictureBox에 경로가 없음. => 이미지를 바이트배열로 전달
                emp.Photo = ImageConverterHelper.ImageToByte(picPicture2.Image);

                EmployeeService service = new EmployeeService();
                bool bResult = service.UpdateEmployee(emp);
                if (bResult)
                    MessageBox.Show("성공적으로 수정되었습니다.");
                else
                    MessageBox.Show("수정 중 오류가 발생하였습니다.");

                //txtFirstName txtLastName txtTitle dtpBirthDate dtpHireDate txtHomePhone txtNotes
                btnRefresh.PerformClick();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnPicture2_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPicture2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblEmployeeID.Text.Length < 1)
                return;
            try
            {
                // 이미지를 변경하지 않았을 경우 PictureBox에 경로가 없음. => 이미지를 바이트배열로 전달
                EmployeeService service = new EmployeeService();
                bool bResult = service.DeleteEmployee(Convert.ToInt32(lblEmployeeID.Text));
                if (bResult)
                    MessageBox.Show("성공적으로 삭제되었습니다.");
                else
                    MessageBox.Show("삭제 중 오류가 발생하였습니다.");

                //txtFirstName txtLastName txtTitle dtpBirthDate dtpHireDate txtHomePhone txtNotes
                btnRefresh.PerformClick();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
