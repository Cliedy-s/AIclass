namespace MachineProject
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scBase = new System.Windows.Forms.SplitContainer();
            this.flpBase = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBase)).BeginInit();
            this.scBase.Panel1.SuspendLayout();
            this.scBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machinesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // scBase
            // 
            this.scBase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBase.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scBase.Location = new System.Drawing.Point(0, 24);
            this.scBase.Name = "scBase";
            // 
            // scBase.Panel1
            // 
            this.scBase.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.scBase.Panel1.Controls.Add(this.flpBase);
            // 
            // scBase.Panel2
            // 
            this.scBase.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.scBase.Size = new System.Drawing.Size(566, 426);
            this.scBase.SplitterDistance = 329;
            this.scBase.TabIndex = 2;
            // 
            // flpBase
            // 
            this.flpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBase.Location = new System.Drawing.Point(0, 0);
            this.flpBase.Name = "flpBase";
            this.flpBase.Size = new System.Drawing.Size(329, 426);
            this.flpBase.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.scBase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MachineProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scBase.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBase)).EndInit();
            this.scBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scBase;
        private System.Windows.Forms.FlowLayoutPanel flpBase;
    }
}

