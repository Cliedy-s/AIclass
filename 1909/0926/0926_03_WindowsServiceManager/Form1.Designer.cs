namespace _0926_03_WindowsServiceManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceState = new System.Windows.Forms.TextBox();
            this.btnServiceStart = new System.Windows.Forms.Button();
            this.btnServiceStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "서비스 컨트롤 제어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(81, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "서비스 명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(81, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "서비스 상태";
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtServiceName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtServiceName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServiceName.Location = new System.Drawing.Point(170, 86);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(259, 21);
            this.txtServiceName.TabIndex = 4;
            // 
            // txtServiceState
            // 
            this.txtServiceState.BackColor = System.Drawing.SystemColors.Menu;
            this.txtServiceState.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtServiceState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServiceState.Location = new System.Drawing.Point(170, 125);
            this.txtServiceState.Name = "txtServiceState";
            this.txtServiceState.ReadOnly = true;
            this.txtServiceState.Size = new System.Drawing.Size(259, 21);
            this.txtServiceState.TabIndex = 5;
            // 
            // btnServiceStart
            // 
            this.btnServiceStart.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnServiceStart.Location = new System.Drawing.Point(170, 167);
            this.btnServiceStart.Name = "btnServiceStart";
            this.btnServiceStart.Size = new System.Drawing.Size(120, 23);
            this.btnServiceStart.TabIndex = 0;
            this.btnServiceStart.Text = "시작";
            this.btnServiceStart.UseVisualStyleBackColor = true;
            this.btnServiceStart.Click += new System.EventHandler(this.BtnServiceStart_Click);
            // 
            // btnServiceStop
            // 
            this.btnServiceStop.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnServiceStop.Location = new System.Drawing.Point(309, 167);
            this.btnServiceStop.Name = "btnServiceStop";
            this.btnServiceStop.Size = new System.Drawing.Size(120, 23);
            this.btnServiceStop.TabIndex = 1;
            this.btnServiceStop.Text = "중지";
            this.btnServiceStop.UseVisualStyleBackColor = true;
            this.btnServiceStop.Click += new System.EventHandler(this.BtnServiceStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.중지ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 48);
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.시작ToolStripMenuItem.Text = "프로그램 보이기";
            this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
            // 
            // 중지ToolStripMenuItem
            // 
            this.중지ToolStripMenuItem.Name = "중지ToolStripMenuItem";
            this.중지ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.중지ToolStripMenuItem.Text = "프로그램 종료";
            this.중지ToolStripMenuItem.Click += new System.EventHandler(this.중지ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 217);
            this.Controls.Add(this.btnServiceStop);
            this.Controls.Add(this.btnServiceStart);
            this.Controls.Add(this.txtServiceState);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "서비스 컨트롤 제어 매니저";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceState;
        private System.Windows.Forms.Button btnServiceStart;
        private System.Windows.Forms.Button btnServiceStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중지ToolStripMenuItem;
    }
}

