﻿namespace IceCreamManager.BOM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAmountChild = new System.Windows.Forms.DataGridView();
            this.btnEcxel = new System.Windows.Forms.Button();
            this.dgvAmountParent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountParent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "개수 :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(97, 25);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(178, 25);
            this.txtProductName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(97, 59);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(178, 25);
            this.txtQuantity.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFind.Location = new System.Drawing.Point(296, 25);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 29);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "제품 찾기";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(296, 61);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "계산";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvAmountChild
            // 
            this.dgvAmountChild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmountChild.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmountChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmountChild.Location = new System.Drawing.Point(37, 266);
            this.dgvAmountChild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAmountChild.Name = "dgvAmountChild";
            this.dgvAmountChild.RowHeadersWidth = 51;
            this.dgvAmountChild.RowTemplate.Height = 23;
            this.dgvAmountChild.Size = new System.Drawing.Size(771, 222);
            this.dgvAmountChild.TabIndex = 4;
            // 
            // btnEcxel
            // 
            this.btnEcxel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEcxel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEcxel.Location = new System.Drawing.Point(696, 41);
            this.btnEcxel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEcxel.Name = "btnEcxel";
            this.btnEcxel.Size = new System.Drawing.Size(112, 44);
            this.btnEcxel.TabIndex = 5;
            this.btnEcxel.Text = "Excel 저장";
            this.btnEcxel.UseVisualStyleBackColor = false;
            // 
            // dgvAmountParent
            // 
            this.dgvAmountParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmountParent.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmountParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmountParent.Location = new System.Drawing.Point(37, 112);
            this.dgvAmountParent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAmountParent.Name = "dgvAmountParent";
            this.dgvAmountParent.RowHeadersWidth = 51;
            this.dgvAmountParent.RowTemplate.Height = 23;
            this.dgvAmountParent.Size = new System.Drawing.Size(771, 122);
            this.dgvAmountParent.TabIndex = 6;
            // 
            // BOM_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(853, 520);
            this.Controls.Add(this.dgvAmountParent);
            this.Controls.Add(this.btnEcxel);
            this.Controls.Add(this.dgvAmountChild);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BOM_Amount";
            this.Text = "소요량 예측";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAmountChild;
        private System.Windows.Forms.Button btnEcxel;
        private System.Windows.Forms.DataGridView dgvAmountParent;
    }
}