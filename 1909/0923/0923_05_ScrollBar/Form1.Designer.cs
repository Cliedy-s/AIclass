namespace _0923_05_ScrollBar
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
            this.scrB = new System.Windows.Forms.HScrollBar();
            this.scrG = new System.Windows.Forms.HScrollBar();
            this.scrR = new System.Windows.Forms.HScrollBar();
            this.panColorShow = new System.Windows.Forms.Panel();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.trbR = new System.Windows.Forms.TrackBar();
            this.trbG = new System.Windows.Forms.TrackBar();
            this.trbB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).BeginInit();
            this.SuspendLayout();
            // 
            // scrB
            // 
            this.scrB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrB.Location = new System.Drawing.Point(37, 373);
            this.scrB.Maximum = 264;
            this.scrB.Name = "scrB";
            this.scrB.Size = new System.Drawing.Size(446, 23);
            this.scrB.TabIndex = 1;
            this.scrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scr_Scroll);
            // 
            // scrG
            // 
            this.scrG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrG.Location = new System.Drawing.Point(37, 324);
            this.scrG.Maximum = 264;
            this.scrG.Name = "scrG";
            this.scrG.Size = new System.Drawing.Size(446, 23);
            this.scrG.TabIndex = 2;
            this.scrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scr_Scroll);
            // 
            // scrR
            // 
            this.scrR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrR.Location = new System.Drawing.Point(37, 272);
            this.scrR.Maximum = 264;
            this.scrR.Name = "scrR";
            this.scrR.Size = new System.Drawing.Size(446, 23);
            this.scrR.TabIndex = 3;
            this.scrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scr_Scroll);
            // 
            // panColorShow
            // 
            this.panColorShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panColorShow.Location = new System.Drawing.Point(37, 123);
            this.panColorShow.Name = "panColorShow";
            this.panColorShow.Size = new System.Drawing.Size(538, 118);
            this.panColorShow.TabIndex = 4;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(35, 261);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(13, 12);
            this.lblR.TabIndex = 0;
            this.lblR.Text = "R";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(35, 313);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(14, 12);
            this.lblG.TabIndex = 5;
            this.lblG.Text = "G";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(35, 362);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(13, 12);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "B";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(502, 273);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(73, 21);
            this.txtR.TabIndex = 7;
            this.txtR.Text = "0";
            this.txtR.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(502, 325);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(73, 21);
            this.txtG.TabIndex = 8;
            this.txtG.Text = "0";
            this.txtG.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(502, 374);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(73, 21);
            this.txtB.TabIndex = 9;
            this.txtB.Text = "0";
            this.txtB.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // trbR
            // 
            this.trbR.Location = new System.Drawing.Point(37, 12);
            this.trbR.Maximum = 255;
            this.trbR.Name = "trbR";
            this.trbR.Size = new System.Drawing.Size(538, 45);
            this.trbR.TabIndex = 10;
            this.trbR.Scroll += new System.EventHandler(this.Trb_Scroll);
            // 
            // trbG
            // 
            this.trbG.Location = new System.Drawing.Point(37, 42);
            this.trbG.Maximum = 255;
            this.trbG.Name = "trbG";
            this.trbG.Size = new System.Drawing.Size(538, 45);
            this.trbG.TabIndex = 11;
            this.trbG.Scroll += new System.EventHandler(this.Trb_Scroll);
            // 
            // trbB
            // 
            this.trbB.Location = new System.Drawing.Point(37, 72);
            this.trbB.Maximum = 255;
            this.trbB.Name = "trbB";
            this.trbB.Size = new System.Drawing.Size(538, 45);
            this.trbB.TabIndex = 12;
            this.trbB.Scroll += new System.EventHandler(this.Trb_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 425);
            this.Controls.Add(this.trbB);
            this.Controls.Add(this.trbG);
            this.Controls.Add(this.trbR);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.panColorShow);
            this.Controls.Add(this.scrR);
            this.Controls.Add(this.scrG);
            this.Controls.Add(this.scrB);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrB;
        private System.Windows.Forms.HScrollBar scrG;
        private System.Windows.Forms.HScrollBar scrR;
        private System.Windows.Forms.Panel panColorShow;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TrackBar trbR;
        private System.Windows.Forms.TrackBar trbG;
        private System.Windows.Forms.TrackBar trbB;
    }
}

