using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinDataExportImport
{
    class Class1
    {
        public static void SetDataGridView(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.Bisque;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;

            grid.DefaultCellStyle.SelectionBackColor = Color.Red;
            grid.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToResizeColumns = false;
        }
    }
}
