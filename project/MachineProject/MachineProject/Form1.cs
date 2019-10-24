using DinamicControlCreate;
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
    public partial class Form1 : Form
    {
        List<string> alamList;
        DControls dcontrols;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dcontrols = new DControls();
            alamList = new List<string>();
            flpBase.AutoScroll = true;

            for (int i = 0; i < 11; i++)
            {
                NewMachineMenu("Machine0"+i, flpBase);
            }

            this.ClientSize = new Size(ClientSize.Width + 262, 489);

            foreach (Control item in this.Controls)
            {
                item.Font = new Font("나눔고딕", 9.75f, FontStyle.Regular);
            }
        }
        // 메뉴 아이템 생성
        private void NewMachineMenu(string machineName, Control toContainer)
        {
            ToolStripMenuItem Machine = new ToolStripMenuItem();

            Machine.Checked = true;
            Machine.CheckState = CheckState.Unchecked;
            Machine.Name = machineName;
            Machine.Size = new Size(180, 22);
            Machine.Text = machineName;
            Machine.CheckOnClick = true;
            Machine.CheckedChanged += Machines_CheckedChanged;
            Machine.Tag = toContainer;

            machinesToolStripMenuItem.DropDownItems.Add(Machine);
        }
        // 머신 불량률 패널 생성
        private void NewMachineItem(string machineName, Control container)
        {
            string panName = "pan" + machineName;

            //create panel
            container.Controls.Add(dcontrols.CreatePanel(panName));
            Control chileContainer = container.Controls.Find(panName, true)[0] as Control;

            //create listBox
            chileContainer.Controls.Add(dcontrols.CreateListBox("lst"+machineName));

            //create labels
            // MachineName
            chileContainer.Controls.Add(dcontrols.CreateLabel("lbl"+machineName, machineName, new Point(15, 305), new Font("나눔고딕", 12, FontStyle.Bold)));
            // 전체 상품수, 불량 상품수 ...
            Point pointKey = new Point(17, 329);
            Point pointValue = new Point(137, 329);

            string[] keyStrs = new string[] { "전체 상품 수", "불량 상품 수", "불량률", "불량률 마지노선"};
            //string[] valueStrs = new string[] { "전체 상품 수", "불량 상품 수", "불량률", "불량률 마지노선" };
            string[] valueStrs = new string[] { "0개", "0개", "0%", "0%" };
            for (int i = 0; i < 4; i++)
            {
                chileContainer.Controls.Add(dcontrols.CreateLabel("lblK", keyStrs[i], pointKey));
                chileContainer.Controls.Add(dcontrols.CreateLabel("lblV" + machineName, valueStrs[i], pointValue, default, false, new Size(105, 19), ContentAlignment.MiddleRight));
                if(i == 1)
                {
                    pointKey.Y = pointKey.Y + 25;
                    pointValue.Y = pointValue.Y + 25;
                } else
                {
                    pointKey.Y = pointKey.Y + 20;
                    pointValue.Y = pointValue.Y + 20;
                }
            }
            //
        }
        // 메뉴 아이템을 체크할 때 => 머신 불량률 패널 생성 (flpBase)
        private void Machines_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Checked)
                {
                    NewMachineItem(item.Text, item.Tag as Control);
                }
            }
        }
    }
}
