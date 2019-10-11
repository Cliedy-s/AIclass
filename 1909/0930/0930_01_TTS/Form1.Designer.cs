namespace _0930_01_TTS
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
            this.txtTextToSpeak = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.ddlVoices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextToSpeak
            // 
            this.txtTextToSpeak.Location = new System.Drawing.Point(12, 12);
            this.txtTextToSpeak.Multiline = true;
            this.txtTextToSpeak.Name = "txtTextToSpeak";
            this.txtTextToSpeak.Size = new System.Drawing.Size(400, 114);
            this.txtTextToSpeak.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Speak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(25, 267);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(370, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(25, 370);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(370, 56);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(22, 238);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(37, 15);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Rate";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(22, 343);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(54, 15);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volumn";
            // 
            // ddlVoices
            // 
            this.ddlVoices.FormattingEnabled = true;
            this.ddlVoices.Location = new System.Drawing.Point(25, 470);
            this.ddlVoices.Name = "ddlVoices";
            this.ddlVoices.Size = new System.Drawing.Size(370, 23);
            this.ddlVoices.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 539);
            this.Controls.Add(this.ddlVoices);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTextToSpeak);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextToSpeak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ComboBox ddlVoices;
    }
}

