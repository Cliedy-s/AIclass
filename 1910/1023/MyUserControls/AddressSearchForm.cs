using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyUserControls
{
    public partial class AddressSearchForm : Form
    {
        string zip;
        string addr1;
        string addr2;

        public string Zip { get => zip; }
        public string Addr1 { get => addr1; }
        public string Addr2 { get => addr2; }

        public AddressSearchForm()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    btnSearch.PerformClick();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string currentPage = "1";
            string countPerPage = "1000";
            string confmKey = ConfigurationManager.AppSettings["confmKey"];
            string keyword = txtSearch.Text.Trim();
            string apiurl = string.Empty;

            apiurl = string.Format(
                "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage={0}&countPerPage={1}&keyword={2}&confmKey={3}"
                , currentPage, countPerPage, keyword, confmKey);
            Debug.WriteLine(apiurl);
            string sss = apiurl;

            WebClient wc = new WebClient(); // url을 읽는 애
            XmlReader read = new XmlTextReader(wc.OpenRead(apiurl)); //읽어서 xmltext에 xml파일을 넣음
            DataSet ds = new DataSet();
            ds.ReadXml(read); // xml파일을 dataset에서 읽음
            dgvSearchData.DataSource = ds.Tables["juso"];
        }

        private void AddrSearchForm_Load(object sender, EventArgs e)
        {
            dgvSearchData.AutoGenerateColumns = false;
            dgvSearchData.AllowUserToAddRows = false;
            dgvSearchData.MultiSelect = false;
            dgvSearchData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddNewColumnToDataGridView("우편번호", "zipNo", dgvSearchData, typeof(string), 100);
            AddNewColumnToDataGridView("주소1", "roadAddr", dgvSearchData, typeof(string), 100);
            AddNewColumnToDataGridView("주소2", "jibunAddr", dgvSearchData, typeof(string), 100);

        }
        public void AddNewColumnToDataGridView(string headerText, string dataPropertyName,
                                                                    DataGridView dataGridView, Type type, int colWidth = 100, string name = null, bool visibility = true,
                                                                    DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleCenter)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Name = name ?? dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = type;
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = alignment;
            dataGridView.Columns.Add(col);
        }

        private void DgvSearchData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvSearchData.DataSource;
            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                txtRoadZipCode.Text = dt.Rows[e.RowIndex]["zipNo"].ToString();
                txtRoadAddr1.Text = dt.Rows[e.RowIndex]["roadAddrPart1"].ToString();
                txtRoadAddr2.Text = dt.Rows[e.RowIndex]["roadAddrPart2"].ToString();

                txtRoadAddr2.Enabled = true;
            }
        }

        private void BtnRoad_Click(object sender, EventArgs e)
        {
            if (txtRoadAddr2.Text.Length > 0)
            {
                zip = txtRoadZipCode.Text;
                addr1 = txtRoadAddr1.Text;
                addr2 = txtRoadAddr2.Text;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("상세주소를 입력하여 주세요.");
            }
        }
    }
}
