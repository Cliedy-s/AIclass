﻿using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IceCreamManager
{
    public partial class BOM_Forecast : Form
    {
        List<ProductVO> productList = new List<ProductVO>();
        public BOM_Forecast()
        {
            InitializeComponent();
        }

        private void BOM_Forecast_Load(object sender, System.EventArgs e)
        {
            yearChartBinding();
            productChartBinding();
        }
        private void productChartBinding()
        {
            productChart.Series.Clear();
            ProductService service = new ProductService();
            productList = service.GetAllProductData();

            Random rnd = new Random();
            double[] psale = new double[productList.Count];

            for (int i = 0; i < productList.Count; i++)
            {
                psale.SetValue(Convert.ToDouble(rnd.Next(1, 100)), i);
            }

            productChart.Series.Add("제품별 판매량");
            productChart.Series["제품별 판매량"].ChartType = SeriesChartType.Pie;
            productChart.Series["제품별 판매량"].IsValueShownAsLabel = true;
            foreach (var item in psale)
            {
                productChart.Series["제품별 판매량"].Points.Add(item);
            }
            for (int i = 0; i < productList.Count; i++)
            {
                productChart.Series["제품별 판매량"].Points[i].LegendText = productList[i].pro_Name;
            }

            productChart.Legends[0].Docking = Docking.Top;
        }

        private void yearChartBinding()
        {
            string[] mount = { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" };
            Series yChart = new Series("판매량");

            yearChart.Series.Clear();
            yearChart.Series.Add(yChart);

            yearChart.Series["판매량"].Points.AddXY("1월", 40);
            yearChart.Series["판매량"].Points.AddXY("2월", 60);
            yearChart.Series["판매량"].Points.AddXY("3월", 30);
            yearChart.Series["판매량"].Points.AddXY("4월", 40);
            yearChart.Series["판매량"].Points.AddXY("5월", 50);
            yearChart.Series["판매량"].Points.AddXY("6월", 75);
            yearChart.Series["판매량"].Points.AddXY("7월", 90);
            yearChart.Series["판매량"].Points.AddXY("8월", 100);
            yearChart.Series["판매량"].Points.AddXY("9월", 85);
            yearChart.Series["판매량"].Points.AddXY("10월", 60);
            yearChart.Series["판매량"].Points.AddXY("11월", 50);
            yearChart.Series["판매량"].Points.AddXY("12월", 65);

            yearChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;// 그래프선 보이기 안보이기
            yearChart.ChartAreas[0].AxisX.Minimum = 0;
            yearChart.ChartAreas[0].AxisX.Maximum = 13;
            yearChart.ChartAreas[0].AxisX.Interval = 1;
            yearChart.ChartAreas[0].AxisY.Maximum = 100;

            yearChart.Legends[0].Docking = Docking.Top;
        }
    }
}
