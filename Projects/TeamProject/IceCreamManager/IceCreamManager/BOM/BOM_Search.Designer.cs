﻿namespace IceCreamManager.BOM
{
    partial class BOM_Search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rdo_Implosion = new System.Windows.Forms.RadioButton();
            this.Rdo_Explosion = new System.Windows.Forms.RadioButton();
            this.Text_Number = new System.Windows.Forms.TextBox();
            this.Text_Name = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목 번호 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "품목명 :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rdo_Implosion);
            this.panel1.Controls.Add(this.Rdo_Explosion);
            this.panel1.Location = new System.Drawing.Point(31, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 38);
            this.panel1.TabIndex = 1;
            // 
            // Rdo_Implosion
            // 
            this.Rdo_Implosion.AutoSize = true;
            this.Rdo_Implosion.ForeColor = System.Drawing.Color.White;
            this.Rdo_Implosion.Location = new System.Drawing.Point(104, 4);
            this.Rdo_Implosion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rdo_Implosion.Name = "Rdo_Implosion";
            this.Rdo_Implosion.Size = new System.Drawing.Size(73, 19);
            this.Rdo_Implosion.TabIndex = 0;
            this.Rdo_Implosion.TabStop = true;
            this.Rdo_Implosion.Text = "역전개";
            this.Rdo_Implosion.UseVisualStyleBackColor = true;
            // 
            // Rdo_Explosion
            // 
            this.Rdo_Explosion.AutoSize = true;
            this.Rdo_Explosion.ForeColor = System.Drawing.Color.White;
            this.Rdo_Explosion.Location = new System.Drawing.Point(3, 4);
            this.Rdo_Explosion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rdo_Explosion.Name = "Rdo_Explosion";
            this.Rdo_Explosion.Size = new System.Drawing.Size(73, 19);
            this.Rdo_Explosion.TabIndex = 0;
            this.Rdo_Explosion.TabStop = true;
            this.Rdo_Explosion.Text = "정전개";
            this.Rdo_Explosion.UseVisualStyleBackColor = true;
            // 
            // Text_Number
            // 
            this.Text_Number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Text_Number.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Number.Location = new System.Drawing.Point(123, 30);
            this.Text_Number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_Number.Name = "Text_Number";
            this.Text_Number.Size = new System.Drawing.Size(172, 30);
            this.Text_Number.TabIndex = 2;
            // 
            // Text_Name
            // 
            this.Text_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Text_Name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Name.Location = new System.Drawing.Point(385, 30);
            this.Text_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(365, 30);
            this.Text_Name.TabIndex = 2;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Update.Location = new System.Drawing.Point(558, 81);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(94, 40);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.Text = "수정";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Delete.Location = new System.Drawing.Point(658, 81);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(94, 40);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "삭제";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Btn_Find
            // 
            this.Btn_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Find.Location = new System.Drawing.Point(385, 81);
            this.Btn_Find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(94, 40);
            this.Btn_Find.TabIndex = 3;
            this.Btn_Find.Text = "목록 검색";
            this.Btn_Find.UseVisualStyleBackColor = false;
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(31, 135);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 23;
            this.dgvSearch.Size = new System.Drawing.Size(720, 436);
            this.dgvSearch.TabIndex = 4;
            // 
            // BOM_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 586);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Text_Name);
            this.Controls.Add(this.Text_Number);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BOM_Search";
            this.Text = "BOM 조회";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rdo_Implosion;
        private System.Windows.Forms.RadioButton Rdo_Explosion;
        private System.Windows.Forms.TextBox Text_Number;
        private System.Windows.Forms.TextBox Text_Name;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.DataGridView dgvSearch;
    }
}