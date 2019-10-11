namespace _0924_03_ListView
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Excel",
            "5,000",
            "3",
            "165,000"}, 1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Access",
            "1,000",
            "2",
            "2,000"}, 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "OutLook",
            "2,000",
            "5",
            "50,000"}, 2);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "PowerPoint",
            "9,000",
            "20",
            "180,000"}, 3);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Word",
            "2,000",
            "10",
            "20,000"}, 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.shortImageList = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductName,
            this.chUnitPrice,
            this.chQantity,
            this.chPrice});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.LargeImageList = this.largeImageList;
            this.listView1.Location = new System.Drawing.Point(12, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 336);
            this.listView1.SmallImageList = this.shortImageList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // chProductName
            // 
            this.chProductName.Text = "제품명";
            this.chProductName.Width = 200;
            // 
            // chUnitPrice
            // 
            this.chUnitPrice.Text = "단가";
            this.chUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chUnitPrice.Width = 100;
            // 
            // chQantity
            // 
            this.chQantity.Text = "수량";
            this.chQantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chPrice
            // 
            this.chPrice.Text = "금액";
            this.chPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chPrice.Width = 100;
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "access.png");
            this.largeImageList.Images.SetKeyName(1, "excel.png");
            this.largeImageList.Images.SetKeyName(2, "outlook.png");
            this.largeImageList.Images.SetKeyName(3, "ppt.png");
            this.largeImageList.Images.SetKeyName(4, "word.png");
            // 
            // shortImageList
            // 
            this.shortImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("shortImageList.ImageStream")));
            this.shortImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.shortImageList.Images.SetKeyName(0, "access.png");
            this.shortImageList.Images.SetKeyName(1, "excel.png");
            this.shortImageList.Images.SetKeyName(2, "outlook.png");
            this.shortImageList.Images.SetKeyName(3, "ppt.png");
            this.shortImageList.Images.SetKeyName(4, "word.png");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList shortImageList;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chUnitPrice;
        private System.Windows.Forms.ColumnHeader chQantity;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

