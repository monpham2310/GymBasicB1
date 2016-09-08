namespace VnApptech_GYM_Soft.HeThong
{
    partial class Frm_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvviewPermission = new System.Windows.Forms.DataGridView();
            this.colstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmachucnang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiatriquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colview = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coladd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colupdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coldelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvviewPermission
            // 
            this.dgvviewPermission.AllowUserToAddRows = false;
            this.dgvviewPermission.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvviewPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvviewPermission.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvviewPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvviewPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstt,
            this.colmachucnang,
            this.colmataikhoan,
            this.coltentaikhoan,
            this.colgiatriquyen,
            this.coltenquyen,
            this.colview,
            this.coladd,
            this.colupdate,
            this.coldelete});
            this.dgvviewPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvviewPermission.Location = new System.Drawing.Point(0, 56);
            this.dgvviewPermission.Margin = new System.Windows.Forms.Padding(4);
            this.dgvviewPermission.Name = "dgvviewPermission";
            this.dgvviewPermission.RowHeadersVisible = false;
            this.dgvviewPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvviewPermission.Size = new System.Drawing.Size(939, 244);
            this.dgvviewPermission.TabIndex = 0;
            // 
            // colstt
            // 
            this.colstt.DataPropertyName = "STT";
            this.colstt.HeaderText = "STT";
            this.colstt.Name = "colstt";
            this.colstt.ReadOnly = true;
            // 
            // colmachucnang
            // 
            this.colmachucnang.DataPropertyName = "MaChucNang";
            this.colmachucnang.HeaderText = "Mã chức năng";
            this.colmachucnang.Name = "colmachucnang";
            this.colmachucnang.Visible = false;
            // 
            // colmataikhoan
            // 
            this.colmataikhoan.DataPropertyName = "MaTaiKhoan";
            this.colmataikhoan.HeaderText = "MaTaiKhoan";
            this.colmataikhoan.Name = "colmataikhoan";
            this.colmataikhoan.Visible = false;
            // 
            // coltentaikhoan
            // 
            this.coltentaikhoan.DataPropertyName = "TenTaiKhoan";
            this.coltentaikhoan.HeaderText = "Tên tài khoản";
            this.coltentaikhoan.Name = "coltentaikhoan";
            this.coltentaikhoan.ReadOnly = true;
            this.coltentaikhoan.Width = 150;
            // 
            // colgiatriquyen
            // 
            this.colgiatriquyen.DataPropertyName = "GiaTriQuyen";
            this.colgiatriquyen.HeaderText = "Giá trị quyền";
            this.colgiatriquyen.Name = "colgiatriquyen";
            this.colgiatriquyen.Visible = false;
            // 
            // coltenquyen
            // 
            this.coltenquyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coltenquyen.DataPropertyName = "TenChucNang";
            this.coltenquyen.HeaderText = "Tên quyền";
            this.coltenquyen.Name = "coltenquyen";
            this.coltenquyen.ReadOnly = true;
            // 
            // colview
            // 
            this.colview.DataPropertyName = "View";
            this.colview.FalseValue = "0";
            this.colview.HeaderText = "View";
            this.colview.Name = "colview";
            this.colview.TrueValue = "1";
            // 
            // coladd
            // 
            this.coladd.DataPropertyName = "Add";
            this.coladd.FalseValue = "0";
            this.coladd.HeaderText = "Add";
            this.coladd.Name = "coladd";
            this.coladd.TrueValue = "1";
            // 
            // colupdate
            // 
            this.colupdate.DataPropertyName = "Update";
            this.colupdate.FalseValue = "0";
            this.colupdate.HeaderText = "Update";
            this.colupdate.Name = "colupdate";
            this.colupdate.TrueValue = "1";
            // 
            // coldelete
            // 
            this.coldelete.DataPropertyName = "Delete";
            this.coldelete.FalseValue = "0";
            this.coldelete.HeaderText = "Delete";
            this.coldelete.Name = "coldelete";
            this.coldelete.TrueValue = "1";
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
            this.btnSave,
            this.barStaticItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Glyph = global::VnApptech_GYM_Soft.Properties.Resources.Save_as_48;
            this.btnSave.Id = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Chọn loại quyền";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(939, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 300);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(939, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 244);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(939, 56);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 244);
            // 
            // Frm_PhanQuyen
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 321);
            this.Controls.Add(this.dgvviewPermission);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_PhanQuyen";
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvviewPermission;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmachucnang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmataikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltentaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiatriquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenquyen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colview;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coladd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colupdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldelete;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}