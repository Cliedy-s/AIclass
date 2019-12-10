using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System;
using IceCreamManager.VO;
using IceCreamManager.Service;

namespace IceCreamManager
{
    public partial class ProductDialogue_Form : Form
    {
        List<OffererVO> offerlist;
        List<MaterialsVO> Materlist;
  
        public ProductDialogue_Form()
        {
            InitializeComponent();


            OffererService Oservice = new OffererService();
            offerlist = Oservice.GetAllOffereData();

            MaterialsService Mservice = new MaterialsService();
            Materlist = Mservice.SelectAll();     

            if (offerlist.Count > 1)
            {
                List<string> offerNameList = (from item in offerlist
                                              select item.off_Name).ToList();
                ComboBinding(cbbOffereName, offerNameList);
            }

            int maxcode = (from item in Materlist

                           select item.mat_No).Max();

            lblProductCode.Text=(maxcode+1).ToString();



            if (Materlist.Count > 1)
            {
                List<string> protypeNameList = (from item in Materlist
                                              select item.mtt_Name).Distinct().ToList();
                ComboBinding(cbbProductType, protypeNameList);
            }
        }

        
        public static void ComboBinding(ComboBox combo, List<string> list)
        {
            combo.ValueMember = "Code";
            combo.DisplayMember = "CodeNm";
            combo.DataSource = list;
        }

        /// <summary>
        /// 리터 개수 단위
        /// </summary>
        private void rdbL_CheckedChanged(object sender, System.EventArgs e)
        { // TODO - 저희 우유같은 액체도 g으로 표시할래요?
            if (rdbL.Text == "리터")
            {
                lblType.Text = "L";
                return;
            }
            else
            {
                lblType.Text = "g";
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            MaterialsVO vo = new MaterialsVO();
            ArrayList a;
            vo.mat_No = Convert.ToInt32(lblProductCode.Text);  //자제코드

            var ofno = offerlist.Find(p => p.off_Name.Contains(cbbOffereName.Text));
           //  var ofno = (from item in offerlist
                           //where item.off_Name.Contains(cbbOffereName.Text)
                           //select item.off_No);  
            

            vo.off_No = Convert.ToInt32(ofno.off_No); //제조사번호
            vo.mat_Name = txtProductName.Text; //이름
            vo.mat_Cost =int.Parse(txtProductSum.Text); //가격
            vo.mat_Each = Convert.ToInt32(nudProductNum.Value);//개수
            vo.mtt_No = Convert.ToInt32(cbbProductType.Text);  //자제타입
            if (rdbL.Text == "리터")
            {
                // TODO - 제품마다로 수정?
                vo.mat_MinSize = 1000; //마지노선
                return;
            }
            else
            {
                vo.mat_MinSize = 100; //마지노선
            }
            vo.mat_Unit = lblType.Text; //리터 개수


    }
    }
}
