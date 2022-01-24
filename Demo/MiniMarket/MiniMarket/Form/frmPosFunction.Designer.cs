namespace MiniMarket
{
    partial class frmPosFunction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosFunction));
            this.pnOrderInformation = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongThanhTien = new System.Windows.Forms.TextBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDanhSachDonHang = new System.Windows.Forms.DataGridView();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToanDonHang = new System.Windows.Forms.Button();
            this.btnTaoMoiDonHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoMoiThongTinKhachHang = new System.Windows.Forms.Button();
            this.btnTimKiemThongTinKhachHang = new System.Windows.Forms.Button();
            this.txtSoDienThoaiKhachHang = new System.Windows.Forms.TextBox();
            this.txtHoTenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lsvDanhSachSanPham = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnOrderInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOrderInformation
            // 
            this.pnOrderInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnOrderInformation.BackColor = System.Drawing.Color.White;
            this.pnOrderInformation.Controls.Add(this.groupBox2);
            this.pnOrderInformation.Controls.Add(this.btnThanhToanDonHang);
            this.pnOrderInformation.Controls.Add(this.btnTaoMoiDonHang);
            this.pnOrderInformation.Controls.Add(this.groupBox1);
            this.pnOrderInformation.Controls.Add(this.label1);
            this.pnOrderInformation.Location = new System.Drawing.Point(12, 59);
            this.pnOrderInformation.Name = "pnOrderInformation";
            this.pnOrderInformation.Size = new System.Drawing.Size(465, 557);
            this.pnOrderInformation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongThanhTien);
            this.groupBox2.Controls.Add(this.btnThemSanPham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvDanhSachDonHang);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.txtMaSanPham);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 379);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đơn hàng";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongThanhTien.Location = new System.Drawing.Point(158, 336);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTongThanhTien.Size = new System.Drawing.Size(259, 32);
            this.txtTongThanhTien.TabIndex = 2;
            this.txtTongThanhTien.Text = "100000";
            this.txtTongThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.Indigo;
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.Location = new System.Drawing.Point(332, 21);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(85, 47);
            this.btnThemSanPham.TabIndex = 1;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.BtnThemSanPham_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng thành tiền";
            // 
            // dgvDanhSachDonHang
            // 
            this.dgvDanhSachDonHang.AllowUserToAddRows = false;
            this.dgvDanhSachDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSanPham,
            this.SoLuong,
            this.GiaBan});
            this.dgvDanhSachDonHang.Location = new System.Drawing.Point(9, 80);
            this.dgvDanhSachDonHang.MultiSelect = false;
            this.dgvDanhSachDonHang.Name = "dgvDanhSachDonHang";
            this.dgvDanhSachDonHang.ReadOnly = true;
            this.dgvDanhSachDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDonHang.Size = new System.Drawing.Size(408, 243);
            this.dgvDanhSachDonHang.TabIndex = 2;
            this.dgvDanhSachDonHang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvDanhSachDonHang_UserDeletingRow);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Enabled = false;
            this.txtTenSanPham.Location = new System.Drawing.Point(83, 48);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(242, 20);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(83, 23);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(242, 20);
            this.txtMaSanPham.TabIndex = 0;
            this.txtMaSanPham.TextChanged += new System.EventHandler(this.TxtMaSanPham_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // btnThanhToanDonHang
            // 
            this.btnThanhToanDonHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThanhToanDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanDonHang.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanDonHang.Location = new System.Drawing.Point(346, 511);
            this.btnThanhToanDonHang.Name = "btnThanhToanDonHang";
            this.btnThanhToanDonHang.Size = new System.Drawing.Size(100, 31);
            this.btnThanhToanDonHang.TabIndex = 1;
            this.btnThanhToanDonHang.Text = "Thanh toán";
            this.btnThanhToanDonHang.UseVisualStyleBackColor = false;
            this.btnThanhToanDonHang.Click += new System.EventHandler(this.BtnThanhToanDonHang_Click);
            // 
            // btnTaoMoiDonHang
            // 
            this.btnTaoMoiDonHang.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTaoMoiDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoiDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoiDonHang.Location = new System.Drawing.Point(209, 511);
            this.btnTaoMoiDonHang.Name = "btnTaoMoiDonHang";
            this.btnTaoMoiDonHang.Size = new System.Drawing.Size(122, 31);
            this.btnTaoMoiDonHang.TabIndex = 2;
            this.btnTaoMoiDonHang.Text = "Tạo mới đơn hàng";
            this.btnTaoMoiDonHang.UseVisualStyleBackColor = false;
            this.btnTaoMoiDonHang.Click += new System.EventHandler(this.BtnTaoMoiDonHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMoiThongTinKhachHang);
            this.groupBox1.Controls.Add(this.btnTimKiemThongTinKhachHang);
            this.groupBox1.Controls.Add(this.txtSoDienThoaiKhachHang);
            this.groupBox1.Controls.Add(this.txtHoTenKhachHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnTaoMoiThongTinKhachHang
            // 
            this.btnTaoMoiThongTinKhachHang.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTaoMoiThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoiThongTinKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoiThongTinKhachHang.Location = new System.Drawing.Point(332, 41);
            this.btnTaoMoiThongTinKhachHang.Name = "btnTaoMoiThongTinKhachHang";
            this.btnTaoMoiThongTinKhachHang.Size = new System.Drawing.Size(85, 23);
            this.btnTaoMoiThongTinKhachHang.TabIndex = 3;
            this.btnTaoMoiThongTinKhachHang.Text = "Tạo mới";
            this.btnTaoMoiThongTinKhachHang.UseVisualStyleBackColor = false;
            this.btnTaoMoiThongTinKhachHang.Click += new System.EventHandler(this.BtnTaoMoiThongTinKhachHang_Click);
            // 
            // btnTimKiemThongTinKhachHang
            // 
            this.btnTimKiemThongTinKhachHang.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiemThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemThongTinKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemThongTinKhachHang.Location = new System.Drawing.Point(332, 17);
            this.btnTimKiemThongTinKhachHang.Name = "btnTimKiemThongTinKhachHang";
            this.btnTimKiemThongTinKhachHang.Size = new System.Drawing.Size(85, 23);
            this.btnTimKiemThongTinKhachHang.TabIndex = 3;
            this.btnTimKiemThongTinKhachHang.Text = "Tìm kiếm";
            this.btnTimKiemThongTinKhachHang.UseVisualStyleBackColor = false;
            this.btnTimKiemThongTinKhachHang.Click += new System.EventHandler(this.BtnTimKiemThongTinKhachHang_Click);
            // 
            // txtSoDienThoaiKhachHang
            // 
            this.txtSoDienThoaiKhachHang.Location = new System.Drawing.Point(145, 19);
            this.txtSoDienThoaiKhachHang.Name = "txtSoDienThoaiKhachHang";
            this.txtSoDienThoaiKhachHang.Size = new System.Drawing.Size(181, 20);
            this.txtSoDienThoaiKhachHang.TabIndex = 2;
            this.txtSoDienThoaiKhachHang.Text = "0123456789";
            // 
            // txtHoTenKhachHang
            // 
            this.txtHoTenKhachHang.Location = new System.Drawing.Point(144, 43);
            this.txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            this.txtHoTenKhachHang.Size = new System.Drawing.Size(181, 20);
            this.txtHoTenKhachHang.TabIndex = 0;
            this.txtHoTenKhachHang.Text = "Khách hàng vãng lai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.lsvDanhSachSanPham);
            this.pnMenu.Controls.Add(this.label5);
            this.pnMenu.Location = new System.Drawing.Point(483, 59);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(825, 557);
            this.pnMenu.TabIndex = 0;
            // 
            // lsvDanhSachSanPham
            // 
            this.lsvDanhSachSanPham.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lsvDanhSachSanPham.GridLines = true;
            this.lsvDanhSachSanPham.LargeImageList = this.imgList;
            this.lsvDanhSachSanPham.Location = new System.Drawing.Point(15, 44);
            this.lsvDanhSachSanPham.MultiSelect = false;
            this.lsvDanhSachSanPham.Name = "lsvDanhSachSanPham";
            this.lsvDanhSachSanPham.Size = new System.Drawing.Size(773, 498);
            this.lsvDanhSachSanPham.TabIndex = 0;
            this.lsvDanhSachSanPham.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachSanPham.Click += new System.EventHandler(this.LsvDanhSachSanPham_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Product001.jpg");
            this.imgList.Images.SetKeyName(1, "Product002.jpg");
            this.imgList.Images.SetKeyName(2, "Product003.jpg");
            this.imgList.Images.SetKeyName(3, "Product004.jpg");
            this.imgList.Images.SetKeyName(4, "Product005.jpg");
            this.imgList.Images.SetKeyName(5, "Product006.jpg");
            this.imgList.Images.SetKeyName(6, "Product007.jpg");
            this.imgList.Images.SetKeyName(7, "Product008.jpg");
            this.imgList.Images.SetKeyName(8, "Product009.jpg");
            this.imgList.Images.SetKeyName(9, "Product010.jpg");
            this.imgList.Images.SetKeyName(10, "Product011.jpg");
            this.imgList.Images.SetKeyName(11, "Product012.jpg");
            this.imgList.Images.SetKeyName(12, "Product013.jpg");
            this.imgList.Images.SetKeyName(13, "Product014.jpg");
            this.imgList.Images.SetKeyName(14, "Product015.jpg");
            this.imgList.Images.SetKeyName(15, "Product016.jpg");
            this.imgList.Images.SetKeyName(16, "Product017.jpg");
            this.imgList.Images.SetKeyName(17, "Product018.jpg");
            this.imgList.Images.SetKeyName(18, "Product019.jpg");
            this.imgList.Images.SetKeyName(19, "Product020.jpg");
            this.imgList.Images.SetKeyName(20, "Product021.jpg");
            this.imgList.Images.SetKeyName(21, "Product022.jpg");
            this.imgList.Images.SetKeyName(22, "Product023.jpg");
            this.imgList.Images.SetKeyName(23, "Product024.jpg");
            this.imgList.Images.SetKeyName(24, "Product025.jpg");
            this.imgList.Images.SetKeyName(25, "Product026.jpg");
            this.imgList.Images.SetKeyName(26, "Product027.jpg");
            this.imgList.Images.SetKeyName(27, "Product028.jpg");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách sản phẩm";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mini-market POS app";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1233, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 80;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 80;
            // 
            // frmPosFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1320, 628);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnOrderInformation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPosFunction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPosFunction_Load);
            this.pnOrderInformation.ResumeLayout(false);
            this.pnOrderInformation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnOrderInformation;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoMoiThongTinKhachHang;
        private System.Windows.Forms.Button btnTimKiemThongTinKhachHang;
        private System.Windows.Forms.TextBox txtHoTenKhachHang;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToanDonHang;
        private System.Windows.Forms.Button btnTaoMoiDonHang;
        private System.Windows.Forms.TextBox txtTongThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhSachDonHang;
        private System.Windows.Forms.ListView lsvDanhSachSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.TextBox txtSoDienThoaiKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
    }
}