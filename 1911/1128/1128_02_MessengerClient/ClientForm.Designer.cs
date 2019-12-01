namespace _1128_02_MessengerClient
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
            this.txtMsgViewBox = new System.Windows.Forms.TextBox();
            this.txtSendBox = new System.Windows.Forms.TextBox();
            this.lstUserListBox = new System.Windows.Forms.ListBox();
            this.grpUserID = new System.Windows.Forms.GroupBox();
            this.txtUserNameBox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpUserID.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMsgViewBox
            // 
            this.txtMsgViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsgViewBox.Location = new System.Drawing.Point(12, 12);
            this.txtMsgViewBox.Multiline = true;
            this.txtMsgViewBox.Name = "txtMsgViewBox";
            this.txtMsgViewBox.ReadOnly = true;
            this.txtMsgViewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsgViewBox.Size = new System.Drawing.Size(391, 357);
            this.txtMsgViewBox.TabIndex = 0;
            // 
            // txtSendBox
            // 
            this.txtSendBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendBox.Location = new System.Drawing.Point(12, 375);
            this.txtSendBox.Name = "txtSendBox";
            this.txtSendBox.Size = new System.Drawing.Size(391, 21);
            this.txtSendBox.TabIndex = 1;
            // 
            // lstUserListBox
            // 
            this.lstUserListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUserListBox.FormattingEnabled = true;
            this.lstUserListBox.ItemHeight = 12;
            this.lstUserListBox.Location = new System.Drawing.Point(409, 12);
            this.lstUserListBox.Name = "lstUserListBox";
            this.lstUserListBox.Size = new System.Drawing.Size(231, 292);
            this.lstUserListBox.TabIndex = 2;
            // 
            // grpUserID
            // 
            this.grpUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserID.Controls.Add(this.btnConnect);
            this.grpUserID.Controls.Add(this.txtUserNameBox);
            this.grpUserID.Location = new System.Drawing.Point(409, 311);
            this.grpUserID.Name = "grpUserID";
            this.grpUserID.Size = new System.Drawing.Size(231, 85);
            this.grpUserID.TabIndex = 3;
            this.grpUserID.TabStop = false;
            // 
            // txtUserNameBox
            // 
            this.txtUserNameBox.Location = new System.Drawing.Point(6, 20);
            this.txtUserNameBox.Name = "txtUserNameBox";
            this.txtUserNameBox.Size = new System.Drawing.Size(219, 21);
            this.txtUserNameBox.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(219, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 408);
            this.Controls.Add(this.grpUserID);
            this.Controls.Add(this.lstUserListBox);
            this.Controls.Add(this.txtSendBox);
            this.Controls.Add(this.txtMsgViewBox);
            this.MinimumSize = new System.Drawing.Size(410, 223);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.grpUserID.ResumeLayout(false);
            this.grpUserID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsgViewBox;
        private System.Windows.Forms.TextBox txtSendBox;
        private System.Windows.Forms.ListBox lstUserListBox;
        private System.Windows.Forms.GroupBox grpUserID;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUserNameBox;
    }
}

