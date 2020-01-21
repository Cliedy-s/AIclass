using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0106GudiShop.Models
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
    }

    public class Cart
    {
        private List<CartLine> lines = new List<CartLine>();
        public List<CartLine> Lines { get { return lines; } }
        public void AddItem(Product product, int qty)
        {
            //신규로 추가되는 제품인지, 기존에 추가된 제품인지 확인
            CartLine line = lines.Where(p => p.Product.ProductID == product.ProductID).FirstOrDefault();
            if (line == null)
            {
                lines.Add(new CartLine
                {
                    Product = product,
                    Qty = qty
                });
            }
            else
            {
                line.Qty += qty; 
            }
        }
        public void RemoveItem(Product product)
        {
            lines.RemoveAll(item => item.Product.ProductID == product.ProductID);
        }
        public decimal ComputeTotalValue()
        {
            return lines.Sum(x => x.Product.Price * x.Qty);
        }

        internal void Clear()
        {
            lines.Clear();
        }
    }
}