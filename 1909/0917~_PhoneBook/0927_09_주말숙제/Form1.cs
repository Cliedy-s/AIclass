using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace _0927_09_주말숙제
{
    public partial class Form1 : Form
    {
        HashSet<PhoneInfo> infoStorage;
        bool dirty = false;
        string editingFileName = string.Empty;
        string notDirthCaptionFormat = "{0} - 주소록";
        string dirthCaptionFormat = "*{0} - 주소록";

        public Form1()
        {
            InitializeComponent();
            infoStorage = new HashSet<PhoneInfo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControlName.SelectedIndex = 14;
            새로만들기ToolStripMenuItem.PerformClick();

            //tabControlName.DrawMode = TabDrawMode.OwnerDrawFixed;
            AscOrDesc.SelectedIndex = 0;
            panCompanyInsert.Location = panCollageInsert.Location;
            panCompanyInsert.Visible = panCollageInsert.Visible = false;

            Dictionary<string, int> cmbYearDic = new Dictionary<string, int>();
            cmbYearDic.Add("1학년", 1);
            cmbYearDic.Add("2학년", 2);
            cmbYearDic.Add("3학년", 3);

            cmbYear.DataSource = new BindingSource(cmbYearDic, null);
            cmbYear.DisplayMember = "Key";
            cmbYear.ValueMember = "Value";
            cmbYear.SelectedIndex = 1;


            SetListView();

            List<PhoneInfo> list = new List<PhoneInfo>(infoStorage);
            list.ForEach((elem) => { if("name".CompareTo(elem.Name) ==0) list.Remove(elem); }) ;
            list.RemoveAll((elem)=>elem.Name.CompareTo("name")==0);

        }

        /*
        public void deleteData()
        {
            Console.Write("이름: ");
            string name = Console.ReadLine();

            bool bFlag = false;
            foreach (var curInfo in infoStorage)
            {
                if (name.CompareTo(curInfo.Name) == 0)
                {
                    infoStorage.Remove(curInfo);
                    bFlag = true;
                    Console.WriteLine("주소록 삭제가 완료되었습니다. \n");
                    break;
                }
            }
        }
        public void sortData()
        {
            //Console.WriteLine("데이터 정렬을 시작합니다..");
            //Console.WriteLine("1.이름 ASC, 2.이름 DESC, 3.핸드폰번호 ASC, 4.핸드폰번호 DESC ");
            //Console.Write("선택>> ");

            if (choice < 1 || choice > 4)
                throw new MenuChoiceException(choice);

            List<PhoneInfo> list = new List<PhoneInfo>(infoStorage);

            if (choice == 1)
            {
                list.Sort();
            }
            else if (choice == 2)
            {
                list.Sort();
                list.Reverse();
                // list.Sort(new Comparison<PhoneInfo>( (i1, i2) => i2.CompareTo(i1) ));
            }
            else if (choice == 3)
            {
                list.Sort(new PhoneComparator());
            }
            else
            {
                list.Sort(new PhoneComparator());
                list.Reverse();
            }

            foreach (PhoneInfo curInfo in list)
            {
                Console.WriteLine(curInfo.ToString());
            }

            Console.WriteLine("데이터 정렬이 완료되었습니다. \n");
        }
        public void loadData()
        {
        }
        */

        #region controlEvents
        private void TxtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        } // txtYear에 숫자 안들어가게 하기
        private void 휴대폰번호PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comparison<PhoneInfo> compare = null;
            if (AscOrDesc.SelectedIndex == 0)
                compare += (i1, i2) => i1.PhoneNumber.CompareTo(i2.PhoneNumber);
            else
                compare += (i1, i2) => i2.PhoneNumber.CompareTo(i1.PhoneNumber);
            List<PhoneInfo> list = new List<PhoneInfo>(infoStorage);
            list.Sort(new Comparison<PhoneInfo>(compare));
            infoStorage = new HashSet<PhoneInfo>(list);
            showPhonebook();

        } // 휴대폰 번호 정렬
        private void 이름PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comparison<PhoneInfo> compare = null;
            if (AscOrDesc.SelectedIndex == 0)
                compare += (i1, i2) => i1.Name.CompareTo(i2.Name);
            else
                compare += (i1, i2) => i2.Name.CompareTo(i1.Name);
            List<PhoneInfo> list = new List<PhoneInfo>(infoStorage);
            list.Sort(new Comparison<PhoneInfo>(compare));
            infoStorage = new HashSet<PhoneInfo>(list);
            showPhonebook();
        } // 이름 정렬
        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.RestoreDirectory = true;
            openFile.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
            openFile.FilterIndex = 0;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                editingFileName = openFile.FileName;
                if (!File.Exists(editingFileName)) return;
                try
                {
                    using (Stream rs = new FileStream(editingFileName, FileMode.Open))
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();

                        HashSet<PhoneInfo> phoneInfos;
                        phoneInfos = (HashSet<PhoneInfo>)deserializer.Deserialize(rs);

                        this.infoStorage = phoneInfos;
                    }
                    dirty = false;
                    UpdateFormText();
                }
                catch (IOException err)
                {
                    Debug.WriteLine(err.Message);
                }
                showPhonebook();
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstPhoneInfo.Items.Count; i++)
            {
                if ( lstPhoneInfo.Items[i].SubItems[0].Text == txtSearch.Text)
                {
                    lstPhoneInfo.Items[i].Selected = true;
                    lstPhoneInfo_DoubleClick(null, null);
                    break;
                }
            }
        }
        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingFileName.Length < 1)
            {
                saveAsData();
            }
            else
            {
                FileStream fs = null;
                try
                {
                    using (Stream ws = new FileStream(editingFileName, FileMode.OpenOrCreate))
                    {
                        BinaryFormatter serializer = new BinaryFormatter();
                        serializer.Serialize(ws, infoStorage);
                    }
                }
                finally
                {
                    dirty = false;
                    UpdateFormText();
                }
            }
        }
        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsData();
        }
        private void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtMajor.Text = "";
            txtCompany.Text = "";
            cmbYear.SelectedIndex = 0;

            if (rdoNomal.Checked)
            {
                panCompanyInsert.Visible = panCollageInsert.Visible = false;
            }
            else if (rdoCollage.Checked)
            {
                panCollageInsert.Visible = true;
                panCompanyInsert.Visible = false;
            }
            else if (rdoCompany.Checked)
            {
                panCollageInsert.Visible = false;
                panCompanyInsert.Visible = true;
            }
        } // 라디오 버튼
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string choice = "일반";
            foreach (var item in grpRadios.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radio = item as RadioButton;
                    if (radio.Checked) choice = radio.Text;
                }
            }
            PhoneInfo info = null;

            switch (choice)
            {
                case "일반":
                    info = readFriendInfo();
                    break;
                case "대학":
                    info = readUnivFriendInfo();
                    break;
                case "회사":
                    info = readCompanyFriendInfo();
                    break;
            }

            bool isAdded = infoStorage.Add(info);
            if (!isAdded)
            {
                MessageBox.Show("이미 저장된 사람입니다.");
            }
            SetEdittied();
            showPhonebook();
        } // 연락처 추가 버튼
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            infoStorage.Remove(searchName(txtName.Text));
            btnAdd.PerformClick();
        } // 연락처 수정 버튼
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            infoStorage.Remove(searchName(txtName.Text));
            SetEdittied();
            showPhonebook();
        } // 연락처 삭제 버튼
        private void lstPhoneInfo_DoubleClick(object sender, EventArgs e)
        {
            PhoneInfo info = searchName(lstPhoneInfo.SelectedItems[0].SubItems[0].Text);
            if (info is PhoneUnivInfo)
            {
                PhoneUnivInfo univinfo = info as PhoneUnivInfo;
                rdoCollage.Checked = true;
                panCollageInsert.Visible = true;
                panCompanyInsert.Visible = false;
                txtMajor.Text = univinfo.Major;
                cmbYear.SelectedIndex = univinfo.Year;
            }
            else if (info is PhoneCompanyInfo)
            {
                PhoneCompanyInfo companyinfo = info as PhoneCompanyInfo;
                rdoCompany.Checked = true;
                panCollageInsert.Visible = false;
                panCompanyInsert.Visible = true;
                txtCompany.Text = companyinfo.Company;
            }
            else
            {
                panCollageInsert.Visible =  panCompanyInsert.Visible = false;
                rdoNomal.Checked = true;
            }
            txtName.Text = info.Name;
            txtPhoneNumber.Text = info.PhoneNumber;
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            string str = tabControl.SelectedTab.Text;
            if (str != "All")
            {
                char cTo = Convert.ToChar(str);
                char cUntil = '\0';

                ////
                //int iTo = Convert.ToInt32(Convert.ToChar(tabControl.SelectedTab.Text));
                //string size = "498";
                //int iUntil = iTo + Convert.ToInt32(Convert.ToInt32(size, 16));

                //char TempcUntil = Convert.ToChar(iUntil);
                //MessageBox.Show(TempcUntil + "");
                ////

                switch (cTo)
                {
                    case '가':
                        cUntil = '나';
                        break;
                    case '나':
                        cUntil = '다';
                        break;
                    case '다':
                        cUntil = '라';
                        break;
                    case '라':
                        cUntil = '마';
                        break;
                    case '마':
                        cUntil = '바';
                        break;
                    case '바':
                        cUntil = '사';
                        break;
                    case '사':
                        cUntil = '아';
                        break;
                    case '아':
                        cUntil = '자';
                        break;
                    case '자':
                        cUntil = '차';
                        break;
                    case '차':
                        cUntil = '카';
                        break;
                    case '카':
                        cUntil = '타';
                        break;
                    case '타':
                        cUntil = '파';
                        break;
                    case '파':
                        cUntil = '하';
                        break;
                    case '하':
                        cUntil = Convert.ToChar(Convert.ToInt32('힣') + 1);
                        break;
                    default:
                        break;
                }
                SetListView();
                foreach (var item in infoStorage)
                {
                    if (Convert.ToChar(item.Name.Substring(0, 1)) >= cTo && Convert.ToChar(item.Name.Substring(0, 1)) <= cUntil)
                    {
                        lstPhoneInfo.Items.Add(new ListViewItem(new string[] { item.Name, item.PhoneNumber }));
                    }
                }

            }
            else
            {
                showPhonebook();
            }


        }
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("새로만들기 클릭");
            lstPhoneInfo.Clear();
            dirty = false;
            editingFileName = string.Empty;
            UpdateFormText();
            SetListView();
        }
        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void showPhonebook()
        {
            SetListView();
            foreach (var item in infoStorage)
            {
                lstPhoneInfo.Items.Add(new ListViewItem(new string[] { item.Name, item.PhoneNumber }));
            }
        }
        private PhoneInfo searchName(String name)
        {
            foreach (var curInfo in infoStorage)
            {
                if (name.CompareTo(curInfo.Name) == 0)
                    return curInfo;
            }
            return null;
        }
        #region readInfos
        private PhoneInfo readFriendInfo()
        {
            String name = txtName.Text;
            String phone = txtPhoneNumber.Text;
            return new PhoneInfo(name, phone);
        }
        private PhoneInfo readUnivFriendInfo()
        {
            String name = txtName.Text;
            String phone = txtPhoneNumber.Text;
            String major = txtMajor.Text;
            int year = int.Parse(cmbYear.SelectedValue.ToString());
            return new PhoneUnivInfo(name, phone, major, year);
        }
        private PhoneInfo readCompanyFriendInfo()
        {
            String name = txtName.Text;
            String phone = txtPhoneNumber.Text;
            String company = txtCompany.Text;
            return new PhoneCompanyInfo(name, phone, company);

        }
        #endregion
        public void saveAsData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                editingFileName = saveFileDialog.FileName;
                using (Stream ws = new FileStream(editingFileName, FileMode.Create))
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(ws, infoStorage);
                }
                dirty = false;
                UpdateFormText();
            }
        }
        private void UpdateFormText()
        {
            string filename = string.Empty;
            if (editingFileName.Length > 1)
            {
                filename = editingFileName.Substring(editingFileName.LastIndexOf("\\") + 1);
            }
            else
            {
                filename = "제목없음";
            }

            if (dirty)
            {
                this.Text = string.Format(dirthCaptionFormat, filename);
            }
            else
            {
                this.Text = string.Format(notDirthCaptionFormat, filename);
            }
        }
        private void SetListView()
        {
            lstPhoneInfo.Clear();
            lstPhoneInfo.View = View.Details;
            lstPhoneInfo.Columns.Add("이름", 80, HorizontalAlignment.Left);
            lstPhoneInfo.Columns.Add("번호", 120, HorizontalAlignment.Left);
            lstPhoneInfo.FullRowSelect = true;
        }
        private void SetEdittied()
        {
            if (!dirty)
            {
                dirty = true;
                UpdateFormText();
            }
        }

    }
}
