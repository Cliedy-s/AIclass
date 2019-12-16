﻿namespace IceCreamManager
{
    partial class AdminMain
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
            this.bOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM메인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM등록ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.소요량예측ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매예측ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자재목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.발주ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOMToolStripMenuItem,
            this.자재목록ToolStripMenuItem,
            this.상품목록ToolStripMenuItem,
            this.매출조회ToolStripMenuItem,
            this.발주ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.MenuStrip1_ItemAdded);
            // 
            // bOMToolStripMenuItem
            // 
            this.bOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOM메인ToolStripMenuItem,
            this.bOM등록ToolStripMenuItem1,
            this.소요량예측ToolStripMenuItem,
            this.판매예측ToolStripMenuItem});
            this.bOMToolStripMenuItem.Name = "bOMToolStripMenuItem";
            this.bOMToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bOMToolStripMenuItem.Text = "BOM";
            // 
            // bOM메인ToolStripMenuItem
            // 
            this.bOM메인ToolStripMenuItem.Name = "bOM메인ToolStripMenuItem";
            this.bOM메인ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bOM메인ToolStripMenuItem.Text = "BOM메인";
            this.bOM메인ToolStripMenuItem.Click += new System.EventHandler(this.BOM메인ToolStripMenuItem_Click);
            // 
            // bOM등록ToolStripMenuItem1
            // 
            this.bOM등록ToolStripMenuItem1.Name = "bOM등록ToolStripMenuItem1";
            this.bOM등록ToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.bOM등록ToolStripMenuItem1.Text = "BOM등록";
            this.bOM등록ToolStripMenuItem1.Click += new System.EventHandler(this.BOM등록ToolStripMenuItem1);
            // 
            // 소요량예측ToolStripMenuItem
            // 
            this.소요량예측ToolStripMenuItem.Name = "소요량예측ToolStripMenuItem";
            this.소요량예측ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.소요량예측ToolStripMenuItem.Text = "소요량예측";
            this.소요량예측ToolStripMenuItem.Click += new System.EventHandler(this.소요량예측ToolStripMenuItem_Click);
            // 
            // 판매예측ToolStripMenuItem
            // 
            this.판매예측ToolStripMenuItem.Name = "판매예측ToolStripMenuItem";
            this.판매예측ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.판매예측ToolStripMenuItem.Text = "판매예측";
            this.판매예측ToolStripMenuItem.Click += new System.EventHandler(this.판매예측ToolStripMenuItem_Click);
            // 
            // 자재목록ToolStripMenuItem
            // 
            this.자재목록ToolStripMenuItem.Name = "자재목록ToolStripMenuItem";
            this.자재목록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.자재목록ToolStripMenuItem.Text = "자재목록";
            this.자재목록ToolStripMenuItem.Click += new System.EventHandler(this.자재목록ToolStripMenuItem_Click);
            // 
            // 상품목록ToolStripMenuItem
            // 
            this.상품목록ToolStripMenuItem.Name = "상품목록ToolStripMenuItem";
            this.상품목록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.상품목록ToolStripMenuItem.Text = "상품목록";
            this.상품목록ToolStripMenuItem.Click += new System.EventHandler(this.상품목록ToolStripMenuItem_Click);
            // 
            // 매출조회ToolStripMenuItem
            // 
            this.매출조회ToolStripMenuItem.Name = "매출조회ToolStripMenuItem";
            this.매출조회ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.매출조회ToolStripMenuItem.Text = "매출조회";
            this.매출조회ToolStripMenuItem.Click += new System.EventHandler(this.매출조회ToolStripMenuItem_Click);
            // 
            // 발주ToolStripMenuItem
            // 
            this.발주ToolStripMenuItem.Name = "발주ToolStripMenuItem";
            this.발주ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.발주ToolStripMenuItem.Text = "발주";
            this.발주ToolStripMenuItem.Click += new System.EventHandler(this.발주ToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1150, 766);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM메인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM등록ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 소요량예측ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매예측ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자재목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 발주ToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}