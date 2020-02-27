using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log4NetClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.Log.WriteDebug("InitializeComponent 호출전");
            InitializeComponent();
            Program.Log.WriteInfo("InitializeComponent 호출후");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            int[] arr = { 1, 2, 3 };
            int k = arr[0] + arr[3];
            //}
            //catch (Exception err)
            //{
            //    Program.Log.WriteError(err.Message, err);
            //}
        }
    }
}
