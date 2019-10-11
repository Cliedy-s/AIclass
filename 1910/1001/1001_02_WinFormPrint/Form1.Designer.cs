namespace _1001_02_WinFormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.프린트인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.용지설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프린터선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프린트미리보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프린트인쇄ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 프린트인쇄ToolStripMenuItem
            // 
            this.프린트인쇄ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프린터선택ToolStripMenuItem,
            this.용지설정ToolStripMenuItem,
            this.프린트미리보기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.인쇄ToolStripMenuItem});
            this.프린트인쇄ToolStripMenuItem.Name = "프린트인쇄ToolStripMenuItem";
            this.프린트인쇄ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.프린트인쇄ToolStripMenuItem.Text = "프린트(인쇄)";
            // 
            // 용지설정ToolStripMenuItem
            // 
            this.용지설정ToolStripMenuItem.Name = "용지설정ToolStripMenuItem";
            this.용지설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.용지설정ToolStripMenuItem.Text = "용지 설정";
            this.용지설정ToolStripMenuItem.Click += new System.EventHandler(this.용지설정ToolStripMenuItem_Click);
            // 
            // 프린터선택ToolStripMenuItem
            // 
            this.프린터선택ToolStripMenuItem.Name = "프린터선택ToolStripMenuItem";
            this.프린터선택ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프린터선택ToolStripMenuItem.Text = "프린터 선택";
            this.프린터선택ToolStripMenuItem.Click += new System.EventHandler(this.프린터선택ToolStripMenuItem_Click);
            // 
            // 프린트미리보기ToolStripMenuItem
            // 
            this.프린트미리보기ToolStripMenuItem.Name = "프린트미리보기ToolStripMenuItem";
            this.프린트미리보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프린트미리보기ToolStripMenuItem.Text = "미리보기";
            this.프린트미리보기ToolStripMenuItem.Click += new System.EventHandler(this.프린트미리보기ToolStripMenuItem_Click);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.인쇄ToolStripMenuItem.Text = "인쇄";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Document = this.printDocument1;
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 39);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(438, 399);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.Zoom = 0.33789563729683492D;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printPreviewControl1);
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
        private System.Windows.Forms.ToolStripMenuItem 프린트인쇄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프린터선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 용지설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프린트미리보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

