﻿namespace IceCreamManager.UserMain
{
    partial class ProductListUserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pro_Price = new System.Windows.Forms.Label();
            this.pro_No = new System.Windows.Forms.Label();
            this.pro_Name = new System.Windows.Forms.Label();
            this.pro_Img = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pro_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pro_Price);
            this.panel2.Controls.Add(this.pro_No);
            this.panel2.Controls.Add(this.pro_Name);
            this.panel2.Controls.Add(this.pro_Img);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 176);
            this.panel2.TabIndex = 1;
            // 
            // pro_Price
            // 
            this.pro_Price.AutoSize = true;
            this.pro_Price.Location = new System.Drawing.Point(152, 137);
            this.pro_Price.Name = "pro_Price";
            this.pro_Price.Size = new System.Drawing.Size(52, 12);
            this.pro_Price.TabIndex = 3;
            this.pro_Price.Text = "proPrice";
            this.pro_Price.Visible = false;
            // 
            // pro_No
            // 
            this.pro_No.AutoSize = true;
            this.pro_No.Location = new System.Drawing.Point(3, 137);
            this.pro_No.Name = "pro_No";
            this.pro_No.Size = new System.Drawing.Size(39, 12);
            this.pro_No.TabIndex = 2;
            this.pro_No.Text = "proNo";
            this.pro_No.Visible = false;
            // 
            // pro_Name
            // 
            this.pro_Name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pro_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pro_Name.Location = new System.Drawing.Point(2, 137);
            this.pro_Name.Name = "pro_Name";
            this.pro_Name.Size = new System.Drawing.Size(199, 30);
            this.pro_Name.TabIndex = 1;
            this.pro_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pro_Img
            // 
            this.pro_Img.BackColor = System.Drawing.Color.White;
            this.pro_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pro_Img.Location = new System.Drawing.Point(4, 4);
            this.pro_Img.Name = "pro_Img";
            this.pro_Img.Size = new System.Drawing.Size(200, 126);
            this.pro_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pro_Img.TabIndex = 0;
            this.pro_Img.TabStop = false;
            this.pro_Img.Click += new System.EventHandler(this.ProductListUserControl_Click);
            // 
            // ProductListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ProductListUserControl";
            this.Size = new System.Drawing.Size(213, 182);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pro_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pro_Name;
        private System.Windows.Forms.PictureBox pro_Img;
        private System.Windows.Forms.Label pro_Price;
        private System.Windows.Forms.Label pro_No;
    }
}
