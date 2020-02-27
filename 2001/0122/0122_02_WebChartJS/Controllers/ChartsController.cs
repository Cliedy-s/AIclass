using _0122_02_WebChartJS.DAC;
using _0122_02_WebChartJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _0122_02_WebChartJS.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult Index()
        {
            OrderDAC dac = new OrderDAC();
            List<OrderStatsVO> list = dac.GetOrderBestProduct();

            var liststat = from stat in list
                           orderby stat.MM
                           group stat by stat.ProductName;
            List<string> keys = new List<string>();
            StringBuilder sb = new StringBuilder();
            string data1, data2, data3;
            data1= data2 = data3 = string.Empty;
            int k = 0;
            foreach (var group in liststat)
            {
                keys.Add(group.Key);
                List<int> qtys = new List<int>();
                foreach (var item in group)
                {
                    if (k == 0)
                        sb.Append(item.MM + "월, ");
                    qtys.Add(item.qty);
                }
                if (k == 0)
                    data1 = "[" + string.Join(",", qtys.ToArray()) + "]";
                else if(k==1)
                    data2 = "[" + string.Join(",", qtys.ToArray()) + "]";
                else if (k == 2)
                    data3 = "[" + string.Join(",", qtys.ToArray()) + "]";

                k++;
                qtys.Clear();
            }
            string labels = sb.ToString().TrimEnd(',');
            string label1, label2, label3;
            label1 = keys[0];
            label2 = keys[1];
            label3 = keys[2];

            ViewBag.Label = labels;
            ViewBag.label1= label1;
            ViewBag.data1 = data1;
            ViewBag.label2 = label2;
            ViewBag.data2 = data2;
            ViewBag.label3 = label3;
            ViewBag.data3 = data3;
            return View();
        }
    }
}