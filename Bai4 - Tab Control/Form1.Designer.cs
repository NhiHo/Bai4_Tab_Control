namespace Bai4___Tab_Control
{
    partial class Form1
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
            this.tabKhoa = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnTaoMoiKhoa = new System.Windows.Forms.Button();
            this.btnCapNhatKhoa = new System.Windows.Forms.Button();
            this.btnLuuKhoa = new System.Windows.Forms.Button();
            this.btnHienThiKhoa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabLop = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnTaoMoiLop = new System.Windows.Forms.Button();
            this.btnCapNhatLop = new System.Windows.Forms.Button();
            this.btnLuuLop = new System.Windows.Forms.Button();
            this.btnHienThiLop = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabSV = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnTaoMoiSV = new System.Windows.Forms.Button();
            this.btnCapNhatSV = new System.Windows.Forms.Button();
            this.btnLuuSV = new System.Windows.Forms.Button();
            this.btnHienThiSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.cboTenLopSV = new System.Windows.Forms.ComboBox();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabKhoa.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabLop.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabSV.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKhoa);
            this.tabControl1.Controls.Add(this.tabLop);
            this.tabControl1.Controls.Add(this.tabSV);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKhoa
            // 
            this.tabKhoa.Controls.Add(this.panel6);
            this.tabKhoa.Controls.Add(this.panel5);
            this.tabKhoa.Controls.Add(this.panel4);
            this.tabKhoa.Location = new System.Drawing.Point(4, 22);
            this.tabKhoa.Name = "tabKhoa";
            this.tabKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoa.Size = new System.Drawing.Size(475, 300);
            this.tabKhoa.TabIndex = 0;
            this.tabKhoa.Text = "Khoa";
            this.tabKhoa.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvKhoa);
            this.panel6.Location = new System.Drawing.Point(4, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(468, 176);
            this.panel6.TabIndex = 2;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(4, 4);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(460, 168);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXoaKhoa);
            this.panel5.Controls.Add(this.btnTaoMoiKhoa);
            this.panel5.Controls.Add(this.btnCapNhatKhoa);
            this.panel5.Controls.Add(this.btnLuuKhoa);
            this.panel5.Controls.Add(this.btnHienThiKhoa);
            this.panel5.Location = new System.Drawing.Point(309, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 111);
            this.panel5.TabIndex = 1;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(40, 83);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhoa.TabIndex = 8;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnTaoMoiKhoa
            // 
            this.btnTaoMoiKhoa.Location = new System.Drawing.Point(3, 8);
            this.btnTaoMoiKhoa.Name = "btnTaoMoiKhoa";
            this.btnTaoMoiKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoiKhoa.TabIndex = 9;
            this.btnTaoMoiKhoa.Text = "Tạo Mới";
            this.btnTaoMoiKhoa.UseVisualStyleBackColor = true;
            this.btnTaoMoiKhoa.Click += new System.EventHandler(this.btnTaoMoiKhoa_Click);
            // 
            // btnCapNhatKhoa
            // 
            this.btnCapNhatKhoa.Location = new System.Drawing.Point(3, 45);
            this.btnCapNhatKhoa.Name = "btnCapNhatKhoa";
            this.btnCapNhatKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatKhoa.TabIndex = 7;
            this.btnCapNhatKhoa.Text = "Cập Nhật";
            this.btnCapNhatKhoa.UseVisualStyleBackColor = true;
            this.btnCapNhatKhoa.Click += new System.EventHandler(this.btnCapNhatKhoa_Click);
            // 
            // btnLuuKhoa
            // 
            this.btnLuuKhoa.Location = new System.Drawing.Point(84, 8);
            this.btnLuuKhoa.Name = "btnLuuKhoa";
            this.btnLuuKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnLuuKhoa.TabIndex = 6;
            this.btnLuuKhoa.Text = "Lưu";
            this.btnLuuKhoa.UseVisualStyleBackColor = true;
            this.btnLuuKhoa.Click += new System.EventHandler(this.btnLuuKhoa_Click);
            // 
            // btnHienThiKhoa
            // 
            this.btnHienThiKhoa.Location = new System.Drawing.Point(84, 45);
            this.btnHienThiKhoa.Name = "btnHienThiKhoa";
            this.btnHienThiKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnHienThiKhoa.TabIndex = 5;
            this.btnHienThiKhoa.Text = "Hiển Thị";
            this.btnHienThiKhoa.UseVisualStyleBackColor = true;
            this.btnHienThiKhoa.Click += new System.EventHandler(this.btnHienThiKhoa_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.txtMaKhoa);
            this.panel4.Controls.Add(this.txtTenKhoa);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 111);
            this.panel4.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(65, 64);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(196, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(65, 8);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(196, 20);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(65, 37);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(196, 20);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Khoa";
            // 
            // tabLop
            // 
            this.tabLop.Controls.Add(this.panel9);
            this.tabLop.Controls.Add(this.panel8);
            this.tabLop.Controls.Add(this.panel7);
            this.tabLop.Location = new System.Drawing.Point(4, 22);
            this.tabLop.Name = "tabLop";
            this.tabLop.Padding = new System.Windows.Forms.Padding(3);
            this.tabLop.Size = new System.Drawing.Size(475, 300);
            this.tabLop.TabIndex = 1;
            this.tabLop.Text = "Lớp";
            this.tabLop.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvLop);
            this.panel9.Location = new System.Drawing.Point(4, 121);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(468, 176);
            this.panel9.TabIndex = 2;
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(4, 4);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(460, 168);
            this.dgvLop.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnXoaLop);
            this.panel8.Controls.Add(this.btnTaoMoiLop);
            this.panel8.Controls.Add(this.btnCapNhatLop);
            this.panel8.Controls.Add(this.btnLuuLop);
            this.panel8.Controls.Add(this.btnHienThiLop);
            this.panel8.Location = new System.Drawing.Point(309, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(163, 111);
            this.panel8.TabIndex = 1;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(40, 83);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLop.TabIndex = 13;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoiLop
            // 
            this.btnTaoMoiLop.Location = new System.Drawing.Point(3, 8);
            this.btnTaoMoiLop.Name = "btnTaoMoiLop";
            this.btnTaoMoiLop.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoiLop.TabIndex = 14;
            this.btnTaoMoiLop.Text = "Tạo Mới";
            this.btnTaoMoiLop.UseVisualStyleBackColor = true;
            this.btnTaoMoiLop.Click += new System.EventHandler(this.btnTaoMoiLop_Click);
            // 
            // btnCapNhatLop
            // 
            this.btnCapNhatLop.Location = new System.Drawing.Point(3, 45);
            this.btnCapNhatLop.Name = "btnCapNhatLop";
            this.btnCapNhatLop.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatLop.TabIndex = 12;
            this.btnCapNhatLop.Text = "Cập Nhật";
            this.btnCapNhatLop.UseVisualStyleBackColor = true;
            // 
            // btnLuuLop
            // 
            this.btnLuuLop.Location = new System.Drawing.Point(84, 8);
            this.btnLuuLop.Name = "btnLuuLop";
            this.btnLuuLop.Size = new System.Drawing.Size(75, 23);
            this.btnLuuLop.TabIndex = 11;
            this.btnLuuLop.Text = "Lưu";
            this.btnLuuLop.UseVisualStyleBackColor = true;
            // 
            // btnHienThiLop
            // 
            this.btnHienThiLop.Location = new System.Drawing.Point(84, 45);
            this.btnHienThiLop.Name = "btnHienThiLop";
            this.btnHienThiLop.Size = new System.Drawing.Size(75, 23);
            this.btnHienThiLop.TabIndex = 10;
            this.btnHienThiLop.Text = "Hiển Thị";
            this.btnHienThiLop.UseVisualStyleBackColor = true;
            this.btnHienThiLop.Click += new System.EventHandler(this.btnHienThiLop_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTenLop);
            this.panel7.Controls.Add(this.txtKhoa);
            this.panel7.Controls.Add(this.cboKhoa);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 111);
            this.panel7.TabIndex = 0;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(66, 59);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(201, 20);
            this.txtTenLop.TabIndex = 5;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(66, 32);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(201, 20);
            this.txtKhoa.TabIndex = 4;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(66, 5);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(201, 21);
            this.cboKhoa.TabIndex = 3;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Khóa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khoa";
            // 
            // tabSV
            // 
            this.tabSV.Controls.Add(this.panel3);
            this.tabSV.Controls.Add(this.panel2);
            this.tabSV.Controls.Add(this.panel1);
            this.tabSV.Location = new System.Drawing.Point(4, 22);
            this.tabSV.Name = "tabSV";
            this.tabSV.Size = new System.Drawing.Size(475, 300);
            this.tabSV.TabIndex = 2;
            this.tabSV.Text = "Sinh Viên";
            this.tabSV.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSV);
            this.panel3.Location = new System.Drawing.Point(4, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 176);
            this.panel3.TabIndex = 2;
            // 
            // dgvSV
            // 
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(4, 4);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.Size = new System.Drawing.Size(460, 168);
            this.dgvSV.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoaSV);
            this.panel2.Controls.Add(this.btnTaoMoiSV);
            this.panel2.Controls.Add(this.btnCapNhatSV);
            this.panel2.Controls.Add(this.btnLuuSV);
            this.panel2.Controls.Add(this.btnHienThiSV);
            this.panel2.Location = new System.Drawing.Point(309, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 111);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(84, 83);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(84, 45);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSV.TabIndex = 3;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoiSV
            // 
            this.btnTaoMoiSV.Location = new System.Drawing.Point(3, 83);
            this.btnTaoMoiSV.Name = "btnTaoMoiSV";
            this.btnTaoMoiSV.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoiSV.TabIndex = 4;
            this.btnTaoMoiSV.Text = "Tạo Mới";
            this.btnTaoMoiSV.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSV
            // 
            this.btnCapNhatSV.Location = new System.Drawing.Point(3, 45);
            this.btnCapNhatSV.Name = "btnCapNhatSV";
            this.btnCapNhatSV.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatSV.TabIndex = 2;
            this.btnCapNhatSV.Text = "Cập Nhật";
            this.btnCapNhatSV.UseVisualStyleBackColor = true;
            // 
            // btnLuuSV
            // 
            this.btnLuuSV.Location = new System.Drawing.Point(84, 8);
            this.btnLuuSV.Name = "btnLuuSV";
            this.btnLuuSV.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSV.TabIndex = 1;
            this.btnLuuSV.Text = "Lưu";
            this.btnLuuSV.UseVisualStyleBackColor = true;
            // 
            // btnHienThiSV
            // 
            this.btnHienThiSV.Location = new System.Drawing.Point(3, 8);
            this.btnHienThiSV.Name = "btnHienThiSV";
            this.btnHienThiSV.Size = new System.Drawing.Size(75, 23);
            this.btnHienThiSV.TabIndex = 0;
            this.btnHienThiSV.Text = "Hiển Thị";
            this.btnHienThiSV.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtmNgaySinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rdoNu);
            this.panel1.Controls.Add(this.rdoNam);
            this.panel1.Controls.Add(this.cboTenLopSV);
            this.panel1.Controls.Add(this.txtHoTenSV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 111);
            this.panel1.TabIndex = 0;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.Location = new System.Drawing.Point(67, 81);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtmNgaySinh.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Sinh";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(228, 57);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 7;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(66, 57);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 6;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // cboTenLopSV
            // 
            this.cboTenLopSV.FormattingEnabled = true;
            this.cboTenLopSV.Location = new System.Drawing.Point(66, 5);
            this.cboTenLopSV.Name = "cboTenLopSV";
            this.cboTenLopSV.Size = new System.Drawing.Size(201, 21);
            this.cboTenLopSV.TabIndex = 5;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(66, 32);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(201, 20);
            this.txtHoTenSV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKhoa.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabLop.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabSV.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKhoa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabLop;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tabSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnTaoMoiSV;
        private System.Windows.Forms.Button btnCapNhatSV;
        private System.Windows.Forms.Button btnLuuSV;
        private System.Windows.Forms.Button btnHienThiSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.ComboBox cboTenLopSV;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnTaoMoiKhoa;
        private System.Windows.Forms.Button btnCapNhatKhoa;
        private System.Windows.Forms.Button btnLuuKhoa;
        private System.Windows.Forms.Button btnHienThiKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnTaoMoiLop;
        private System.Windows.Forms.Button btnCapNhatLop;
        private System.Windows.Forms.Button btnLuuLop;
        private System.Windows.Forms.Button btnHienThiLop;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;

    }
}

