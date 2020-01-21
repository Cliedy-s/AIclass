using DTO;
using FORTEST_02_DTO;
using FORTEST_03_CLIENT.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORTEST_03_CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void rdoByProductName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoByProductName.Checked)
            {
                cmbByName.Enabled = true;
                dtpFromDate.Enabled = dtpToDate.Enabled = false;
            }
        }
        private void rdoByDateTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoByDateTime.Checked)
            {
                cmbByName.Enabled = false;
                dtpFromDate.Enabled = dtpToDate.Enabled = true;
            }
        }
        private void rboTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rboTotal.Checked)
            {
                cmbByName.Enabled = false;
                dtpFromDate.Enabled = dtpToDate.Enabled = false;
            }
        }

        private void InitControls()
        {
            //컨트롤 설정
            cmbByName.Enabled = false;
            dtpFromDate.Enabled = false;
            dtpToDate.Enabled = false;
            rboTotal.Checked = true;

            dtpFromDate.MaxDate = DateTime.Now;
            dtpToDate.MinDate = dtpFromDate.Value;

            dgvProduction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //데이터 받아와 설정
            GetDatas();
        }
        private async void GetDatas()
        {
            ProductService service = new ProductService();
            cmbByName.DisplayMember = "ProductName";
            cmbByName.ValueMember = "ProductID";
            cmbByName.DataSource = await ServiceMaster.GetListAsync<List<ProductVO>>(service, "GetProducts");
            cmbProductName.DisplayMember = "ProductName";
            cmbProductName.ValueMember = "ProductID";
            cmbProductName.DataSource = await ServiceMaster.GetListAsync<List<ProductVO>>(service, "GetProducts");

        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpToDate.MinDate = dtpFromDate.Value;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            ProductionService service = new ProductionService();
            if (rboTotal.Checked)
            {
                dgvProduction.DataSource = await ServiceMaster.GetListAsync<List<ProductNProductionVO>>(service, "GetProductionRecord");
            }
            else if (rdoByProductName.Checked)
            {
                dgvProduction.DataSource = await ServiceMaster.GetListAsync<List<ProductNProductionVO>>(service, $"GetProductionRecordByProductID/{cmbByName.SelectedValue}");
            }
            else if (rdoByDateTime.Checked)
            {
                dgvProduction.DataSource = await ServiceMaster.GetListAsync<List<ProductNProductionVO>>(service, $"GetProductionRecordByDate/{dtpFromDate.Value.ToShortDateString()}/{dtpToDate.Value.AddDays(1).ToShortDateString()}");
            }
        }
        private async void btnInsert_Click(object sender, EventArgs e)
        {
            ProductionService service = new ProductionService();
            Message<ProductionVO> msg = await ServiceMaster.PostAsync<ProductionVO>(service, "InorUpProductionRecord",
                new ProductionVO()
                {
                    ProductID = Convert.ToInt32(cmbProductName.SelectedValue)
                    ,
                    BadQuantity = Convert.ToInt32(badq.Value)
                    ,
                    Date = proddate.Value
                    ,
                    Quantity = Convert.ToInt32(q.Value)
                    ,
                    Seq = 0,
                    Time = Convert.ToInt32(runtime.Value)
                });
            MessageBox.Show(msg.ResultMessage);
            if (msg.IsSuccess)
            {
                btnSearch.PerformClick();
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductionService service = new ProductionService();
            Message<ProductionVO> msg = await ServiceMaster.PostAsync<ProductionVO>(service, "InorUpProductionRecord",
                new ProductionVO()
                {
                    ProductID = Convert.ToInt32(cmbProductName.SelectedValue)
                    ,
                    BadQuantity = Convert.ToInt32(badq.Value)
                    ,
                    Date = proddate.Value
                    ,
                    Quantity = Convert.ToInt32(q.Value)
                    ,
                    Seq = Convert.ToInt32(lblseq.Text)
                    ,
                    Time = Convert.ToInt32(runtime.Value)
                });
            MessageBox.Show(msg.ResultMessage);
            if (msg.IsSuccess)
            {
                btnSearch.PerformClick();
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblseq.Text))
            {
                MessageBox.Show("내역을 선택해주세요");
                return;
            }
            ProductionService service = new ProductionService();
            DTO.Message msg = await ServiceMaster.GetAsync(service, $"DeleteProductionRecord/{lblseq.Text}");
            MessageBox.Show(msg.ResultMessage);
            if (msg.IsSuccess) btnSearch.PerformClick();
        }

        private async void dgvProduction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProduction.SelectedRows[0];
            lblseq.Text = row.Cells[0].Value.ToString();
            cmbProductName.SelectedValue = Convert.ToInt32(row.Cells[1].Value);
            proddate.Value = Convert.ToDateTime(row.Cells[3].Value);
            runtime.Value = Convert.ToDecimal(row.Cells[4].Value);
            q.Value = Convert.ToDecimal(row.Cells[5].Value);
            badq.Value = Convert.ToDecimal(row.Cells[6].Value);
            int id = Convert.ToInt32(dgvProduction.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
