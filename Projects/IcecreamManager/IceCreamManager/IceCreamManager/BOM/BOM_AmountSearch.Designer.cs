﻿namespace IceCreamManager
{
    partial class BOM_AmountSearch
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
            this.dgvAmountSearch = new System.Windows.Forms.DataGridView();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmountSearch
            // 
            this.dgvAmountSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmountSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmountSearch.Location = new System.Drawing.Point(12, 26);
            this.dgvAmountSearch.Name = "dgvAmountSearch";
            this.dgvAmountSearch.RowHeadersWidth = 51;
            this.dgvAmountSearch.RowTemplate.Height = 23;
            this.dgvAmountSearch.Size = new System.Drawing.Size(481, 311);
            this.dgvAmountSearch.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApply.Location = new System.Drawing.Point(407, 351);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 29);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancle.Location = new System.Drawing.Point(303, 351);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(86, 29);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // BOM_AmountSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(505, 392);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dgvAmountSearch);
            this.Name = "BOM_AmountSearch";
            this.Text = "소요량 예측 - 조회";
            this.Load += new System.EventHandler(this.BOM_AmountSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmountSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmountSearch;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancle;
    }
}