using _1125_ListLinqSample;
using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSampleUI
{
    public class OrderService
    {
        public List<ProductInfoVO> GetProductsInfoByCategoryID(string categoryID)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetProductsInfoByCategoryID(categoryID);
        }

        public bool RegisterOrder(OrderInfoVO order, List<OrderDetailVO> details)
        {
            OrderDAC dac = new OrderDAC();
            return dac.RegisterOrder(order, details);
        }

        public List<OrderInfoVO> GetOrderSearchList(int selEmployeeID, string selCustomerID, string dtFrom, string dtTo)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetOrderSearchList(selEmployeeID, selCustomerID, dtFrom, dtTo);
        }

        public List<OrderDetailVO> GetOrderDetailSearchList(int orderID)
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetOrderDetailSearchList(orderID);
        }

        public bool UpdateOrderInfo(int orderID, int shipperID, string shippedDate, decimal freightFee)
        {
            OrderDAC dac = new OrderDAC();
            return dac.UpdateOrderInfo(orderID, shipperID, shippedDate, freightFee);
        }

        public bool DeleteOrderInfo(int orderID)
        {
            OrderDAC dac = new OrderDAC();
            return dac.DeleteOrderInfo(orderID);
        }
    }
}
