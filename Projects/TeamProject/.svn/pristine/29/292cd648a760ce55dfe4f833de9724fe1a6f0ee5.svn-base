using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewSetStyles
{
    public class SetDataGridView
    {
        public void Set(DataGridView dataGridView1, Color defaultBackColor, Color alternatingBackColor, Color selectionBackColor, Color selectionForeColor, DataGridViewSelectionMode selectionMode = DataGridViewSelectionMode.FullRowSelect, DataGridViewCellBorderStyle borderStyle = DataGridViewCellBorderStyle.None, DataGridViewTriState lineBreak = DataGridViewTriState.True)
        {
            dataGridView1.RowsDefaultCellStyle.BackColor = defaultBackColor; // 모든 셀 백 컬러
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = alternatingBackColor; // 줄무늬 백컬러

            dataGridView1.DefaultCellStyle.SelectionBackColor = selectionBackColor; // 선택한 백그라운드 컬러
            dataGridView1.DefaultCellStyle.SelectionForeColor = selectionForeColor; // 선택한 텍스트 컬러

            dataGridView1.SelectionMode = selectionMode; 
            dataGridView1.CellBorderStyle = borderStyle; // 셀 보더 스타일
            dataGridView1.DefaultCellStyle.WrapMode = lineBreak; // 줄 바꿈 여부

            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.MultiSelect = false;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
