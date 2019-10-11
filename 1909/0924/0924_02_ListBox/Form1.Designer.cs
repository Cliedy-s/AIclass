namespace _0924_02_ListBox
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
            this.cklFruits = new System.Windows.Forms.CheckedListBox();
            this.btnSendChecked = new System.Windows.Forms.Button();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstSelectedFruits = new System.Windows.Forms.ListBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cklFruits
            // 
            this.cklFruits.FormattingEnabled = true;
            this.cklFruits.Items.AddRange(new object[] {
            "사과",
            "참외",
            "배",
            "포도",
            "옥수수",
            "토마토",
            "복숭아",
            "망고",
            "멜론",
            "체리",
            "자두",
            "두리안",
            "딸기",
            "용과",
            "고구마",
            "감자",
            "당근",
            "마늘"});
            this.cklFruits.Location = new System.Drawing.Point(75, 54);
            this.cklFruits.Name = "cklFruits";
            this.cklFruits.Size = new System.Drawing.Size(260, 308);
            this.cklFruits.TabIndex = 0;
            // 
            // btnSendChecked
            // 
            this.btnSendChecked.Location = new System.Drawing.Point(367, 144);
            this.btnSendChecked.Name = "btnSendChecked";
            this.btnSendChecked.Size = new System.Drawing.Size(75, 23);
            this.btnSendChecked.TabIndex = 1;
            this.btnSendChecked.Text = ">";
            this.btnSendChecked.UseVisualStyleBackColor = true;
            this.btnSendChecked.Click += new System.EventHandler(this.BtnSendChecked_Click);
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(367, 208);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(75, 23);
            this.btnSendAll.TabIndex = 2;
            this.btnSendAll.Text = ">>";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.BtnSendAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lstSelectedFruits
            // 
            this.lstSelectedFruits.FormattingEnabled = true;
            this.lstSelectedFruits.ItemHeight = 12;
            this.lstSelectedFruits.Location = new System.Drawing.Point(473, 54);
            this.lstSelectedFruits.Name = "lstSelectedFruits";
            this.lstSelectedFruits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedFruits.Size = new System.Drawing.Size(260, 316);
            this.lstSelectedFruits.TabIndex = 4;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(402, 398);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 5;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.BtnReverse_Click);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(585, 398);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(148, 23);
            this.btnDeleteList.TabIndex = 6;
            this.btnDeleteList.Text = "데이터 삭제";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.lstSelectedFruits);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.btnSendChecked);
            this.Controls.Add(this.cklFruits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklFruits;
        private System.Windows.Forms.Button btnSendChecked;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstSelectedFruits;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnDeleteList;
    }
}

