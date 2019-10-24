using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    public partial class MachinePanel : UserControl
    {
        public MachinePanel()
        {
            InitializeComponent();
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string MachineName { get => lblMahineName.Text; set => lblMahineName.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string TotalAmount { get => lblTotalAmount_V.Text; set => lblTotalAmount_V.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string DefectAmount { get => lblDefectAmount_V.Text; set => lblDefectAmount_V.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string DefectRate { get => lblDefectRate_V.Text; set => lblDefectRate_V.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string DefectRateAlarm { get => lblDefectRateAlarm_V.Text; set => lblDefectRateAlarm_V.Text = value; }
    }
}
