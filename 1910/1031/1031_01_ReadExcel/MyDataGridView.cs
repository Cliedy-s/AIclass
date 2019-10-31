using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1031_01_ReadExcel
{
    public partial class MyDataGridView : DataGridView
    {
        public MyDataGridView()
        {
            InitializeComponent();

           this.RowsDefaultCellStyle.BackColor = Color.Bisque; // 모든 셀 백 컬러
           this.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige; // 줄무늬 백컬러
           
           this.DefaultCellStyle.SelectionBackColor = Color.Red; // 선택한 백그라운드 컬러
           this.DefaultCellStyle.SelectionForeColor = Color.Yellow; // 선택한 텍스트 컬러
           
           this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           this.CellBorderStyle = DataGridViewCellBorderStyle.None; // 셀 보더 스타일
           this.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // 줄 바꿈 여부

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
