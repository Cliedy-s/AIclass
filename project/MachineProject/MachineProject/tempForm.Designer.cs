namespace MachineProject
{
    partial class tempForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panMachine = new System.Windows.Forms.Panel();
            this.lblDefectAmountAlarm_V = new System.Windows.Forms.Label();
            this.lblDefectAmountAlarm_K = new System.Windows.Forms.Label();
            this.lblMahineName = new System.Windows.Forms.Label();
            this.lblDefectRate_V = new System.Windows.Forms.Label();
            this.lblDefectRate_K = new System.Windows.Forms.Label();
            this.lblDefectAmount_V = new System.Windows.Forms.Label();
            this.lblDefectAmount_K = new System.Windows.Forms.Label();
            this.lblTotalAmount_V = new System.Windows.Forms.Label();
            this.lblTotalAmount_K = new System.Windows.Forms.Label();
            this.lstMachineLog = new System.Windows.Forms.ListBox();
            this.panMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMachine
            // 
            this.panMachine.Controls.Add(this.lblDefectAmountAlarm_V);
            this.panMachine.Controls.Add(this.lblDefectAmountAlarm_K);
            this.panMachine.Controls.Add(this.lblMahineName);
            this.panMachine.Controls.Add(this.lblDefectRate_V);
            this.panMachine.Controls.Add(this.lblDefectRate_K);
            this.panMachine.Controls.Add(this.lblDefectAmount_V);
            this.panMachine.Controls.Add(this.lblDefectAmount_K);
            this.panMachine.Controls.Add(this.lblTotalAmount_V);
            this.panMachine.Controls.Add(this.lblTotalAmount_K);
            this.panMachine.Controls.Add(this.lstMachineLog);
            this.panMachine.Location = new System.Drawing.Point(23, 18);
            this.panMachine.Name = "panMachine";
            this.panMachine.Size = new System.Drawing.Size(262, 420);
            this.panMachine.TabIndex = 5;
            // 
            // lblDefectAmountAlarm_V
            // 
            this.lblDefectAmountAlarm_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectAmountAlarm_V.Location = new System.Drawing.Point(137, 391);
            this.lblDefectAmountAlarm_V.Name = "lblDefectAmountAlarm_V";
            this.lblDefectAmountAlarm_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectAmountAlarm_V.Size = new System.Drawing.Size(105, 19);
            this.lblDefectAmountAlarm_V.TabIndex = 11;
            this.lblDefectAmountAlarm_V.Text = "0%";
            this.lblDefectAmountAlarm_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblDefectRate_V
            // 
            this.lblDefectRate_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectRate_V.Location = new System.Drawing.Point(137, 373);
            this.lblDefectRate_V.Name = "lblDefectRate_V";
            this.lblDefectRate_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectRate_V.Size = new System.Drawing.Size(105, 19);
            this.lblDefectRate_V.TabIndex = 8;
            this.lblDefectRate_V.Text = "0%";
            this.lblDefectRate_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblDefectAmount_V
            // 
            this.lblDefectAmount_V.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefectAmount_V.Location = new System.Drawing.Point(137, 348);
            this.lblDefectAmount_V.Name = "lblDefectAmount_V";
            this.lblDefectAmount_V.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDefectAmount_V.Size = new System.Drawing.Size(105, 19);
            this.lblDefectAmount_V.TabIndex = 6;
            this.lblDefectAmount_V.Text = "0개";
            this.lblDefectAmount_V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblTotalAmount_V.Size = new System.Drawing.Size(105, 19);
            this.lblTotalAmount_V.TabIndex = 4;
            this.lblTotalAmount_V.Text = "0개";
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
            // tempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMachine);
            this.Name = "tempForm";
            this.Text = "tempForm";
            this.panMachine.ResumeLayout(false);
            this.panMachine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMachine;
        private System.Windows.Forms.Label lblDefectAmountAlarm_V;
        private System.Windows.Forms.Label lblDefectAmountAlarm_K;
        private System.Windows.Forms.Label lblMahineName;
        private System.Windows.Forms.Label lblDefectRate_V;
        private System.Windows.Forms.Label lblDefectRate_K;
        private System.Windows.Forms.Label lblDefectAmount_V;
        private System.Windows.Forms.Label lblDefectAmount_K;
        private System.Windows.Forms.Label lblTotalAmount_V;
        private System.Windows.Forms.Label lblTotalAmount_K;
        private System.Windows.Forms.ListBox lstMachineLog;
    }
}