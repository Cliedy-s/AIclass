using RecursiveForChangeControls_MachineProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    // 예상되는 작업시간도 계산해서 table에 넣었으면함
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {

            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);
        }


    }
}
