namespace _0930_03_ToolBar
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계단식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바둑판식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이콘정렬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.회원ToolStripMenuItem,
            this.창ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "닫기";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 회원ToolStripMenuItem
            // 
            this.회원ToolStripMenuItem.Name = "회원ToolStripMenuItem";
            this.회원ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.회원ToolStripMenuItem.Text = "회원";
            this.회원ToolStripMenuItem.Click += new System.EventHandler(this.회원ToolStripMenuItem_Click);
            // 
            // 창ToolStripMenuItem
            // 
            this.창ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계단식ToolStripMenuItem,
            this.바둑판식ToolStripMenuItem,
            this.아이콘정렬ToolStripMenuItem});
            this.창ToolStripMenuItem.Name = "창ToolStripMenuItem";
            this.창ToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.창ToolStripMenuItem.Text = "창";
            // 
            // 계단식ToolStripMenuItem
            // 
            this.계단식ToolStripMenuItem.Name = "계단식ToolStripMenuItem";
            this.계단식ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.계단식ToolStripMenuItem.Text = "계단식";
            this.계단식ToolStripMenuItem.Click += new System.EventHandler(this.계단식ToolStripMenuItem_Click);
            // 
            // 바둑판식ToolStripMenuItem
            // 
            this.바둑판식ToolStripMenuItem.Name = "바둑판식ToolStripMenuItem";
            this.바둑판식ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.바둑판식ToolStripMenuItem.Text = "바둑판식";
            this.바둑판식ToolStripMenuItem.Click += new System.EventHandler(this.바둑판식ToolStripMenuItem_Click);
            // 
            // 아이콘정렬ToolStripMenuItem
            // 
            this.아이콘정렬ToolStripMenuItem.Name = "아이콘정렬ToolStripMenuItem";
            this.아이콘정렬ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.아이콘정렬ToolStripMenuItem.Text = "아이콘 정렬";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(90, 107);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계단식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑판식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아이콘정렬ToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}