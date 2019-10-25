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
using RecursiveForChangeControls_MachineProject;


namespace MachineProject
{
    public partial class MainForm : Form
    {
        enum Authority { Manager, Employee }
        Authority authority = Authority.Employee;
        List<string> alamList;
        DControls dcontrols;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 로그인폼
            LoginForm login = new LoginForm();
            if(!(login.ShowDialog() == DialogResult.OK))
            {
                Environment.Exit(0);
            }
            // 매니저면은
            if (login.ID == "1") authority = Authority.Manager;
            // 권한에 따라 다른 폼을 보여주는 부분
            switch (authority)
            {
                case Authority.Manager:
                    panForDefectAlarm.Visible = true;
                    panForWork.Visible = false;
                    break;
                case Authority.Employee:
                    panForDefectAlarm.Visible = false;
                    panForWork.Visible = true;
                    break;
            }
            panForDefectAlarm.Location = panForWork.Location;

            // 알람 리스트
            alamList = new List<string>();
            flpBase.AutoScroll = true; // 스크롤 자동 생성

            // TODO - 지우기 : 메뉴를 임시로 생성함.
            for (int i = 0; i < 11; i++)
            {
                NewMachineMenu("item" + "Machine0" + i, flpBase);
            }
            NewMenuItem("itemTotalSelect", "전체선택", Total_CheckedChanged);

            // 자식까지 폰트를 바꿈..
            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);
        }


        // 메뉴 아이템 생성 모듈 => 머신 메뉴를 위함
        private void NewMachineMenu(string machineName, Control chileToContainer)
        {
            ToolStripMenuItem Machine = new ToolStripMenuItem();

            Machine.CheckState = CheckState.Unchecked;
            Machine.Name = machineName;
            Machine.Text = machineName;
            Machine.CheckOnClick = true;
            Machine.CheckedChanged += Machines_CheckedChanged;
            Machine.Tag = chileToContainer;

            machinesToolStripMenuItem.DropDownItems.Add(Machine);
        }

        // 메뉴 아이템 생성 모듈 => 일반 메뉴
        private void NewMenuItem(string menuName, string itemText, EventHandler method)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();

            item.CheckState = CheckState.Unchecked;
            item.Name = menuName;
            item.Text = itemText;
            item.CheckOnClick = true;
            item.CheckedChanged += method;

            machinesToolStripMenuItem.DropDownItems.Add(item);
        }

        // 머신 메뉴 아이템을 체크할 때
        // => 머신 불량률 패널 생성(flpBase)
        private void Machines_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Checked)
                {
                    NewMachineItem(item.Text, item.Tag as Control);
                }
                else
                {
                    (item.Tag as Control).Controls.RemoveByKey(item.Text);
                }
            }
        }

        // 전체 메뉴 체크
        private void Total_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem me = sender as ToolStripMenuItem;
                foreach (ToolStripMenuItem item in machinesToolStripMenuItem.DropDownItems)
                {
                    item.Checked = me.Checked;
                }
            }
        }
        //

        // 기계 패널 생성 유저컨트롤을 가져옴
        private void NewMachineItem(string machineName, Control container)
        {
            MachinePanel machinePanel = new MachinePanel();
            machinePanel.Name = machineName;
            machinePanel.MachineName = machineName;
            machinePanel.doubleClick += MachinePanel_doubleClick; // 더블클릭 이벤트 핸들러 => 더블클릭시 실행
            container.Controls.Add(machinePanel);
        }
        // 기계 패널을 더블클릭했을 때
        private void MachinePanel_doubleClick(object sender, MachinePanel.MachineStringsEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(e.ReturnValues.MachineName);
            sb.AppendLine(e.ReturnValues.TotalAmount);
            sb.AppendLine(e.ReturnValues.DefectAmount);
            sb.AppendLine(e.ReturnValues.DefectRate);
            sb.AppendLine(e.ReturnValues.DefectRateAlarm);
            MessageBox.Show(sb.ToString());
        }

        //


        #region Test
        // 머신 불량률 패널 생성
        //private void NewMachineItem(string machineName, Control container)
        //{
        //    string panName = "pan" + machineName;

        //    create panel
        //    container.Controls.Add(dcontrols.CreatePanel(panName));
        //    Control chileContainer = container.Controls.Find(panName, true)[0] as Control;

        //    create listBox
        //    chileContainer.Controls.Add(dcontrols.CreateListBox("lst" + machineName));

        //    create labels
        //     MachineName
        //    chileContainer.Controls.Add(dcontrols.CreateLabel("lbl" + machineName, machineName, new Point(15, 305), new Font("나눔고딕", 12, FontStyle.Bold)));
        //     전체 상품수, 불량 상품수 ...
        //    Point pointKey = new Point(17, 329);
        //    Point pointValue = new Point(137, 329);

        //    string[] keyStrs = new string[] { "전체 상품 수", "불량 상품 수", "불량률", "불량률 마지노선" };
        //    string[] valueStrs = new string[] { "전체 상품 수", "불량 상품 수", "불량률", "불량률 마지노선" };
        //    string[] valueStrs = new string[] { "0개", "0개", "0%", "0%" };
        //    for (int i = 0; i < 4; i++)
        //    {
        //        chileContainer.Controls.Add(dcontrols.CreateLabel("lblK", keyStrs[i], pointKey));
        //        chileContainer.Controls.Add(dcontrols.CreateLabel("lblV" + machineName, valueStrs[i], pointValue, default, false, new Size(105, 19), ContentAlignment.MiddleRight));
        //        if (i == 1)
        //        {
        //            pointKey.Y = pointKey.Y + 25;
        //            pointValue.Y = pointValue.Y + 25;
        //        }
        //        else
        //        {
        //            pointKey.Y = pointKey.Y + 20;
        //            pointValue.Y = pointValue.Y + 20;
        //        }
        //    }

        //}

        ////메뉴 아이템을 체크할 때 => 머신 불량률 패널 생성(flpBase)
        //private void Machines_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (sender is ToolStripMenuItem)
        //    {
        //        ToolStripMenuItem item = sender as ToolStripMenuItem;
        //        if (item.Checked)
        //        {
        //            NewMachineItem(item.Text, item.Tag as Control);
        //        }
        //    }
        //}
        #endregion

        private void TodoSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkForm frm = new WorkForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
