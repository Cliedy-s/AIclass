﻿namespace IceCreamManager
{
    partial class Offerer_Form
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
            this.dgvOfferer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.cbbOffererName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbProductType = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProducName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProductMoney = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOfferer
            // 
            this.dgvOfferer.BackgroundColor = System.Drawing.Color.White;
            this.dgvOfferer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfferer.Location = new System.Drawing.Point(14, 44);
            this.dgvOfferer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOfferer.Name = "dgvOfferer";
            this.dgvOfferer.RowHeadersWidth = 51;
            this.dgvOfferer.RowTemplate.Height = 23;
            this.dgvOfferer.Size = new System.Drawing.Size(336, 668);
            this.dgvOfferer.TabIndex = 0;
            this.dgvOfferer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfferer_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "제조사";
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(357, 44);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 23;
            this.dgvProduct.Size = new System.Drawing.Size(352, 395);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "제조사 재품";
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProduct.Location = new System.Drawing.Point(616, 672);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(86, 29);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "제품등록";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // cbbOffererName
            // 
            this.cbbOffererName.FormattingEnabled = true;
            this.cbbOffererName.Location = new System.Drawing.Point(456, 474);
            this.cbbOffererName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbOffererName.Name = "cbbOffererName";
            this.cbbOffererName.Size = new System.Drawing.Size(138, 23);
            this.cbbOffererName.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(653, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(369, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "갯수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(366, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "자재이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(366, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "거래처명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(369, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "자재타입";
            // 
            // cbbProductType
            // 
            this.cbbProductType.FormattingEnabled = true;
            this.cbbProductType.Location = new System.Drawing.Point(456, 591);
            this.cbbProductType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbProductType.Name = "cbbProductType";
            this.cbbProductType.Size = new System.Drawing.Size(138, 23);
            this.cbbProductType.TabIndex = 45;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(693, 455);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(15, 15);
            this.lblCode.TabIndex = 47;
            this.lblCode.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblProducName);
            this.panel2.Location = new System.Drawing.Point(456, 506);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 34);
            this.panel2.TabIndex = 47;
            // 
            // lblProducName
            // 
            this.lblProducName.AutoSize = true;
            this.lblProducName.ForeColor = System.Drawing.Color.White;
            this.lblProducName.Location = new System.Drawing.Point(3, 9);
            this.lblProducName.Name = "lblProducName";
            this.lblProducName.Size = new System.Drawing.Size(67, 15);
            this.lblProducName.TabIndex = 47;
            this.lblProducName.Text = "초코시럽";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblProductMoney);
            this.panel3.Location = new System.Drawing.Point(456, 549);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 34);
            this.panel3.TabIndex = 48;
            // 
            // lblProductMoney
            // 
            this.lblProductMoney.AutoSize = true;
            this.lblProductMoney.ForeColor = System.Drawing.Color.White;
            this.lblProductMoney.Location = new System.Drawing.Point(3, 9);
            this.lblProductMoney.Name = "lblProductMoney";
            this.lblProductMoney.Size = new System.Drawing.Size(55, 15);
            this.lblProductMoney.TabIndex = 47;
            this.lblProductMoney.Text = "200000";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblProductNumber);
            this.panel4.Location = new System.Drawing.Point(456, 624);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 34);
            this.panel4.TabIndex = 49;
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.ForeColor = System.Drawing.Color.White;
            this.lblProductNumber.Location = new System.Drawing.Point(3, 9);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(55, 15);
            this.lblProductNumber.TabIndex = 47;
            this.lblProductNumber.Text = "100000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(601, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "원";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(601, 634);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(22, 15);
            this.lblType.TabIndex = 51;
            this.lblType.Text = "개";
            // 
            // Offerer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(715, 716);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbbProductType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbOffererName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOfferer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Offerer_Form";
            this.Text = "거래처자재목록";
            this.Load += new System.EventHandler(this.Offerer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOfferer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.ComboBox cbbOffererName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbProductType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProducName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProductMoney;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblType;
    }
}