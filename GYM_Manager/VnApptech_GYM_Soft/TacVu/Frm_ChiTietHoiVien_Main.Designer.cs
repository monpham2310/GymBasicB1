namespace VnApptech_GYM_Soft.TacVu
{
    partial class Frm_ChiTietHoiVien_Main
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
            this.btnrefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnupdate = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dgvChiTietHoiVienList = new DevExpress.XtraGrid.GridControl();
            this.gvMemberPackage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmavach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoiVienList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMemberPackage)).BeginInit();
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
            this.btnrefresh,
            this.btnupdate,
            this.btndelete,
            this.btnexit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnrefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnupdate, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Caption = "Nạp lại";
            this.btnrefresh.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Refresh_32;
            this.btnrefresh.Id = 0;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrefresh_ItemClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Caption = "Sửa";
            this.btnupdate.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Updates_32;
            this.btnupdate.Id = 2;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnupdate_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Xóa";
            this.btndelete.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Delete_32;
            this.btndelete.Id = 3;
            this.btndelete.Name = "btndelete";
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btnexit
            // 
            this.btnexit.Caption = "Thoát";
            this.btnexit.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Exit_32;
            this.btnexit.Id = 4;
            this.btnexit.Name = "btnexit";
            this.btnexit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1074, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Size = new System.Drawing.Size(1074, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1074, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 405);
            // 
            // dgvChiTietHoiVienList
            // 
            this.dgvChiTietHoiVienList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHoiVienList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietHoiVienList.Location = new System.Drawing.Point(0, 40);
            this.dgvChiTietHoiVienList.MainView = this.gvMemberPackage;
            this.dgvChiTietHoiVienList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietHoiVienList.MenuManager = this.barManager1;
            this.dgvChiTietHoiVienList.Name = "dgvChiTietHoiVienList";
            this.dgvChiTietHoiVienList.Size = new System.Drawing.Size(1074, 405);
            this.dgvChiTietHoiVienList.TabIndex = 16;
            this.dgvChiTietHoiVienList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMemberPackage});
            // 
            // gvMemberPackage
            // 
            this.gvMemberPackage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstt,
            this.gridColumn1,
            this.gridColumn2,
            this.colgioitinh,
            this.colmavach,
            this.colsodienthoai,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gvMemberPackage.GridControl = this.dgvChiTietHoiVienList;
            this.gvMemberPackage.Name = "gvMemberPackage";
            this.gvMemberPackage.OptionsView.ShowAutoFilterRow = true;
            this.gvMemberPackage.OptionsView.ShowGroupPanel = false;
            this.gvMemberPackage.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvMemberPackage_RowClick);
            // 
            // colstt
            // 
            this.colstt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colstt.AppearanceCell.Options.UseFont = true;
            this.colstt.AppearanceCell.Options.UseTextOptions = true;
            this.colstt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colstt.AppearanceHeader.Options.UseFont = true;
            this.colstt.AppearanceHeader.Options.UseTextOptions = true;
            this.colstt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstt.Caption = "STT";
            this.colstt.FieldName = "STT";
            this.colstt.Name = "colstt";
            this.colstt.OptionsColumn.AllowEdit = false;
            this.colstt.Visible = true;
            this.colstt.VisibleIndex = 0;
            this.colstt.Width = 37;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Họ Tên";
            this.gridColumn1.FieldName = "HoTen";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Phòng";
            this.gridColumn2.FieldName = "TenPhongTap";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 87;
            // 
            // colgioitinh
            // 
            this.colgioitinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colgioitinh.AppearanceHeader.Options.UseFont = true;
            this.colgioitinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colgioitinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgioitinh.Caption = "Bắt Đầu";
            this.colgioitinh.FieldName = "NgayBatDau";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.OptionsColumn.AllowEdit = false;
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 6;
            this.colgioitinh.Width = 91;
            // 
            // colmavach
            // 
            this.colmavach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmavach.AppearanceHeader.Options.UseFont = true;
            this.colmavach.AppearanceHeader.Options.UseTextOptions = true;
            this.colmavach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmavach.Caption = "Mã Thẻ";
            this.colmavach.FieldName = "MaThe";
            this.colmavach.Name = "colmavach";
            this.colmavach.OptionsColumn.AllowEdit = false;
            this.colmavach.Visible = true;
            this.colmavach.VisibleIndex = 2;
            this.colmavach.Width = 88;
            // 
            // colsodienthoai
            // 
            this.colsodienthoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colsodienthoai.AppearanceHeader.Options.UseFont = true;
            this.colsodienthoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colsodienthoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsodienthoai.Caption = "Điện thoại";
            this.colsodienthoai.FieldName = "DienThoai";
            this.colsodienthoai.Name = "colsodienthoai";
            this.colsodienthoai.OptionsColumn.AllowEdit = false;
            this.colsodienthoai.Visible = true;
            this.colsodienthoai.VisibleIndex = 3;
            this.colsodienthoai.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Còn Lại";
            this.gridColumn3.FieldName = "NgayConLai";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 53;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Kết Thúc";
            this.gridColumn4.FieldName = "NgayHetHan";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 84;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Gói Tập";
            this.gridColumn5.FieldName = "TenGoiTap";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 93;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Giá";
            this.gridColumn6.FieldName = "DonGia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            this.gridColumn6.Width = 70;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Giảm";
            this.gridColumn7.FieldName = "GiamGia";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            this.gridColumn7.Width = 70;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Thành Tiền";
            this.gridColumn8.FieldName = "ThanhTien";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 11;
            this.gridColumn8.Width = 83;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Nhân Viên";
            this.gridColumn9.FieldName = "NhanVienTruc";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 12;
            this.gridColumn9.Width = 90;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "Kinh Doanh";
            this.gridColumn10.FieldName = "NhanVienKD";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 13;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Mã HD";
            this.gridColumn11.FieldName = "MaHD";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Mã HV";
            this.gridColumn12.FieldName = "MaHV";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Email";
            this.gridColumn13.FieldName = "Email";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Địa Chỉ";
            this.gridColumn14.FieldName = "DiaChi";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Năm Sinh";
            this.gridColumn15.FieldName = "NamSinh";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "GioiTinh";
            this.gridColumn16.FieldName = "GioiTinh";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // Frm_ChiTietHoiVien_Main
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 468);
            this.Controls.Add(this.dgvChiTietHoiVienList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ChiTietHoiVien_Main";
            this.Text = "Frm_ChiTietHoiVien_Main";
            this.Load += new System.EventHandler(this.Frm_ChiTietHoiVien_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoiVienList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMemberPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnrefresh;
        private DevExpress.XtraBars.BarButtonItem btnupdate;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl dgvChiTietHoiVienList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMemberPackage;
        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colmavach;
        private DevExpress.XtraGrid.Columns.GridColumn colsodienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    }
}