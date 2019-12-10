using IceCreamManager.Service;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IceCreamManager
{
    public partial class BOM_Main : Form
    {
        List<MaterialsVO> allList;
        List<BOMVO> bomList;

        public BOM_Main()
        {
            InitializeComponent();
        }

        private void TbcMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tbcMain.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tbcMain.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("맑은 고딕", 17.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void BOM_Main_Load(object sender, EventArgs e)
        {
            InitCotrols();
            MaterialsService service = new MaterialsService();
            allList = service.SelectAll();
            dgvMain.DataSource = allList;
        }

        private void InitCotrols()
        {
            DatagridviewDeigns.SetDesign(dgvMain);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvMain, "자재번호", "mat_No", true, 100);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvMain, "자재명", "mat_Name", true, 210);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvMain, "자재단계", "mtt_Name", true, 80);
            DatagridviewDeigns.AddNewColumnToDataGridView(dgvMain, "자재량", "mat_Each", true, 100);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "관리";
            btn.Text = "조회";
            btn.Name = "btnSearch";
            btn.Width = 100;
            btn.UseColumnTextForButtonValue = true;
            dgvMain.Columns.Add(btn);
        }

        private void TbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cho = tbcMain.SelectedIndex;

            switch (cho)
            {
                case 0:
                    dgvMain.DataSource = allList;
                    break;
                case 1:
                    List<MaterialsVO> wanjeList = (from item in allList
                                                   where item.mtt_No == 1
                                                   select item).ToList();
                    dgvMain.DataSource = wanjeList;
                    break;
                case 2:
                    List<MaterialsVO> banjeList = (from item in allList
                                                   where item.mtt_No == 2
                                                   select item).ToList();
                    dgvMain.DataSource = banjeList;
                    break;
                case 3:
                    List<MaterialsVO> materialList = (from item in allList
                                                      where item.mtt_No == 3
                                                      select item).ToList();
                    dgvMain.DataSource = materialList;
                    break;
            }
        }
    }
}