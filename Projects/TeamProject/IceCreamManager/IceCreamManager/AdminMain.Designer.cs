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
            this.bOM조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.소요량예측ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매예측ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.발주ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOMToolStripMenuItem,
            this.거래처등록ToolStripMenuItem,
            this.상품목록ToolStripMenuItem,
            this.판매목록ToolStripMenuItem,
            this.발주ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bOMToolStripMenuItem
            // 
            this.bOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOM메인ToolStripMenuItem,
            this.bOM등록ToolStripMenuItem1,
            this.bOM조회ToolStripMenuItem,
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
            // bOM조회ToolStripMenuItem
            // 
            this.bOM조회ToolStripMenuItem.Name = "bOM조회ToolStripMenuItem";
            this.bOM조회ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bOM조회ToolStripMenuItem.Text = "BOM조회";
            this.bOM조회ToolStripMenuItem.Click += new System.EventHandler(this.BOM조회ToolStripMenuItem_Click);
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
            // 거래처등록ToolStripMenuItem
            // 
            this.거래처등록ToolStripMenuItem.Name = "거래처등록ToolStripMenuItem";
            this.거래처등록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.거래처등록ToolStripMenuItem.Text = "자재목록";
            // 
            // 상품목록ToolStripMenuItem
            // 
            this.상품목록ToolStripMenuItem.Name = "상품목록ToolStripMenuItem";
            this.상품목록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.상품목록ToolStripMenuItem.Text = "상품목록";
            // 
            // 판매목록ToolStripMenuItem
            // 
            this.판매목록ToolStripMenuItem.Name = "판매목록ToolStripMenuItem";
            this.판매목록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.판매목록ToolStripMenuItem.Text = "판매목록";
            // 
            // 발주ToolStripMenuItem
            // 
            this.발주ToolStripMenuItem.Name = "발주ToolStripMenuItem";
            this.발주ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.발주ToolStripMenuItem.Text = "발주";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM메인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM등록ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bOM조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 소요량예측ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매예측ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래처등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 발주ToolStripMenuItem;
    }
}