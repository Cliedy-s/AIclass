﻿using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class Offerer_Form : Form
    {
        List<OffererVO> offerlist;
        List<MaterialsVO> Materlist;
     
        public Offerer_Form()
        {
            InitializeComponent();
        }
        private void Offerer_Form_Load(object sender, EventArgs e)
        {
            //제조사 그리드뷰
            DatagridviewDesigns.SetDesign(dgvOfferer);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOfferer, "코드", "off_No", true, 60); //제조사코드
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOfferer, "이름", "off_Name", true, 120); //제조사이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOfferer, "번호", "off_OwnerMobile", true, 100); //제조사전화번호      
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOfferer, "담당자", "off_Manager", true, 80); //담당자이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvOfferer, "주소", "off_Addr", true, 300); //제조사주소

            //제품 그리드뷰
            DatagridviewDesigns.SetDesign(dgvProduct);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "코드", "mat_No", true, 60); //제조사이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "자제명", "mat_Name", true, 200); //제조사전화번호      
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "자제타입", "mtt_Name", true, 80); //제조사주소          
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "가격", "mat_Cost", true, 70); //담당자이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "개수", "mat_Each", true, 70); //담당자이름
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProduct, "타입", "mat_Unit", true, 60); //담당자이름
            OffererService Oservice = new OffererService();
            offerlist = Oservice.GetAllOffereData();
            dgvOfferer.DataSource = offerlist;

            DataLoad();

            
            Dictionary<string, string> citem = new Dictionary<string, string>();
            citem.Add("타입", "0");
            citem.Add("담당자", "1");
            cbbfilter1.DataSource = new BindingSource(citem,null);
            cbbfilter1.DisplayMember = "Key";
            cbbfilter1.ValueMember = "Value";


            Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // 60초
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        /// <summary>
        /// 제조사 && 제조품목 load
        /// </summary>
        public void DataLoad()
        {

            MaterialsService Mservice = new MaterialsService();
            Materlist = Mservice.SelectAll();
      
            dgvProduct.DataSource = Materlist;

        }

        private void setting()
        {
            lblOffererName.Text = string.Empty;

            lblCode.Text = string.Empty;
            lblmatName.Text = string.Empty;
            lblmatMoney.Text = string.Empty;
            lblmatType.Text = string.Empty;
            lblmat_Each.Text = string.Empty;
            lblType.Text = string.Empty;
        }

        /// <summary>
        /// 제품등록버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductDialogue_Form frm = new ProductDialogue_Form();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        /// <summary>
        /// 제조사 그리드뷰 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOfferer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setting();
            if (dgvOfferer.SelectedRows.Count < 1)
            {
                return;
            }
            List<MaterialsVO> selectMaterials = (from item in Materlist
                                                 where item.off_No == Convert.ToInt32(dgvOfferer.SelectedRows[0].Cells[0].Value)
                                                 select item).ToList();

           // int a = selectMaterials?.Count ?? 0;
            dgvProduct.DataSource = selectMaterials;

        }
        /// <summary>
        /// 제품 그리드뷰 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProduct.SelectedRows.Count < 1)
            {
                return;
            }

            var mano = Materlist.Find(p => p.mat_No == Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value));

            OffererVO ofno = offerlist.Find(p => p.off_No == mano.off_No);

            if (ofno == null)
            {
                lblOffererName.Text = "자체상품";
            }
            else
            {
                lblOffererName.Text = ofno.off_Name.ToString().Trim(); //제조사이름
            }

            lblCode.Text = mano.mat_No.ToString(); //자제코드    
            lblmatName.Text = mano.mat_Name; //자제이름
            lblmatMoney.Text = mano.mat_Cost.ToString();//가격
            lblmatType.Text = mano.mtt_Name;//타입
            lblmat_Each.Text = mano.mat_Each.ToString();
            lblType.Text = mano.mat_Unit;

        }

        /// <summary>
        /// 제품전체
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PtbRefresh_Click(object sender, EventArgs e)
        {
            DataLoad();
            dgvOfferer.ClearSelection();
        }
        /// <summary>
        /// 제조사 상세정보
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 상세정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofno = offerlist.Find(p => p.off_No == Convert.ToInt32(dgvOfferer.SelectedRows[0].Cells[0].Value));

            OffererDialogue_Form frm = new OffererDialogue_Form();
            frm.Off_No = ofno.off_No;
            frm.Off_Name = ofno.off_Name;
            frm.Off_OwnerName = ofno.off_OwnerName;
            frm.Off_OwnerMobile = ofno.off_OwnerMobile;
            frm.Off_Manager = ofno.off_Manager;
            frm.Off_ManagerMobile = ofno.off_ManagerMobile;
            frm.Off_Addr = ofno.off_Addr;

            if (frm.ShowDialog() == DialogResult.OK)
            {

                DataLoad();
            }


        }
        /// <summary>
        /// 제품수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mano = Materlist.Find(p => p.mat_No == Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value));

            ProductDialogue_Form frm = new ProductDialogue_Form();

            OffererVO ofno = offerlist.Find(p => p.off_No == mano.off_No);

            if (ofno == null)
            {
                frm.Off_Name = string.Empty;
            }
            else
            {
                frm.Off_Name = ofno.off_Name.ToString().Trim(); //제조사이름
            }

            frm.Mat_Name = mano.mat_Name;
            frm.Mat_no = mano.mat_No;
            frm.Mat_Cost = mano.mat_Cost;
            frm.Mat_Each = mano.mat_Each;
            frm.Mat_MinSize = mano.mat_MinSize;
            frm.Mtt_Name = mano.mtt_Name;
            frm.Mat_Unit = mano.mat_Unit;

            if (frm.ShowDialog() == DialogResult.OK) { }

        }/// <summary>
        /// 제품삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialsService service = new MaterialsService();
                int id;
                int.TryParse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString(), out id);
                service.Delete(id);
            }
            catch (Exception)
            {
                MessageBox.Show("BOM등록된자제로 삭제하실 수 없습니다.");
            }
          
    

            DataLoad();
        }


        /// <summary>
        /// 검색1 이름만검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (cbbSearchType.Text == "제조사")
            {
                foreach (DataGridViewRow row in dgvOfferer.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(txtSearch.Text))
                    {
                        row.Cells[1].Selected = true;
                        check = true;

                    }
                }
            }
            else//제품
            {
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {

                    if (row.Cells[1].Value.ToString().Contains(txtSearch.Text))
                    {
                        row.Cells[1].Selected = true;
                        check = true;
                    }
                }

            }
            if (!check)
            {
                MessageBox.Show("입력하신정보가 없습니다.");

                txtSearch.Text = string.Empty;
            }
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))

                    btnSearch.PerformClick();

                else
                    DataLoad();
            }
        }
        /// <summary>
        /// 검색2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cbbfilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cbbfilter1.SelectedIndex.ToString() == "0") //타입으로 찾기
            {
                MaterialsService mservice = new MaterialsService();
                MaterialTypeService mtservice = new MaterialTypeService();
                List<MaterialsTypeVO> Matertypelist = mtservice.Materials_Type();
                cbbfilter2.DataSource = Matertypelist;

                if (Matertypelist.Count > 1)
                {
                    cbbfilter2.DataSource = Matertypelist;
                    cbbfilter2.ValueMember = "mtt_No";
                    cbbfilter2.DisplayMember = "mtt_Name";
                }
            }
            else// 담당자로 찾기
            {
                List<string> name = (from item in offerlist

                                     select item.off_Manager).ToList();
                cbbfilter2.DataSource = name;                       
            }
        }
        /// <summary>
        /// 검색2 버튼
        /// </summary>
        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            MaterialsSearch_Form frm = new MaterialsSearch_Form();
            frm.Filter1 = cbbfilter1.Text;
            frm.Filter2 = cbbfilter2.Text;
            frm.ShowDialog();
        }

        private void picOrder_Click(object sender, EventArgs e)
        {
            OffererOder_Form frm = new OffererOder_Form();
            frm.ShowDialog();
        }

        /// <summary>
        /// 시간마다 초기화 1분마다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
             DataLoad();
        }
    }
}
