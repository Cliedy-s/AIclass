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
    public partial class frmWaitForm : Form
    {
        public Action Worker;
        public frmWaitForm(Action worker)
        {
            InitializeComponent();
            this.Worker = worker;
        }
        private void frmWaitForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Worker).ContinueWith((t) => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        }
    }
}
