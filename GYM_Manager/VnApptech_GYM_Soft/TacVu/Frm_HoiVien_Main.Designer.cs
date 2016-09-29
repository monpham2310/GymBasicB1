namespace VnApptech_GYM_Soft.TacVu
{
    partial class Frm_HoiVien_Main
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
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btnupdate = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnxuatexcel = new DevExpress.XtraBars.BarButtonItem();
            this.btncaplaithe = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblerr = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.dgvHoiVienList = new DevExpress.XtraGrid.GridControl();
            this.gvMemberPackage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmavach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVienList)).BeginInit();
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
            this.btnadd,
            this.btnupdate,
            this.btndelete,
            this.btnxuatexcel,
            this.btnthoat,
            this.lblerr,
            this.btncaplaithe});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnadd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnupdate, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxuatexcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btncaplaithe, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // 
            // btnadd
            // 
            this.btnadd.Caption = "Thêm";
            this.btnadd.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Add_Folder_32;
            this.btnadd.Id = 1;
            this.btnadd.Name = "btnadd";
            // 
            // btnupdate
            // 
            this.btnupdate.Caption = "Sửa";
            this.btnupdate.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Updates_32;
            this.btnupdate.Id = 2;
            this.btnupdate.Name = "btnupdate";
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Xóa";
            this.btndelete.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Delete_32;
            this.btndelete.Id = 3;
            this.btndelete.Name = "btndelete";
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Caption = "Xuất Excel";
            this.btnxuatexcel.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.MS_Excel_Filled_32;
            this.btnxuatexcel.Id = 4;
            this.btnxuatexcel.Name = "btnxuatexcel";
            // 
            // btncaplaithe
            // 
            this.btncaplaithe.Caption = "Cấp lại thẻ";
            this.btncaplaithe.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Security_Checked_32;
            this.btncaplaithe.Id = 8;
            this.btncaplaithe.Name = "btncaplaithe";
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "Thoát";
            this.btnthoat.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Exit_32;
            this.btnthoat.Id = 5;
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
            this.lblerr.Id = 7;
            this.lblerr.Name = "lblerr";
            this.lblerr.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(840, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 322);
            this.barDockControlBottom.Size = new System.Drawing.Size(840, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 282);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(840, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 282);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // dgvHoiVienList
            // 
            this.dgvHoiVienList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoiVienList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoiVienList.Location = new System.Drawing.Point(0, 40);
            this.dgvHoiVienList.MainView = this.gvMemberPackage;
            this.dgvHoiVienList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoiVienList.MenuManager = this.barManager1;
            this.dgvHoiVienList.Name = "dgvHoiVienList";
            this.dgvHoiVienList.Size = new System.Drawing.Size(840, 282);
            this.dgvHoiVienList.TabIndex = 15;
            this.dgvHoiVienList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colsodienthoai});
            this.gvMemberPackage.GridControl = this.dgvHoiVienList;
            this.gvMemberPackage.Name = "gvMemberPackage";
            this.gvMemberPackage.OptionsView.ShowAutoFilterRow = true;
            this.gvMemberPackage.OptionsView.ShowGroupPanel = false;
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
            this.colstt.Width = 46;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Họ và tên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 153;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Ngày sinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 153;
            // 
            // colgioitinh
            // 
            this.colgioitinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colgioitinh.AppearanceHeader.Options.UseFont = true;
            this.colgioitinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colgioitinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgioitinh.Caption = "Giới tính";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.OptionsColumn.AllowEdit = false;
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 3;
            this.colgioitinh.Width = 153;
            // 
            // colmavach
            // 
            this.colmavach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmavach.AppearanceHeader.Options.UseFont = true;
            this.colmavach.AppearanceHeader.Options.UseTextOptions = true;
            this.colmavach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmavach.Caption = "Mã thẻ";
            this.colmavach.Name = "colmavach";
            this.colmavach.OptionsColumn.AllowEdit = false;
            this.colmavach.Visible = true;
            this.colmavach.VisibleIndex = 4;
            this.colmavach.Width = 153;
            // 
            // colsodienthoai
            // 
            this.colsodienthoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colsodienthoai.AppearanceHeader.Options.UseFont = true;
            this.colsodienthoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colsodienthoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsodienthoai.Caption = "Điện thoại";
            this.colsodienthoai.Name = "colsodienthoai";
            this.colsodienthoai.OptionsColumn.AllowEdit = false;
            this.colsodienthoai.Visible = true;
            this.colsodienthoai.VisibleIndex = 5;
            this.colsodienthoai.Width = 164;
            // 
            // Frm_HoiVien_Main
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 347);
            this.Controls.Add(this.dgvHoiVienList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_HoiVien_Main";
            this.Text = "Frm_HoiVien_Main";
            this.Load += new System.EventHandler(this.Frm_HoiVien_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVienList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMemberPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnrefresh;
        private DevExpress.XtraBars.BarButtonItem btnadd;
        private DevExpress.XtraBars.BarButtonItem btnupdate;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnxuatexcel;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem lblerr;
        private DevExpress.XtraGrid.GridControl dgvHoiVienList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMemberPackage;
        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colmavach;
        private DevExpress.XtraGrid.Columns.GridColumn colsodienthoai;
        private DevExpress.XtraBars.BarButtonItem btncaplaithe;
    }
}