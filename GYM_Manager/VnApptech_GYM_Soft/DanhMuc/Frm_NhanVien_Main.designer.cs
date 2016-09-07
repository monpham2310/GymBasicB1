namespace VnApptech_GYM_Soft.DanhMuc
{
    partial class Frm_NhanVien_Main
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
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmanhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltendangnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmataikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltentaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_DSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnnaplai = new DevExpress.XtraBars.BarButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnxuatexcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
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
            this.colstt.Width = 50;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstt,
            this.colmanhanvien,
            this.coltennhanvien,
            this.colphai,
            this.colnamsinh,
            this.coldienthoai,
            this.coltendangnhap,
            this.colmataikhoan,
            this.coltentaikhoan});
            this.gridView1.GridControl = this.gv_DSNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colmanhanvien
            // 
            this.colmanhanvien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmanhanvien.AppearanceCell.Options.UseFont = true;
            this.colmanhanvien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colmanhanvien.AppearanceHeader.Options.UseFont = true;
            this.colmanhanvien.AppearanceHeader.Options.UseTextOptions = true;
            this.colmanhanvien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmanhanvien.Caption = "Mã loại vé";
            this.colmanhanvien.FieldName = "MaNhanVien";
            this.colmanhanvien.Name = "colmanhanvien";
            this.colmanhanvien.OptionsColumn.AllowEdit = false;
            this.colmanhanvien.Width = 122;
            // 
            // coltennhanvien
            // 
            this.coltennhanvien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltennhanvien.AppearanceCell.Options.UseFont = true;
            this.coltennhanvien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coltennhanvien.AppearanceHeader.Options.UseFont = true;
            this.coltennhanvien.AppearanceHeader.Options.UseTextOptions = true;
            this.coltennhanvien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltennhanvien.Caption = "Tên Nhân viên";
            this.coltennhanvien.FieldName = "TenNhanVien";
            this.coltennhanvien.Name = "coltennhanvien";
            this.coltennhanvien.OptionsColumn.AllowEdit = false;
            this.coltennhanvien.Visible = true;
            this.coltennhanvien.VisibleIndex = 1;
            this.coltennhanvien.Width = 187;
            // 
            // colphai
            // 
            this.colphai.Caption = "Phái";
            this.colphai.FieldName = "GioiTinh";
            this.colphai.Name = "colphai";
            this.colphai.Visible = true;
            this.colphai.VisibleIndex = 2;
            // 
            // colnamsinh
            // 
            this.colnamsinh.Caption = "Năm sinh";
            this.colnamsinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colnamsinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colnamsinh.FieldName = "NamSinh";
            this.colnamsinh.Name = "colnamsinh";
            this.colnamsinh.Visible = true;
            this.colnamsinh.VisibleIndex = 3;
            // 
            // coldienthoai
            // 
            this.coldienthoai.Caption = "Điện thoại";
            this.coldienthoai.FieldName = "DienThoai";
            this.coldienthoai.Name = "coldienthoai";
            this.coldienthoai.Visible = true;
            this.coldienthoai.VisibleIndex = 4;
            // 
            // coltendangnhap
            // 
            this.coltendangnhap.Caption = "Tên đăng nhập";
            this.coltendangnhap.FieldName = "TenDangNhap";
            this.coltendangnhap.Name = "coltendangnhap";
            this.coltendangnhap.Visible = true;
            this.coltendangnhap.VisibleIndex = 5;
            // 
            // colmataikhoan
            // 
            this.colmataikhoan.Caption = "Mã tài khoản";
            this.colmataikhoan.FieldName = "mataikhoan";
            this.colmataikhoan.Name = "colmataikhoan";
            // 
            // coltentaikhoan
            // 
            this.coltentaikhoan.Caption = "Loại nhân viên";
            this.coltentaikhoan.FieldName = "tentaikhoan";
            this.coltentaikhoan.Name = "coltentaikhoan";
            this.coltentaikhoan.Visible = true;
            this.coltentaikhoan.VisibleIndex = 6;
            // 
            // gv_DSNhanVien
            // 
            this.gv_DSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_DSNhanVien.Location = new System.Drawing.Point(0, 40);
            this.gv_DSNhanVien.MainView = this.gridView1;
            this.gv_DSNhanVien.MenuManager = this.barManager1;
            this.gv_DSNhanVien.Name = "gv_DSNhanVien";
            this.gv_DSNhanVien.Size = new System.Drawing.Size(1024, 395);
            this.gv_DSNhanVien.TabIndex = 5;
            this.gv_DSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
        
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
            this.btnnaplai,
            this.btnxoa,
            this.btnsua,
            this.btnxuatexcel,
            this.btnthoat,
            this.barStaticItem1,
            this.barButtonItem1,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnnaplai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxuatexcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nạp lại";
            this.barButtonItem1.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Refresh_32;
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnnaplai
            // 
            this.btnnaplai.Caption = "Thêm";
            this.btnnaplai.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Add_Folder_32;
            this.btnnaplai.Id = 0;
            this.btnnaplai.Name = "btnnaplai";
            this.btnnaplai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnaplai_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa";
            this.btnsua.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Updates_32;
            this.btnsua.Id = 2;
            this.btnsua.Name = "btnsua";
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa";
            this.btnxoa.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Delete_32;
            this.btnxoa.Id = 1;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Caption = "Xuất Excel";
            this.btnxuatexcel.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.MS_Excel_Filled_32;
            this.btnxuatexcel.Id = 3;
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxuatexcel_ItemClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "Thoát";
            this.btnthoat.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Exit_32;
            this.btnthoat.Id = 4;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthoat_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = 7;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Hiển thị số lượng";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1024, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 435);
            this.barDockControlBottom.Size = new System.Drawing.Size(1024, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 395);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1024, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 395);
            // 
            // Frm_NhanVien_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 460);
            this.Controls.Add(this.gv_DSNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NhanVien_Main";
            this.Text = "Frm_NhanVien_Main";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmanhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colphai;
        private DevExpress.XtraGrid.Columns.GridColumn colnamsinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colmataikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn coltentaikhoan;
        private DevExpress.XtraGrid.GridControl gv_DSNhanVien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnnaplai;
        private DevExpress.XtraBars.BarButtonItem btnsua;
        private DevExpress.XtraBars.BarButtonItem btnxoa;
        private DevExpress.XtraBars.BarButtonItem btnxuatexcel;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn coltendangnhap;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;

    }
}