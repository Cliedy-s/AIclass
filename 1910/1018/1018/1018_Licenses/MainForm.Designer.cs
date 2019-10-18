namespace _1018_Licenses
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라이센스관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라이센스신청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리ToolStripMenuItem,
            this.라이센스관리ToolStripMenuItem,
            this.라이센스신청ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.회원관리ToolStripMenuItem.Text = "회원관리";
            this.회원관리ToolStripMenuItem.Click += new System.EventHandler(this.회원관리ToolStripMenuItem_Click);
            // 
            // 라이센스관리ToolStripMenuItem
            // 
            this.라이센스관리ToolStripMenuItem.Name = "라이센스관리ToolStripMenuItem";
            this.라이센스관리ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.라이센스관리ToolStripMenuItem.Text = "라이센스관리";
            this.라이센스관리ToolStripMenuItem.Click += new System.EventHandler(this.라이센스관리ToolStripMenuItem_Click);
            // 
            // 라이센스신청ToolStripMenuItem
            // 
            this.라이센스신청ToolStripMenuItem.Name = "라이센스신청ToolStripMenuItem";
            this.라이센스신청ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.라이센스신청ToolStripMenuItem.Text = "라이센스신청";
            this.라이센스신청ToolStripMenuItem.Click += new System.EventHandler(this.라이센스신청ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라이센스관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라이센스신청ToolStripMenuItem;
    }
}

