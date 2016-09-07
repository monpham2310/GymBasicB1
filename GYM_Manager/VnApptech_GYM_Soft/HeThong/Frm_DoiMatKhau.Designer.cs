namespace VnApptech_GYM_Soft.HeThong
{
    partial class Frm_DoiMatKhau
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
            this.btndoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.btncaplaimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblerr = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.groupnguoidung = new DevExpress.XtraEditors.GroupControl();
            this.lblchonnguoidung = new System.Windows.Forms.Label();
            this.cbonguoidung = new System.Windows.Forms.ComboBox();
            this.txtlapmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnguoidung)).BeginInit();
            this.groupnguoidung.SuspendLayout();
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
            this.btndoimatkhau,
            this.btncaplaimatkhau,
            this.btnthoat,
            this.barButtonItem4,
            this.lblerr});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndoimatkhau, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btncaplaimatkhau, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Caption = "Đổi mật khẩu";
            this.btndoimatkhau.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Key_2_32;
            this.btndoimatkhau.Id = 0;
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndoimatkhau_ItemClick);
            // 
            // btncaplaimatkhau
            // 
            this.btncaplaimatkhau.Caption = "Cấp lại mật khẩu";
            this.btncaplaimatkhau.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Password_Filled_32;
            this.btncaplaimatkhau.Id = 1;
            this.btncaplaimatkhau.Name = "btncaplaimatkhau";
            this.btncaplaimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncaplaimatkhau_ItemClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "Thoát";
            this.btnthoat.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Exit_32;
            this.btnthoat.Id = 2;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthoat_ItemClick);
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
            this.lblerr.Caption = "<>";
            this.lblerr.Id = 4;
            this.lblerr.Name = "lblerr";
            this.lblerr.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(493, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 201);
            this.barDockControlBottom.Size = new System.Drawing.Size(493, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 161);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(493, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 161);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // groupnguoidung
            // 
            this.groupnguoidung.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupnguoidung.Appearance.Options.UseFont = true;
            this.groupnguoidung.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupnguoidung.AppearanceCaption.Options.UseFont = true;
            this.groupnguoidung.Controls.Add(this.lblchonnguoidung);
            this.groupnguoidung.Controls.Add(this.cbonguoidung);
            this.groupnguoidung.Controls.Add(this.txtlapmatkhaumoi);
            this.groupnguoidung.Controls.Add(this.label2);
            this.groupnguoidung.Controls.Add(this.txtmatkhaumoi);
            this.groupnguoidung.Controls.Add(this.label1);
            this.groupnguoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupnguoidung.Location = new System.Drawing.Point(0, 40);
            this.groupnguoidung.Name = "groupnguoidung";
            this.groupnguoidung.Size = new System.Drawing.Size(493, 161);
            this.groupnguoidung.TabIndex = 0;
            this.groupnguoidung.Text = "Người dùng hiện tại:";
            // 
            // lblchonnguoidung
            // 
            this.lblchonnguoidung.AutoSize = true;
            this.lblchonnguoidung.Location = new System.Drawing.Point(16, 43);
            this.lblchonnguoidung.Name = "lblchonnguoidung";
            this.lblchonnguoidung.Size = new System.Drawing.Size(139, 19);
            this.lblchonnguoidung.TabIndex = 5;
            this.lblchonnguoidung.Text = "Chọn người dùng:";
            // 
            // cbonguoidung
            // 
            this.cbonguoidung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbonguoidung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbonguoidung.FormattingEnabled = true;
            this.cbonguoidung.Location = new System.Drawing.Point(156, 40);
            this.cbonguoidung.Name = "cbonguoidung";
            this.cbonguoidung.Size = new System.Drawing.Size(321, 27);
            this.cbonguoidung.TabIndex = 0;
            // 
            // txtlapmatkhaumoi
            // 
            this.txtlapmatkhaumoi.Location = new System.Drawing.Point(156, 120);
            this.txtlapmatkhaumoi.Name = "txtlapmatkhaumoi";
            this.txtlapmatkhaumoi.PasswordChar = '#';
            this.txtlapmatkhaumoi.Size = new System.Drawing.Size(321, 27);
            this.txtlapmatkhaumoi.TabIndex = 2;
            this.txtlapmatkhaumoi.Leave += new System.EventHandler(this.txtlapmatkhaumoi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lập lại mật khẩu:";
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(156, 79);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '@';
            this.txtmatkhaumoi.Size = new System.Drawing.Size(321, 27);
            this.txtmatkhaumoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // Frm_DoiMatKhau
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 226);
            this.Controls.Add(this.groupnguoidung);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnguoidung)).EndInit();
            this.groupnguoidung.ResumeLayout(false);
            this.groupnguoidung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btndoimatkhau;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btncaplaimatkhau;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private DevExpress.XtraBars.BarStaticItem lblerr;
        private DevExpress.XtraEditors.GroupControl groupnguoidung;
        private System.Windows.Forms.Label lblchonnguoidung;
        private System.Windows.Forms.ComboBox cbonguoidung;
        private System.Windows.Forms.TextBox txtlapmatkhaumoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}