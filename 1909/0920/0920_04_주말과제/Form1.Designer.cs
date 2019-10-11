namespace _0920_04_주말과제
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOpportunity = new System.Windows.Forms.Label();
            this.txtTypeBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시작ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.초급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.chkENG = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(21, 129);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(714, 24);
            this.progressBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "점수";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(135, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(11, 12);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "점수";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblOpportunity);
            this.groupBox2.Location = new System.Drawing.Point(559, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "남은 기회";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(132, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "회";
            // 
            // lblOpportunity
            // 
            this.lblOpportunity.AutoSize = true;
            this.lblOpportunity.Location = new System.Drawing.Point(39, 33);
            this.lblOpportunity.Name = "lblOpportunity";
            this.lblOpportunity.Size = new System.Drawing.Size(11, 12);
            this.lblOpportunity.TabIndex = 2;
            this.lblOpportunity.Text = "0";
            // 
            // txtTypeBox
            // 
            this.txtTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeBox.Enabled = false;
            this.txtTypeBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTypeBox.Location = new System.Drawing.Point(21, 217);
            this.txtTypeBox.Name = "txtTypeBox";
            this.txtTypeBox.Size = new System.Drawing.Size(714, 35);
            this.txtTypeBox.TabIndex = 3;
            this.txtTypeBox.TextChanged += new System.EventHandler(this.TxtTypeBox_TextChanged);
            this.txtTypeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTypeBox_KeyDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem1});
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.시작ToolStripMenuItem.Text = "시작";
            // 
            // 시작ToolStripMenuItem1
            // 
            this.시작ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.초급ToolStripMenuItem,
            this.중급ToolStripMenuItem,
            this.고급ToolStripMenuItem});
            this.시작ToolStripMenuItem1.Name = "시작ToolStripMenuItem1";
            this.시작ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.시작ToolStripMenuItem1.Text = "시작";
            // 
            // 초급ToolStripMenuItem
            // 
            this.초급ToolStripMenuItem.Name = "초급ToolStripMenuItem";
            this.초급ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.초급ToolStripMenuItem.Text = "초급";
            this.초급ToolStripMenuItem.Click += new System.EventHandler(this.startGame);
            // 
            // 중급ToolStripMenuItem
            // 
            this.중급ToolStripMenuItem.Name = "중급ToolStripMenuItem";
            this.중급ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.중급ToolStripMenuItem.Text = "중급";
            this.중급ToolStripMenuItem.Click += new System.EventHandler(this.startGame);
            // 
            // 고급ToolStripMenuItem
            // 
            this.고급ToolStripMenuItem.Name = "고급ToolStripMenuItem";
            this.고급ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.고급ToolStripMenuItem.Text = "고급";
            this.고급ToolStripMenuItem.Click += new System.EventHandler(this.startGame);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAnswer.Location = new System.Drawing.Point(21, 166);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(714, 36);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkENG
            // 
            this.chkENG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkENG.AutoSize = true;
            this.chkENG.Location = new System.Drawing.Point(687, 270);
            this.chkENG.Name = "chkENG";
            this.chkENG.Size = new System.Drawing.Size(48, 16);
            this.chkENG.TabIndex = 5;
            this.chkENG.Text = "영어";
            this.chkENG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 298);
            this.Controls.Add(this.chkENG);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtTypeBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "타자연습";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOpportunity;
        private System.Windows.Forms.TextBox txtTypeBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 초급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고급ToolStripMenuItem;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.CheckBox chkENG;
    }
}

