namespace MachineProject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TodoSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpBase = new System.Windows.Forms.FlowLayoutPanel();
            this.panForDefectAlarm = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOldDefectRateAlarm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.nudNewDefectRateAlarm = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.panForWork = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.기계상태ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panForDefectAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewDefectRateAlarm)).BeginInit();
            this.panForWork.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machinesToolStripMenuItem,
            this.worksToolStripMenuItem,
            this.myInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // worksToolStripMenuItem
            // 
            this.worksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TodoSetToolStripMenuItem});
            this.worksToolStripMenuItem.Name = "worksToolStripMenuItem";
            this.worksToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.worksToolStripMenuItem.Text = "Works";
            // 
            // TodoSetToolStripMenuItem
            // 
            this.TodoSetToolStripMenuItem.Name = "TodoSetToolStripMenuItem";
            this.TodoSetToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.TodoSetToolStripMenuItem.Text = "TodoSet";
            this.TodoSetToolStripMenuItem.Click += new System.EventHandler(this.TodoSetToolStripMenuItem_Click);
            // 
            // myInfoToolStripMenuItem
            // 
            this.myInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMyInfoToolStripMenuItem});
            this.myInfoToolStripMenuItem.Name = "myInfoToolStripMenuItem";
            this.myInfoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.myInfoToolStripMenuItem.Text = "MyInfo";
            // 
            // showMyInfoToolStripMenuItem
            // 
            this.showMyInfoToolStripMenuItem.Name = "showMyInfoToolStripMenuItem";
            this.showMyInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showMyInfoToolStripMenuItem.Text = "ShowMyInfo";
            this.showMyInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowMyInfoToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.flpBase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.panForDefectAlarm);
            this.splitContainer1.Panel2.Controls.Add(this.panForWork);
            this.splitContainer1.Size = new System.Drawing.Size(825, 501);
            this.splitContainer1.SplitterDistance = 520;
            this.splitContainer1.TabIndex = 2;
            // 
            // flpBase
            // 
            this.flpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBase.Location = new System.Drawing.Point(0, 0);
            this.flpBase.Name = "flpBase";
            this.flpBase.Size = new System.Drawing.Size(520, 501);
            this.flpBase.TabIndex = 0;
            // 
            // panForDefectAlarm
            // 
            this.panForDefectAlarm.Controls.Add(this.label6);
            this.panForDefectAlarm.Controls.Add(this.label5);
            this.panForDefectAlarm.Controls.Add(this.lblOldDefectRateAlarm);
            this.panForDefectAlarm.Controls.Add(this.label3);
            this.panForDefectAlarm.Controls.Add(this.lblMachineName);
            this.panForDefectAlarm.Controls.Add(this.nudNewDefectRateAlarm);
            this.panForDefectAlarm.Controls.Add(this.btnSet);
            this.panForDefectAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForDefectAlarm.Location = new System.Drawing.Point(0, 0);
            this.panForDefectAlarm.Name = "panForDefectAlarm";
            this.panForDefectAlarm.Size = new System.Drawing.Size(301, 501);
            this.panForDefectAlarm.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "저장할 불량률 마지노선";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "%";
            // 
            // lblOldDefectRateAlarm
            // 
            this.lblOldDefectRateAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOldDefectRateAlarm.Location = new System.Drawing.Point(124, 83);
            this.lblOldDefectRateAlarm.Name = "lblOldDefectRateAlarm";
            this.lblOldDefectRateAlarm.Size = new System.Drawing.Size(51, 23);
            this.lblOldDefectRateAlarm.TabIndex = 15;
            this.lblOldDefectRateAlarm.Text = "0.00";
            this.lblOldDefectRateAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "저장된 불량률 마지노선";
            // 
            // lblMachineName
            // 
            this.lblMachineName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachineName.Location = new System.Drawing.Point(39, 25);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(135, 19);
            this.lblMachineName.TabIndex = 13;
            this.lblMachineName.Text = "MachineName";
            // 
            // nudNewDefectRateAlarm
            // 
            this.nudNewDefectRateAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudNewDefectRateAlarm.Increment = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            this.nudNewDefectRateAlarm.Location = new System.Drawing.Point(76, 170);
            this.nudNewDefectRateAlarm.Name = "nudNewDefectRateAlarm";
            this.nudNewDefectRateAlarm.Size = new System.Drawing.Size(120, 21);
            this.nudNewDefectRateAlarm.TabIndex = 12;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSet.Location = new System.Drawing.Point(183, 206);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 11;
            this.btnSet.Text = "설정";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // panForWork
            // 
            this.panForWork.Controls.Add(this.button2);
            this.panForWork.Controls.Add(this.listView1);
            this.panForWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForWork.Location = new System.Drawing.Point(0, 0);
            this.panForWork.Name = "panForWork";
            this.panForWork.Size = new System.Drawing.Size(301, 501);
            this.panForWork.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(219, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "실행";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 460);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기계상태ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // 기계상태ToolStripMenuItem
            // 
            this.기계상태ToolStripMenuItem.Name = "기계상태ToolStripMenuItem";
            this.기계상태ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.기계상태ToolStripMenuItem.Text = "기계 상태";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 525);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MachineProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panForDefectAlarm.ResumeLayout(false);
            this.panForDefectAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewDefectRateAlarm)).EndInit();
            this.panForWork.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worksToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpBase;
        private System.Windows.Forms.Panel panForDefectAlarm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOldDefectRateAlarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.NumericUpDown nudNewDefectRateAlarm;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel panForWork;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 기계상태ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TodoSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMyInfoToolStripMenuItem;
    }
}

