using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1125_ListLinqSampleUI
{
    public partial class frmOrder : Form
    {
        List<ComboItemVO> allList;
        List<ProductInfoVO> productAllList;
        List<OrderDetailVO> orderDetailsList;

        List<OrderInfoVO> orderSearchList;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            #region showinfos
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Debug.WriteLine("Current Doamin Name : " + currentDomain.FriendlyName);
            foreach (Assembly asm in currentDomain.GetAssemblies())
            {
                Debug.WriteLine("  " + asm.FullName);
                foreach (Module module in asm.GetModules())
                {
                    Debug.WriteLine("    " + module.FullyQualifiedName);
                    foreach (Type type in module.GetTypes())
                    {
                        Debug.WriteLine("      " + type.FullName);
                    }
                }
            }
            #endregion


            //Employee(12건), Customer(91건), Category(8건), Product(77건), Shipper(3건) 정보 조회
            string codeTypes = "Categories@Customers@Employees@Shippers";

            CommonService service = new CommonService();
            allList = service.GetCodeInfoByCodeTypes(codeTypes, "@");

            InitControls();
        }

        private void InitControls()
        {
            //납기예정일은 7일후로 기본 셋팅
            dtpRequiredDate.Value = DateTime.Now.AddDays(7);

            //Grid
            CommonUtil.InitSettingDridView(dgvCart);

            CommonUtil.AddNewColumnToDataGridView(dgvCart, "카테고리", "CategoryName", true, 100);
            CommonUtil.AddNewColumnToDataGridView(dgvCart, "제품ID", "ProductID", false, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvCart, "제품명", "ProductName", true, 300);
            CommonUtil.AddNewColumnToDataGridView(dgvCart, "제품단가", "UnitPrice", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvCart, "주문수량", "Quantity", true, 80);

            CommonUtil.InitSettingDridView(dgvOrder);

            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "주문ID", "OrderID", true, 70);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "거래처명", "CompanyName", true, 130);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "직원명", "EmployeeName", true, 100);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "주문일", "OrderDate", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "요청일", "RequiredDate", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "배송일", "ShippedDate", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "배송회사", "ShipCompanyName", true, 120);
            CommonUtil.AddNewColumnToDataGridView(dgvOrder, "배송료", "Freight", true, 80);

            CommonUtil.InitSettingDridView(dgvOrderDetail);

            CommonUtil.AddNewColumnToDataGridView(dgvOrderDetail, "카테고리", "CategoryName", true, 100);
            CommonUtil.AddNewColumnToDataGridView(dgvOrderDetail, "제품명", "ProductName", true, 300);
            CommonUtil.AddNewColumnToDataGridView(dgvOrderDetail, "제품단가", "UnitPrice", true, 80);
            CommonUtil.AddNewColumnToDataGridView(dgvOrderDetail, "주문수량", "Quantity", true, 80);


            //ComboBox
            List<ComboItemVO> CategoriesList = (from item in allList
                                                where item.CodeType == "Categories"
                                                select item).ToList();
            CommonUtil.ComboBinding(cboCategories, CategoriesList, "");


            List<ComboItemVO> CustomersList = (from item in allList
                                               where item.CodeType == "Customers"
                                               select item).ToList();
            CommonUtil.ComboBinding(cboCustomers, CustomersList);
            CommonUtil.ComboBinding(cboCustomers2, CustomersList, "선택");


            List<ComboItemVO> EmployeesList = (from item in allList
                                               where item.CodeType == "Employees"
                                               select item).ToList();
            CommonUtil.ComboBinding(cboEmployees, EmployeesList);
            CommonUtil.ComboBinding(cboEmployees2, EmployeesList, "선택");


            List<ComboItemVO> ShippersList = (from item in allList
                                              where item.CodeType == "Shippers"
                                              select item).ToList();
            CommonUtil.ComboBinding(cboShippers, ShippersList, "선택");
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategories.SelectedIndex > 0 && cboCategories.SelectedValue != null)
            {
                string cateCode = cboCategories.SelectedValue.ToString();

                //List<ComboItemVO> ProductsList = (from item in allList
                //                where item.CodeType == "Products" && item.PCode.Contains(cateCode)
                //                select item).ToList();

                OrderService service = new OrderService();
                productAllList = service.GetProductsInfoByCategoryID(cateCode);

                CommonUtil.ComboBinding(cboProducts, productAllList, "ProductID", "ProductName", "선택");
            }
            else
            {
                CommonUtil.ComboBinding(cboProducts, null, "선택");
            }
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducts.SelectedIndex > 0 && cboProducts.SelectedValue != null)
            {
                int prodID = Convert.ToInt32(cboProducts.SelectedValue);
                List<ProductInfoVO> productInfoList = (from product in productAllList
                                                       where product.ProductID == prodID
                                                       select product).ToList();

                if (productInfoList.Count > 0)
                {
                    txtUnitPrice.Text = productInfoList[0].UnitPrice.ToString();
                    numQuantity.Value = productInfoList[0].UnitsOnOrder;
                }
            }
            else
            {
                txtUnitPrice.Text = string.Empty;
                numQuantity.Value = 0;
            }
        }

        private void btnCartAdd_Click(object sender, EventArgs e)
        {
            if (cboCategories.SelectedIndex < 1 || cboProducts.SelectedIndex < 1 || numQuantity.Value < 1)
            {
                MessageBox.Show("장바구니에 추가할 제품을 선택하여 주십시오.");
                return;
            }

            if (orderDetailsList == null)
                orderDetailsList = new List<OrderDetailVO>();

            int index = orderDetailsList.FindIndex(p => p.ProductID == Convert.ToInt32(cboProducts.SelectedValue));
            if (index >= 0)
            {
                orderDetailsList[index].Quantity += Convert.ToInt32(numQuantity.Value);
            }
            else
            {
                OrderDetailVO newItem = new OrderDetailVO();
                newItem.CategoryName = cboCategories.Text;
                newItem.ProductID = Convert.ToInt32(cboProducts.SelectedValue);
                newItem.ProductName = cboProducts.Text;
                newItem.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                newItem.Quantity = Convert.ToInt32(numQuantity.Value);
                newItem.Discount = 0;

                orderDetailsList.Add(newItem);
            }

            dgvCart.DataSource = null;
            dgvCart.DataSource = orderDetailsList;

            cboCategories.SelectedIndex = 0;
        }

        private void btnCartDel_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 제품을 선택하여 주십시오.");
                return;
            }

            int delProductID = Convert.ToInt32(dgvCart.SelectedRows[0].Cells[1].Value);
            int index = orderDetailsList.FindIndex(p => p.ProductID == delProductID);
            if (index >= 0)
            {
                orderDetailsList.RemoveAt(index);

                dgvCart.DataSource = null;
                dgvCart.DataSource = orderDetailsList;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count < 1)
            {
                MessageBox.Show("주문할 제품을 선택하여 주십시오.");
                return;
            }

            try
            {
                OrderInfoVO order = new OrderInfoVO();
                order.CustomerID = ((ComboItemVO)cboCustomers.SelectedItem).Code;
                order.EmployeeID = Convert.ToInt32(((ComboItemVO)cboEmployees.SelectedItem).Code);
                order.RequiredDate = dtpRequiredDate.Value.ToShortDateString();

                OrderService service = new OrderService();
                bool bResult = service.RegisterOrder(order, orderDetailsList);
                if (bResult)
                {
                    MessageBox.Show("주문이 완료 되었습니다");
                }
                else
                {
                    MessageBox.Show("주문 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selEmployeeID = (cboEmployees2.SelectedIndex > 0) ? Convert.ToInt32(cboEmployees2.SelectedValue) : 0;
            string selCustomerID = (cboCustomers2.SelectedIndex > 0) ? cboCustomers2.SelectedValue.ToString() : string.Empty;
            string dtFrom = dtpFrom.Value.ToShortDateString();
            string dtTo = dtpTo.Value.ToShortDateString();

            OrderService service = new OrderService();
            orderSearchList = service.GetOrderSearchList(selEmployeeID, selCustomerID, dtFrom, dtTo);
            dgvOrder.DataSource = orderSearchList;

            // 초기화
            lblOrderID.Text = lblEmployeeName.Text = lblCompanyName.Text = lblOrderedDate.Text = lblRequiredDate.Text = txtFreight.Text = "";
            cboShippers.SelectedIndex = 0;
            dtpShippedDate.Value = DateTime.Now;
            dgvOrderDetail.DataSource = null;
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.SelectedRows.Count < 1)
            {
                return;
            }

            int orderID = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells[0].Value);
            OrderInfoVO selOrder = orderSearchList.Find(p => p.OrderID == orderID);
            if (selOrder != null)
            {
                lblOrderID.Text = selOrder.OrderID.ToString();
                lblEmployeeName.Text = selOrder.EmployeeName;
                lblCompanyName.Text = selOrder.CompanyName;
                lblOrderedDate.Text = selOrder.OrderDate;
                lblRequiredDate.Text = selOrder.RequiredDate;
                if (selOrder.ShipVia != null)
                    cboShippers.SelectedValue = selOrder.ShipVia.ToString();
                else
                    cboShippers.SelectedIndex = 0;
                dtpShippedDate.Value = string.IsNullOrEmpty(selOrder.ShippedDate) ? DateTime.Now : Convert.ToDateTime(selOrder.ShippedDate);
                txtFreight.Text = (selOrder.Freight != null) ? selOrder.Freight.ToString() : "";

                OrderService service = new OrderService();
                List<OrderDetailVO> orderDetailList = service.GetOrderDetailSearchList(selOrder.OrderID);
                dgvOrderDetail.DataSource = orderDetailList;
                dgvOrderDetail.ClearSelection();

                // if ((dtpShippedDate.Value < DateTime.Now.Date) && selOrder.Freight > 0)
                if (dtpShippedDate.Value < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && selOrder.Freight > 0)
                {
                    btnDel.Enabled = false;
                    btnShip.Enabled = false;
                }
                else
                {
                    btnDel.Enabled = true;
                    btnShip.Enabled = true;
                }
            }
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            dgvOrderDetail.ClearSelection();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            if (cboShippers.SelectedIndex < 1 || txtFreight.Text.Trim().Length < 1)
            {
                MessageBox.Show("배송정보를 입력하여 주십시오.");
                return;
            }

            int orderID = Convert.ToInt32(lblOrderID.Text);
            int shipperID = (cboShippers.SelectedIndex > 0) ? Convert.ToInt32(cboShippers.SelectedValue) : 0;
            string dtShippedDate = dtpShippedDate.Value.ToShortDateString();
            decimal freightFee = Convert.ToDecimal(txtFreight.Text.Trim());

            OrderService service = new OrderService();
            bool bResult = service.UpdateOrderInfo(orderID, shipperID, dtShippedDate, freightFee);
            if (bResult)
            {
                MessageBox.Show("배송처리가 완료 되었습니다");
                btnSearch.PerformClick();
                dgvOrder.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("배송처리 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("주문정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int orderID = Convert.ToInt32(lblOrderID.Text);

                OrderService service = new OrderService();
                bool bResult = service.DeleteOrderInfo(orderID);
                if (bResult)
                {
                    MessageBox.Show("주문정보 삭제가 완료 되었습니다");
                    btnSearch.PerformClick();
                }
                else
                {
                    MessageBox.Show("주문정보 삭제처리 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (frmWaitForm frm = new frmWaitForm(ExportOrderList))
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this); // 폼의 가운데 뜨게함
            }
        }

        private void ExportOrderList()
        {
            string strResult = ExcelExportImport.ExportToDataGridView<OrderInfoVO>((List<OrderInfoVO>)dgvOrder.DataSource, "EmployeeID@ShipVia@CustomerID");
            if (strResult.Length > 0)
            {
                MessageBox.Show(strResult);
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
