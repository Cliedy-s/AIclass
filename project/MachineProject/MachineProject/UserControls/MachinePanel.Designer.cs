﻿namespace MachineProject
{
    partial class MachinePanel
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDefectRateAlarm_V = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDefectRate_V = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDefectAmount_V = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAmount_V = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMahineName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDefectRateAlarm_V);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblDefectRate_V);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDefectAmount_V);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalAmount_V);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblMahineName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 364);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 69);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblDefectRateAlarm_V
            // 
            this.lblDefectRateAlarm_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectRateAlarm_V.Location = new System.Drawing.Point(127, 336);
            this.lblDefectRateAlarm_V.Name = "lblDefectRateAlarm_V";
            this.lblDefectRateAlarm_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectRateAlarm_V.Size = new System.Drawing.Size(62, 19);
            this.lblDefectRateAlarm_V.TabIndex = 17;
            this.lblDefectRateAlarm_V.Text = "0";
            this.lblDefectRateAlarm_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(175, 336);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefectRate_V
            // 
            this.lblDefectRate_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectRate_V.Location = new System.Drawing.Point(127, 316);
            this.lblDefectRate_V.Name = "lblDefectRate_V";
            this.lblDefectRate_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectRate_V.Size = new System.Drawing.Size(62, 19);
            this.lblDefectRate_V.TabIndex = 15;
            this.lblDefectRate_V.Text = "0";
            this.lblDefectRate_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(175, 316);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefectAmount_V
            // 
            this.lblDefectAmount_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectAmount_V.Location = new System.Drawing.Point(127, 293);
            this.lblDefectAmount_V.Name = "lblDefectAmount_V";
            this.lblDefectAmount_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectAmount_V.Size = new System.Drawing.Size(62, 19);
            this.lblDefectAmount_V.TabIndex = 13;
            this.lblDefectAmount_V.Text = "0";
            this.lblDefectAmount_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(175, 293);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "개";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount_V
            // 
            this.lblTotalAmount_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalAmount_V.Location = new System.Drawing.Point(127, 274);
            this.lblTotalAmount_V.Name = "lblTotalAmount_V";
            this.lblTotalAmount_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAmount_V.Size = new System.Drawing.Size(62, 19);
            this.lblTotalAmount_V.TabIndex = 4;
            this.lblTotalAmount_V.Text = "0";
            this.lblTotalAmount_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(175, 274);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "개";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(5, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "불량률 마지노선";
            // 
            // lblMahineName
            // 
            this.lblMahineName.AutoSize = true;
            this.lblMahineName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMahineName.Location = new System.Drawing.Point(4, 250);
            this.lblMahineName.Name = "lblMahineName";
            this.lblMahineName.Size = new System.Drawing.Size(120, 19);
            this.lblMahineName.TabIndex = 9;
            this.lblMahineName.Text = "MachineName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(5, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "불량률";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(5, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "불량 상품 수";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(5, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "전체 상품 수";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 169);
            this.listBox1.TabIndex = 0;
            // 
            // MachinePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MachinePanel";
            this.Size = new System.Drawing.Size(213, 364);
            this.Load += new System.EventHandler(this.MachinePanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDefectRateAlarm_V;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDefectRate_V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDefectAmount_V;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalAmount_V;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMahineName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}