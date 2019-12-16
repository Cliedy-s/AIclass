﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IceCreamManager.VO;
using IceCreamManager.Service;

namespace IceCreamManager
{
    public partial class Orderdocument_Form : Form
    {
        public Orderdocument_Form()
        {
            InitializeComponent();
        }

        private void Orderdocument_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void DataLoad()
        {
            OrderService service = new OrderService();
            List<OrderVO> Orderlist;
            List<OrderVO> Filterlist = new List<OrderVO>(); //입고되지않은 자제들만

            (Orderlist, _) = service.SelectAll();

            Filterlist = new List<OrderVO>(); //입고가되지않은 제품들만
            Filterlist = Orderlist.FindAll(item => item.cmt_No == 4);

        

        }
    }
}
