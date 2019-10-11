namespace _1002_02_CustomControl
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myCustomControl1 = new _1002_02_CustomControl.MyCustomControl();
            this.cuteButton1 = new _1002_02_CustomControl.CuteButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // myCustomControl1
            // 
            this.myCustomControl1.BackColor = System.Drawing.SystemColors.Window;
            this.myCustomControl1.CommonColor = System.Drawing.SystemColors.Window;
            this.myCustomControl1.KeyColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.myCustomControl1.Location = new System.Drawing.Point(281, 133);
            this.myCustomControl1.Name = "myCustomControl1";
            this.myCustomControl1.RequiredColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.myCustomControl1.Size = new System.Drawing.Size(100, 21);
            this.myCustomControl1.TabIndex = 1;
            this.myCustomControl1.Types = _1002_02_CustomControl.TextTypes.Common;
            // 
            // cuteButton1
            // 
            this.cuteButton1.CuteColor1 = System.Drawing.Color.LightGreen;
            this.cuteButton1.CuteColor1Transparent = 100;
            this.cuteButton1.CuteColor2 = System.Drawing.Color.DarkBlue;
            this.cuteButton1.CuteColor2Transparent = 100;
            this.cuteButton1.Location = new System.Drawing.Point(150, 255);
            this.cuteButton1.Name = "cuteButton1";
            this.cuteButton1.Size = new System.Drawing.Size(554, 169);
            this.cuteButton1.TabIndex = 2;
            this.cuteButton1.Text = "cuteButton1";
            this.cuteButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cuteButton1);
            this.Controls.Add(this.myCustomControl1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MyCustomControl myCustomControl1;
        private CuteButton cuteButton1;
    }
}

