namespace VnApptech_GYM_Soft.TacVu
{
    partial class Frm_ChiTietHoiVien_Modify
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblerr = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_NamSinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.txt_MaThe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHV = new System.Windows.Forms.TextBox();
            this.lblmahoivien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_GoiTap = new System.Windows.Forms.Label();
            this.lbl_PhongTap = new System.Windows.Forms.Label();
            this.date_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.date_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.lbl_ConLai = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_GiamGia = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_NV = new System.Windows.Forms.Label();
            this.lbl_NVKD = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnluu,
            this.btnthoat,
            this.lblerr});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnluu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnluu
            // 
            this.btnluu.Caption = "Lưu";
            this.btnluu.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Save_Filled_32;
            this.btnluu.Id = 0;
            this.btnluu.Name = "btnluu";
            this.btnluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnluu_ItemClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "Thoát";
            this.btnthoat.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Exit_32;
            this.btnthoat.Id = 1;
            this.btnthoat.Name = "btnthoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblerr)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblerr
            // 
            this.lblerr.Caption = "hiển thị lỗi";
            this.lblerr.Id = 2;
            this.lblerr.Name = "lblerr";
            this.lblerr.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(738, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 405);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 405);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(215)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÔNG TIN CHI TIẾT HỘI VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Mail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_DienThoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.date_NamSinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rad_Nu);
            this.groupBox1.Controls.Add(this.rad_Nam);
            this.groupBox1.Controls.Add(this.txt_MaThe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenHV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaHV);
            this.groupBox1.Controls.Add(this.lblmahoivien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 378);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hội viên";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(20, 249);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(329, 109);
            this.txt_DiaChi.TabIndex = 37;
            this.txt_DiaChi.Text = "số nhà: 20/45, Đường Phạm Văn Thuận, Biên Hòa Đồng Nai";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(16, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Đại chỉ:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(148, 198);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.ReadOnly = true;
            this.txt_Mail.Size = new System.Drawing.Size(201, 27);
            this.txt_Mail.TabIndex = 35;
            this.txt_Mail.Text = "abc@gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(144, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Email:";
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(20, 145);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.ReadOnly = true;
            this.txt_DienThoai.Size = new System.Drawing.Size(110, 27);
            this.txt_DienThoai.TabIndex = 33;
            this.txt_DienThoai.Text = "1234567890";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(16, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Điện thoại:";
            // 
            // date_NamSinh
            // 
            this.date_NamSinh.Enabled = false;
            this.date_NamSinh.Location = new System.Drawing.Point(148, 145);
            this.date_NamSinh.Name = "date_NamSinh";
            this.date_NamSinh.Size = new System.Drawing.Size(201, 27);
            this.date_NamSinh.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(144, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(141, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giới tính (*):";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Enabled = false;
            this.rad_Nu.Location = new System.Drawing.Point(227, 94);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(48, 23);
            this.rad_Nu.TabIndex = 28;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Enabled = false;
            this.rad_Nam.Location = new System.Drawing.Point(148, 94);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(60, 23);
            this.rad_Nam.TabIndex = 27;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_MaThe
            // 
            this.txt_MaThe.Location = new System.Drawing.Point(20, 93);
            this.txt_MaThe.Name = "txt_MaThe";
            this.txt_MaThe.ReadOnly = true;
            this.txt_MaThe.Size = new System.Drawing.Size(110, 27);
            this.txt_MaThe.TabIndex = 24;
            this.txt_MaThe.Text = "1234567890";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã thẻ (*):";
            // 
            // txt_TenHV
            // 
            this.txt_TenHV.Location = new System.Drawing.Point(145, 43);
            this.txt_TenHV.Name = "txt_TenHV";
            this.txt_TenHV.ReadOnly = true;
            this.txt_TenHV.Size = new System.Drawing.Size(204, 27);
            this.txt_TenHV.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(129, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên hội viên (*):";
            // 
            // txt_MaHV
            // 
            this.txt_MaHV.Location = new System.Drawing.Point(20, 43);
            this.txt_MaHV.Name = "txt_MaHV";
            this.txt_MaHV.ReadOnly = true;
            this.txt_MaHV.Size = new System.Drawing.Size(110, 27);
            this.txt_MaHV.TabIndex = 20;
            // 
            // lblmahoivien
            // 
            this.lblmahoivien.AutoSize = true;
            this.lblmahoivien.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblmahoivien.Location = new System.Drawing.Point(16, 21);
            this.lblmahoivien.Name = "lblmahoivien";
            this.lblmahoivien.Size = new System.Drawing.Size(122, 19);
            this.lblmahoivien.TabIndex = 19;
            this.lblmahoivien.Text = "Mã hội viên (*):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_NVKD);
            this.groupBox2.Controls.Add(this.lbl_NV);
            this.groupBox2.Controls.Add(this.lbl_ThanhTien);
            this.groupBox2.Controls.Add(this.lbl_GiamGia);
            this.groupBox2.Controls.Add(this.lbl_DonGia);
            this.groupBox2.Controls.Add(this.lbl_ConLai);
            this.groupBox2.Controls.Add(this.date_NgayKT);
            this.groupBox2.Controls.Add(this.date_NgayBD);
            this.groupBox2.Controls.Add(this.lbl_PhongTap);
            this.groupBox2.Controls.Add(this.lbl_GoiTap);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(374, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 378);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin gói tập hiện tại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(6, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Giảm giá: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(6, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "Đơn giá: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(6, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "Còn lại: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(6, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ngày kết thúc: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ngày bắt đầu: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Phòng tập: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gói tập: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(6, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 19);
            this.label16.TabIndex = 27;
            this.label16.Text = "Thành tiền: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(6, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "Nhân viên: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(6, 341);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 19);
            this.label18.TabIndex = 29;
            this.label18.Text = "Nhân viên kinh doanh: ";
            // 
            // lbl_GoiTap
            // 
            this.lbl_GoiTap.AutoSize = true;
            this.lbl_GoiTap.Location = new System.Drawing.Point(118, 26);
            this.lbl_GoiTap.Name = "lbl_GoiTap";
            this.lbl_GoiTap.Size = new System.Drawing.Size(86, 19);
            this.lbl_GoiTap.TabIndex = 30;
            this.lbl_GoiTap.Text = "lbl_GoiTap";
            // 
            // lbl_PhongTap
            // 
            this.lbl_PhongTap.AutoSize = true;
            this.lbl_PhongTap.Location = new System.Drawing.Point(121, 61);
            this.lbl_PhongTap.Name = "lbl_PhongTap";
            this.lbl_PhongTap.Size = new System.Drawing.Size(107, 19);
            this.lbl_PhongTap.TabIndex = 31;
            this.lbl_PhongTap.Text = "lbl_PhongTap";
            // 
            // date_NgayBD
            // 
            this.date_NgayBD.Enabled = false;
            this.date_NgayBD.Location = new System.Drawing.Point(125, 93);
            this.date_NgayBD.Name = "date_NgayBD";
            this.date_NgayBD.Size = new System.Drawing.Size(201, 27);
            this.date_NgayBD.TabIndex = 38;
            // 
            // date_NgayKT
            // 
            this.date_NgayKT.Location = new System.Drawing.Point(125, 126);
            this.date_NgayKT.Name = "date_NgayKT";
            this.date_NgayKT.Size = new System.Drawing.Size(201, 27);
            this.date_NgayKT.TabIndex = 39;
            // 
            // lbl_ConLai
            // 
            this.lbl_ConLai.AutoSize = true;
            this.lbl_ConLai.Location = new System.Drawing.Point(121, 166);
            this.lbl_ConLai.Name = "lbl_ConLai";
            this.lbl_ConLai.Size = new System.Drawing.Size(83, 19);
            this.lbl_ConLai.TabIndex = 40;
            this.lbl_ConLai.Text = "lbl_ConLai";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Location = new System.Drawing.Point(121, 201);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(87, 19);
            this.lbl_DonGia.TabIndex = 41;
            this.lbl_DonGia.Text = "lbl_DonGia";
            // 
            // lbl_GiamGia
            // 
            this.lbl_GiamGia.AutoSize = true;
            this.lbl_GiamGia.Location = new System.Drawing.Point(121, 236);
            this.lbl_GiamGia.Name = "lbl_GiamGia";
            this.lbl_GiamGia.Size = new System.Drawing.Size(95, 19);
            this.lbl_GiamGia.TabIndex = 42;
            this.lbl_GiamGia.Text = "lbl_GiamGia";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(121, 271);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(111, 19);
            this.lbl_ThanhTien.TabIndex = 43;
            this.lbl_ThanhTien.Text = "lbl_ThanhTien";
            // 
            // lbl_NV
            // 
            this.lbl_NV.AutoSize = true;
            this.lbl_NV.Location = new System.Drawing.Point(121, 306);
            this.lbl_NV.Name = "lbl_NV";
            this.lbl_NV.Size = new System.Drawing.Size(56, 19);
            this.lbl_NV.TabIndex = 44;
            this.lbl_NV.Text = "lbl_NV";
            // 
            // lbl_NVKD
            // 
            this.lbl_NVKD.AutoSize = true;
            this.lbl_NVKD.Location = new System.Drawing.Point(187, 341);
            this.lbl_NVKD.Name = "lbl_NVKD";
            this.lbl_NVKD.Size = new System.Drawing.Size(76, 19);
            this.lbl_NVKD.TabIndex = 45;
            this.lbl_NVKD.Text = "lbl_NVKD";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(20, 198);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(110, 27);
            this.txt_MaHD.TabIndex = 39;
            this.txt_MaHD.Text = "1234567890";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(16, 176);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 19);
            this.label19.TabIndex = 38;
            this.label19.Text = "Hóa đơn";
            // 
            // Frm_ChiTietHoiVien_Modify
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ChiTietHoiVien_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChiTietHoiVien_Modify";
            this.Load += new System.EventHandler(this.Frm_ChiTietHoiVien_Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnluu;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private DevExpress.XtraBars.BarStaticItem lblerr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_NamSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.TextBox txt_MaThe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHV;
        private System.Windows.Forms.Label lblmahoivien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_NVKD;
        private System.Windows.Forms.Label lbl_NV;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_GiamGia;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_ConLai;
        private System.Windows.Forms.DateTimePicker date_NgayKT;
        private System.Windows.Forms.DateTimePicker date_NgayBD;
        private System.Windows.Forms.Label lbl_PhongTap;
        private System.Windows.Forms.Label lbl_GoiTap;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label19;
    }
}