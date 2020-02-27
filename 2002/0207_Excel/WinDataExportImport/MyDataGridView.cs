using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataExportImport
{
    public partial class MyDataGridView : DataGridView
    {
        public MyDataGridView()
        {
            InitializeComponent();

            //this.RowsDefaultCellStyle.BackColor = Color.Bisque;
            //this.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            //this.CellBorderStyle = DataGridViewCellBorderStyle.None;

            //this.DefaultCellStyle.SelectionBackColor = Color.Red;
            //this.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            //this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AllowUserToResizeColumns = false;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
