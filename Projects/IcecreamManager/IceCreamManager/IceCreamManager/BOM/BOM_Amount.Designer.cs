﻿namespace IceCreamManager
{
    partial class BOM_Amount
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
            this.dgvAmountChild = new System.Windows.Forms.DataGridView();
            this.dgvAmountParent = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnEcxel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sfdExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.lbltotalcost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmountChild
            // 
            this.dgvAmountChild.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmountChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmountChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAmountChild.Location = new System.Drawing.Point(0, 0);
            this.dgvAmountChild.Name = "dgvAmountChild";
            this.dgvAmountChild.RowHeadersWidth = 51;
            this.dgvAmountChild.RowTemplate.Height = 23;
            this.dgvAmountChild.Size = new System.Drawing.Size(851, 350);
            this.dgvAmountChild.TabIndex = 4;
            this.dgvAmountChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAmountChild_CellClick);
            // 
            // dgvAmountParent
            // 
            this.dgvAmountParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmountParent.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmountParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmountParent.Location = new System.Drawing.Point(0, 53);
            this.dgvAmountParent.Name = "dgvAmountParent";
            this.dgvAmountParent.RowHeadersWidth = 51;
            this.dgvAmountParent.RowTemplate.Height = 23;
            this.dgvAmountParent.Size = new System.Drawing.Size(851, 191);
            this.dgvAmountParent.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbltotalcost);
            this.splitContainer1.Panel1.Controls.Add(this.dgvAmountParent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAmountChild);
            this.splitContainer1.Size = new System.Drawing.Size(851, 634);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numQuantity);
            this.panel1.Controls.Add(this.btnEcxel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 52);
            this.panel1.TabIndex = 8;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(60, 18);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(154, 21);
            this.numQuantity.TabIndex = 13;
            // 
            // btnEcxel
            // 
            this.btnEcxel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEcxel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEcxel.Location = new System.Drawing.Point(739, 10);
            this.btnEcxel.Name = "btnEcxel";
            this.btnEcxel.Size = new System.Drawing.Size(98, 35);
            this.btnEcxel.TabIndex = 12;
            this.btnEcxel.Text = "Excel 저장";
            this.btnEcxel.UseVisualStyleBackColor = false;
            this.btnEcxel.Click += new System.EventHandler(this.btnEcxel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(234, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "계산";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFind.Location = new System.Drawing.Point(584, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 35);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "제품 찾기";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "개수 :";
            // 
            // lbltotalcost
            // 
            this.lbltotalcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltotalcost.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltotalcost.ForeColor = System.Drawing.Color.White;
            this.lbltotalcost.Location = new System.Drawing.Point(3, 243);
            this.lbltotalcost.Name = "lbltotalcost";
            this.lbltotalcost.Size = new System.Drawing.Size(848, 42);
            this.lbltotalcost.TabIndex = 7;
            this.lbltotalcost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BOM_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(851, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(549, 338);
            this.Name = "BOM_Amount";
            this.Text = "소요량 예측";
            this.Load += new System.EventHandler(this.BOM_Amount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountParent)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAmountChild;
        private System.Windows.Forms.DataGridView dgvAmountParent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEcxel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sfdExcelExport;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lbltotalcost;
        private System.Windows.Forms.Button button1;
    }
}