namespace MessageClient
{
    partial class ClientForm
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
            this.msgViewBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.userlistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgViewBox
            // 
            this.msgViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgViewBox.Location = new System.Drawing.Point(0, 0);
            this.msgViewBox.Multiline = true;
            this.msgViewBox.Name = "msgViewBox";
            this.msgViewBox.ReadOnly = true;
            this.msgViewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.msgViewBox.Size = new System.Drawing.Size(615, 391);
            this.msgViewBox.TabIndex = 0;
            // 
            // sendBox
            // 
            this.sendBox.Location = new System.Drawing.Point(0, 401);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(615, 25);
            this.sendBox.TabIndex = 1;
            this.sendBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendBox_KeyPress);
            // 
            // userlistBox
            // 
            this.userlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userlistBox.FormattingEnabled = true;
            this.userlistBox.ItemHeight = 15;
            this.userlistBox.Location = new System.Drawing.Point(622, 0);
            this.userlistBox.Name = "userlistBox";
            this.userlistBox.Size = new System.Drawing.Size(218, 274);
            this.userlistBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.usernameBox);
            this.groupBox1.Location = new System.Drawing.Point(622, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 ID";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(17, 76);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(183, 32);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "접속";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(16, 33);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(185, 25);
            this.usernameBox.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userlistBox);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.msgViewBox);
            this.Name = "ClientForm";
            this.Text = "메신저클라이언트";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgViewBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.ListBox userlistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox usernameBox;
    }
}

