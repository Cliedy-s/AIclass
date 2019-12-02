using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1125_ListLinqSampleUI
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { //주문하기

        }

        private void button1_Click(object sender, EventArgs e)
        {   // 장바구니 추가

        }

        List<ComboItemVO> allList;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            string codeTypes = "Categories@Customers@Employees@Shippers";
            CommonService service = new CommonService();
            allList = service.GetCodeInfoByCodeTypes(codeTypes, "@");

            InitControls();
        }

        private void InitControls()
        {
            //납기 예정일은 7일 후로 기본 셋팅
            dtpRequiredDate.Value = DateTime.Now.AddDays(7);

            CommonUtil.InitSettingDridView(dgvCart);
            CommonUtil.InitSettingDridView(dgvOrder);
            CommonUtil.InitSettingDridView(dgvOrderDetail);

            List<ComboItemVO> CategoriesList
                = (from item in allList
                   where item.CodeType == "Categories"
                   select item).ToList();
            CommonUtil.ComboBinding(cboCategories, CategoriesList, "");
            List<ComboItemVO> CustomersList
                = (from item in allList
                   where item.CodeType == "Customers"
                   select item).ToList();
            CommonUtil.ComboBinding(cboCustomers, CustomersList);
            CommonUtil.ComboBinding(cboCustomers2, CustomersList, "선택");
            List<ComboItemVO> EmployeesList
                = (from item in allList
                   where item.CodeType == "Employees"
                   select item).ToList();
            CommonUtil.ComboBinding(cboEmployees, EmployeesList);
            CommonUtil.ComboBinding(cboEmployees2, EmployeesList, "선택");
            List<ComboItemVO> ShippersList
                = (from item in allList
                   where item.CodeType == "Shippers"
                   select item).ToList();
            CommonUtil.ComboBinding(cboShippers, ShippersList, "선택");


            // cboEmployees cboCustomers cboProducts cboCategories cboShippers
        }

        List<ProductInfoVO> productAllList;
        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCategories.SelectedIndex > 0 && cboCategories.SelectedValue != null)
            {
                string cateCode = cboCategories.SelectedValue.ToString();
                OrderService service = new OrderService();
                productAllList = service.getProductsInfoByCategoryID(cateCode);
                CommonUtil.ComboBinding(cboProducts, productAllList, "ProductID", "ProductName", "선택");

            }
        }
    }
}
