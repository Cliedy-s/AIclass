namespace _1125_ListLinqSampleUI
{
    partial class frmOrder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCartDel = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnCartAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.lblOccupationRequired = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblMaritalStatusRequired = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblDOBRequired = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lblOrderedDate = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboShippers = new System.Windows.Forms.ComboBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cboCustomers2 = new System.Windows.Forms.ComboBox();
            this.cboEmployees2 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCart);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cboCustomers);
            this.tabPage1.Controls.Add(this.cboEmployees);
            this.tabPage1.Controls.Add(this.btnOrder);
            this.tabPage1.Controls.Add(this.dtpRequiredDate);
            this.tabPage1.Controls.Add(this.lblMaritalStatusRequired);
            this.tabPage1.Controls.Add(this.lblMaritalStatus);
            this.tabPage1.Controls.Add(this.lblDOBRequired);
            this.tabPage1.Controls.Add(this.lblNameRequired);
            this.tabPage1.Controls.Add(this.lblDateOfBirth);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "주문 신규등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(73, 299);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 23;
            this.dgvCart.Size = new System.Drawing.Size(680, 125);
            this.dgvCart.TabIndex = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCartDel);
            this.groupBox2.Controls.Add(this.numQuantity);
            this.groupBox2.Controls.Add(this.btnCartAdd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.cboProducts);
            this.groupBox2.Controls.Add(this.cboCategories);
            this.groupBox2.Controls.Add(this.lblOccupationRequired);
            this.groupBox2.Controls.Add(this.lblSalary);
            this.groupBox2.Controls.Add(this.lblOccupation);
            this.groupBox2.Location = new System.Drawing.Point(73, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 103);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Item";
            // 
            // btnCartDel
            // 
            this.btnCartDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartDel.Location = new System.Drawing.Point(577, 64);
            this.btnCartDel.Name = "btnCartDel";
            this.btnCartDel.Size = new System.Drawing.Size(97, 26);
            this.btnCartDel.TabIndex = 82;
            this.btnCartDel.Text = "장바구니 삭제";
            this.btnCartDel.UseVisualStyleBackColor = true;
            this.btnCartDel.Click += new System.EventHandler(this.btnCartDel_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(147, 64);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(79, 21);
            this.numQuantity.TabIndex = 81;
            // 
            // btnCartAdd
            // 
            this.btnCartAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartAdd.Location = new System.Drawing.Point(474, 64);
            this.btnCartAdd.Name = "btnCartAdd";
            this.btnCartAdd.Size = new System.Drawing.Size(97, 26);
            this.btnCartAdd.TabIndex = 80;
            this.btnCartAdd.Text = "장바구니 추가";
            this.btnCartAdd.UseVisualStyleBackColor = true;
            this.btnCartAdd.Click += new System.EventHandler(this.btnCartAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "*";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(577, 31);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(97, 21);
            this.txtUnitPrice.TabIndex = 77;
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(299, 32);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(272, 20);
            this.cboProducts.TabIndex = 76;
            this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(147, 32);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(146, 20);
            this.cboCategories.TabIndex = 75;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // lblOccupationRequired
            // 
            this.lblOccupationRequired.AutoSize = true;
            this.lblOccupationRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupationRequired.ForeColor = System.Drawing.Color.Red;
            this.lblOccupationRequired.Location = new System.Drawing.Point(88, 32);
            this.lblOccupationRequired.Name = "lblOccupationRequired";
            this.lblOccupationRequired.Size = new System.Drawing.Size(21, 25);
            this.lblOccupationRequired.TabIndex = 74;
            this.lblOccupationRequired.Text = "*";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(31, 69);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(51, 12);
            this.lblSalary.TabIndex = 73;
            this.lblSalary.Text = "Quantity";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(31, 34);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(48, 12);
            this.lblOccupation.TabIndex = 72;
            this.lblOccupation.Text = "Product";
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(220, 85);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(186, 20);
            this.cboCustomers.TabIndex = 66;
            // 
            // cboEmployees
            // 
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(220, 39);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(186, 20);
            this.cboEmployees.TabIndex = 65;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(630, 461);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 32);
            this.btnOrder.TabIndex = 64;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(220, 129);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(100, 21);
            this.dtpRequiredDate.TabIndex = 58;
            // 
            // lblMaritalStatusRequired
            // 
            this.lblMaritalStatusRequired.AutoSize = true;
            this.lblMaritalStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblMaritalStatusRequired.Location = new System.Drawing.Point(161, 130);
            this.lblMaritalStatusRequired.Name = "lblMaritalStatusRequired";
            this.lblMaritalStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblMaritalStatusRequired.TabIndex = 55;
            this.lblMaritalStatusRequired.Text = "*";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(71, 133);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(84, 12);
            this.lblMaritalStatus.TabIndex = 51;
            this.lblMaritalStatus.Text = "Required Date";
            // 
            // lblDOBRequired
            // 
            this.lblDOBRequired.AutoSize = true;
            this.lblDOBRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDOBRequired.Location = new System.Drawing.Point(161, 86);
            this.lblDOBRequired.Name = "lblDOBRequired";
            this.lblDOBRequired.Size = new System.Drawing.Size(21, 25);
            this.lblDOBRequired.TabIndex = 49;
            this.lblDOBRequired.Text = "*";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(161, 39);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(21, 25);
            this.lblNameRequired.TabIndex = 48;
            this.lblNameRequired.Text = "*";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(71, 89);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(60, 12);
            this.lblDateOfBirth.TabIndex = 45;
            this.lblDateOfBirth.Text = "Customer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 12);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Employee";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblOrderID);
            this.tabPage2.Controls.Add(this.txtFreight);
            this.tabPage2.Controls.Add(this.lblOrderedDate);
            this.tabPage2.Controls.Add(this.lblRequiredDate);
            this.tabPage2.Controls.Add(this.lblCompanyName);
            this.tabPage2.Controls.Add(this.lblEmployeeName);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnDel);
            this.tabPage2.Controls.Add(this.btnShip);
            this.tabPage2.Controls.Add(this.dgvOrderDetail);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cboShippers);
            this.tabPage2.Controls.Add(this.dtpShippedDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgvOrder);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "주문 조회/관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(693, 101);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 12);
            this.lblOrderID.TabIndex = 107;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(797, 422);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(100, 21);
            this.txtFreight.TabIndex = 106;
            // 
            // lblOrderedDate
            // 
            this.lblOrderedDate.AutoSize = true;
            this.lblOrderedDate.Location = new System.Drawing.Point(795, 218);
            this.lblOrderedDate.Name = "lblOrderedDate";
            this.lblOrderedDate.Size = new System.Drawing.Size(0, 12);
            this.lblOrderedDate.TabIndex = 105;
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(795, 265);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(0, 12);
            this.lblRequiredDate.TabIndex = 104;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(795, 172);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(0, 12);
            this.lblCompanyName.TabIndex = 103;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(795, 125);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 12);
            this.lblEmployeeName.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(683, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 12);
            this.label12.TabIndex = 101;
            this.label12.Text = "Ordered Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 100;
            this.label5.Text = "Required Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 12);
            this.label7.TabIndex = 99;
            this.label7.Text = "Customer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 12);
            this.label11.TabIndex = 98;
            this.label11.Text = "Employee";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(823, 476);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(123, 32);
            this.btnDel.TabIndex = 97;
            this.btnDel.Text = "삭제하기";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnShip
            // 
            this.btnShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShip.Location = new System.Drawing.Point(687, 476);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(123, 32);
            this.btnShip.TabIndex = 96;
            this.btnShip.Text = "배송처리";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(7, 321);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 23;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(656, 201);
            this.dgvOrderDetail.TabIndex = 95;
            this.dgvOrderDetail.SelectionChanged += new System.EventHandler(this.dgvOrderDetail_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 94;
            this.label2.Text = "Shipper";
            // 
            // cboShippers
            // 
            this.cboShippers.FormattingEnabled = true;
            this.cboShippers.Location = new System.Drawing.Point(797, 344);
            this.cboShippers.Name = "cboShippers";
            this.cboShippers.Size = new System.Drawing.Size(147, 20);
            this.cboShippers.TabIndex = 93;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(797, 383);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(100, 21);
            this.dtpShippedDate.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(773, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 79;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 76;
            this.label6.Text = "Freight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(773, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(773, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 25);
            this.label9.TabIndex = 73;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 12);
            this.label10.TabIndex = 72;
            this.label10.Text = "Shipped Date";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(8, 101);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(655, 201);
            this.dgvOrder.TabIndex = 68;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.cboCustomers2);
            this.groupBox1.Controls.Add(this.cboEmployees2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 61);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "~";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(585, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(100, 21);
            this.dtpTo.TabIndex = 60;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(463, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 21);
            this.dtpFrom.TabIndex = 59;
            // 
            // cboCustomers2
            // 
            this.cboCustomers2.FormattingEnabled = true;
            this.cboCustomers2.Location = new System.Drawing.Point(170, 20);
            this.cboCustomers2.Name = "cboCustomers2";
            this.cboCustomers2.Size = new System.Drawing.Size(287, 20);
            this.cboCustomers2.TabIndex = 17;
            // 
            // cboEmployees2
            // 
            this.cboEmployees2.FormattingEnabled = true;
            this.cboEmployees2.Location = new System.Drawing.Point(17, 20);
            this.cboEmployees2.Name = "cboEmployees2";
            this.cboEmployees2.Size = new System.Drawing.Size(147, 20);
            this.cboEmployees2.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(756, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 26);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(861, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 26);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmOrder";
            this.Text = "주문관리";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.Label lblMaritalStatusRequired;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblDOBRequired;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnCartAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.Label lblOccupationRequired;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboShippers;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cboCustomers2;
        private System.Windows.Forms.ComboBox cboEmployees2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrderedDate;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Button btnCartDel;
        private System.Windows.Forms.Label lblOrderID;
    }
}