namespace MachineProject
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
            this.panMachine = new System.Windows.Forms.Panel();
            this.lblDefectAmountAlarm_K = new System.Windows.Forms.Label();
            this.lblMahineName = new System.Windows.Forms.Label();
            this.lblDefectRate_K = new System.Windows.Forms.Label();
            this.lblDefectAmount_K = new System.Windows.Forms.Label();
            this.lblTotalAmount_V = new System.Windows.Forms.Label();
            this.lblTotalAmount_K = new System.Windows.Forms.Label();
            this.lstMachineLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDefectAmount_V = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDefectRate_V = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDefectRateAlarm_V = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMachine
            // 
            this.panMachine.Controls.Add(this.lblDefectRateAlarm_V);
            this.panMachine.Controls.Add(this.label7);
            this.panMachine.Controls.Add(this.lblDefectRate_V);
            this.panMachine.Controls.Add(this.label5);
            this.panMachine.Controls.Add(this.lblDefectAmount_V);
            this.panMachine.Controls.Add(this.label3);
            this.panMachine.Controls.Add(this.lblTotalAmount_V);
            this.panMachine.Controls.Add(this.label1);
            this.panMachine.Controls.Add(this.lblDefectAmountAlarm_K);
            this.panMachine.Controls.Add(this.lblMahineName);
            this.panMachine.Controls.Add(this.lblDefectRate_K);
            this.panMachine.Controls.Add(this.lblDefectAmount_K);
            this.panMachine.Controls.Add(this.lblTotalAmount_K);
            this.panMachine.Controls.Add(this.lstMachineLog);
            this.panMachine.Location = new System.Drawing.Point(0, 0);
            this.panMachine.Name = "panMachine";
            this.panMachine.Size = new System.Drawing.Size(262, 420);
            this.panMachine.TabIndex = 7;
            // 
            // lblDefectAmountAlarm_K
            // 
            this.lblDefectAmountAlarm_K.AutoSize = true;
            this.lblDefectAmountAlarm_K.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectAmountAlarm_K.Location = new System.Drawing.Point(17, 391);
            this.lblDefectAmountAlarm_K.Name = "lblDefectAmountAlarm_K";
            this.lblDefectAmountAlarm_K.Size = new System.Drawing.Size(95, 15);
            this.lblDefectAmountAlarm_K.TabIndex = 10;
            this.lblDefectAmountAlarm_K.Text = "불량률 마지노선";
            // 
            // lblMahineName
            // 
            this.lblMahineName.AutoSize = true;
            this.lblMahineName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMahineName.Location = new System.Drawing.Point(15, 305);
            this.lblMahineName.Name = "lblMahineName";
            this.lblMahineName.Size = new System.Drawing.Size(120, 19);
            this.lblMahineName.TabIndex = 9;
            this.lblMahineName.Text = "MachineName";
            // 
            // lblDefectRate_K
            // 
            this.lblDefectRate_K.AutoSize = true;
            this.lblDefectRate_K.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectRate_K.Location = new System.Drawing.Point(17, 373);
            this.lblDefectRate_K.Name = "lblDefectRate_K";
            this.lblDefectRate_K.Size = new System.Drawing.Size(43, 15);
            this.lblDefectRate_K.TabIndex = 7;
            this.lblDefectRate_K.Text = "불량률";
            // 
            // lblDefectAmount_K
            // 
            this.lblDefectAmount_K.AutoSize = true;
            this.lblDefectAmount_K.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectAmount_K.Location = new System.Drawing.Point(17, 348);
            this.lblDefectAmount_K.Name = "lblDefectAmount_K";
            this.lblDefectAmount_K.Size = new System.Drawing.Size(75, 15);
            this.lblDefectAmount_K.TabIndex = 5;
            this.lblDefectAmount_K.Text = "불량 상품 수";
            // 
            // lblTotalAmount_V
            // 
            this.lblTotalAmount_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalAmount_V.Location = new System.Drawing.Point(137, 329);
            this.lblTotalAmount_V.Name = "lblTotalAmount_V";
            this.lblTotalAmount_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAmount_V.Size = new System.Drawing.Size(86, 19);
            this.lblTotalAmount_V.TabIndex = 4;
            this.lblTotalAmount_V.Text = "0";
            this.lblTotalAmount_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount_K
            // 
            this.lblTotalAmount_K.AutoSize = true;
            this.lblTotalAmount_K.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalAmount_K.Location = new System.Drawing.Point(17, 329);
            this.lblTotalAmount_K.Name = "lblTotalAmount_K";
            this.lblTotalAmount_K.Size = new System.Drawing.Size(75, 15);
            this.lblTotalAmount_K.TabIndex = 3;
            this.lblTotalAmount_K.Text = "전체 상품 수";
            // 
            // lstMachineLog
            // 
            this.lstMachineLog.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstMachineLog.FormattingEnabled = true;
            this.lstMachineLog.ItemHeight = 15;
            this.lstMachineLog.Location = new System.Drawing.Point(3, 3);
            this.lstMachineLog.Name = "lstMachineLog";
            this.lstMachineLog.Size = new System.Drawing.Size(255, 289);
            this.lstMachineLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(209, 329);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "개";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefectAmount_V
            // 
            this.lblDefectAmount_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectAmount_V.Location = new System.Drawing.Point(137, 348);
            this.lblDefectAmount_V.Name = "lblDefectAmount_V";
            this.lblDefectAmount_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectAmount_V.Size = new System.Drawing.Size(86, 19);
            this.lblDefectAmount_V.TabIndex = 13;
            this.lblDefectAmount_V.Text = "0";
            this.lblDefectAmount_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(209, 348);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "개";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefectRate_V
            // 
            this.lblDefectRate_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectRate_V.Location = new System.Drawing.Point(137, 371);
            this.lblDefectRate_V.Name = "lblDefectRate_V";
            this.lblDefectRate_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectRate_V.Size = new System.Drawing.Size(86, 19);
            this.lblDefectRate_V.TabIndex = 15;
            this.lblDefectRate_V.Text = "0";
            this.lblDefectRate_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(209, 371);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefectRateAlarm_V
            // 
            this.lblDefectRateAlarm_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectRateAlarm_V.Location = new System.Drawing.Point(137, 391);
            this.lblDefectRateAlarm_V.Name = "lblDefectRateAlarm_V";
            this.lblDefectRateAlarm_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectRateAlarm_V.Size = new System.Drawing.Size(86, 19);
            this.lblDefectRateAlarm_V.TabIndex = 17;
            this.lblDefectRateAlarm_V.Text = "0";
            this.lblDefectRateAlarm_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(209, 391);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MachinePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMachine);
            this.Name = "MachinePanel";
            this.Size = new System.Drawing.Size(262, 420);
            this.panMachine.ResumeLayout(false);
            this.panMachine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMachine;
        private System.Windows.Forms.Label lblDefectAmountAlarm_K;
        private System.Windows.Forms.Label lblMahineName;
        private System.Windows.Forms.Label lblDefectRate_K;
        private System.Windows.Forms.Label lblDefectAmount_K;
        private System.Windows.Forms.Label lblTotalAmount_V;
        private System.Windows.Forms.Label lblTotalAmount_K;
        private System.Windows.Forms.ListBox lstMachineLog;
        private System.Windows.Forms.Label lblDefectRateAlarm_V;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDefectRate_V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDefectAmount_V;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
