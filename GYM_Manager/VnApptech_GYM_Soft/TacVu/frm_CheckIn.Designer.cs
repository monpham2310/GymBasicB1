namespace VnApptech_GYM_Soft.TacVu
{
    partial class frm_CheckIn
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblcanhbaohethan = new System.Windows.Forms.Label();
            this.txtRemainTurn = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtPractice = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblMaThe = new DevExpress.XtraEditors.LabelControl();
            this.txtRemainDay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtExprireDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBirthday = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNumberTurn = new System.Windows.Forms.Label();
            this.grInOut = new DevExpress.XtraEditors.GroupControl();
            this.dgvHistoryInOut = new DevExpress.XtraGrid.GridControl();
            this.gvHistoryInOut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmahoivien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhoivien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiovao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer_Datetime = new System.Windows.Forms.Timer(this.components);
            this.timer_Reset = new System.Windows.Forms.Timer(this.components);
            this.lblNotice = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExprireDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInOut)).BeginInit();
            this.grInOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryInOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistoryInOut)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lblTime);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.pbAvatar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.lblcanhbaohethan);
            this.groupControl1.Controls.Add(this.txtRemainTurn);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtPractice);
            this.groupControl1.Controls.Add(this.txtBarcode);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cbClub);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtPackageName);
            this.groupControl1.Controls.Add(this.lblMaThe);
            this.groupControl1.Controls.Add(this.txtRemainDay);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtExprireDate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtBirthday);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtFullname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(709, 613);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin học viên";
            // 
            // lblTime
            // 
            this.lblTime.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTime.Location = new System.Drawing.Point(31, 79);
            this.lblTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(302, 46);
            this.lblTime.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblDate.Location = new System.Drawing.Point(138, 56);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 24);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "01/01/2015";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Location = new System.Drawing.Point(377, 56);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(322, 240);
            this.pbAvatar.TabIndex = 12;
            this.pbAvatar.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(364, 580);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(114, 19);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Số lần còn lại:";
            // 
            // lblcanhbaohethan
            // 
            this.lblcanhbaohethan.AutoSize = true;
            this.lblcanhbaohethan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblcanhbaohethan.Location = new System.Drawing.Point(114, 565);
            this.lblcanhbaohethan.Name = "lblcanhbaohethan";
            this.lblcanhbaohethan.Size = new System.Drawing.Size(0, 19);
            this.lblcanhbaohethan.TabIndex = 9;
            // 
            // txtRemainTurn
            // 
            this.txtRemainTurn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtRemainTurn.ForeColor = System.Drawing.Color.Blue;
            this.txtRemainTurn.Location = new System.Drawing.Point(484, 575);
            this.txtRemainTurn.Name = "txtRemainTurn";
            this.txtRemainTurn.ReadOnly = true;
            this.txtRemainTurn.Size = new System.Drawing.Size(215, 30);
            this.txtRemainTurn.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(9, 441);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(103, 19);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Tên môn tập";
            // 
            // txtPractice
            // 
            this.txtPractice.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtPractice.ForeColor = System.Drawing.Color.Black;
            this.txtPractice.Location = new System.Drawing.Point(138, 437);
            this.txtPractice.Name = "txtPractice";
            this.txtPractice.ReadOnly = true;
            this.txtPractice.Size = new System.Drawing.Size(561, 30);
            this.txtPractice.TabIndex = 10;
            // 
            // txtBarcode
            // 
            this.txtBarcode.ForeColor = System.Drawing.Color.Blue;
            this.txtBarcode.Location = new System.Drawing.Point(53, 210);
            this.txtBarcode.MaxLength = 20;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(278, 27);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(9, 396);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 19);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Câu lạc bộ";
            // 
            // cbClub
            // 
            this.cbClub.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClub.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClub.ForeColor = System.Drawing.Color.Blue;
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(138, 393);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(561, 31);
            this.cbClub.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(9, 486);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 19);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Tên gói tập";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtPackageName.ForeColor = System.Drawing.Color.Black;
            this.txtPackageName.Location = new System.Drawing.Point(138, 483);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.ReadOnly = true;
            this.txtPackageName.Size = new System.Drawing.Size(561, 30);
            this.txtPackageName.TabIndex = 6;
            // 
            // lblMaThe
            // 
            this.lblMaThe.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThe.LineColor = System.Drawing.Color.Red;
            this.lblMaThe.Location = new System.Drawing.Point(135, 176);
            this.lblMaThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMaThe.Name = "lblMaThe";
            this.lblMaThe.Size = new System.Drawing.Size(107, 29);
            this.lblMaThe.TabIndex = 0;
            this.lblMaThe.Text = " Mã Vạch";
            // 
            // txtRemainDay
            // 
            this.txtRemainDay.Location = new System.Drawing.Point(138, 575);
            this.txtRemainDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRemainDay.Name = "txtRemainDay";
            this.txtRemainDay.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemainDay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtRemainDay.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtRemainDay.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemainDay.Properties.Appearance.Options.UseFont = true;
            this.txtRemainDay.Properties.Appearance.Options.UseForeColor = true;
            this.txtRemainDay.Properties.ReadOnly = true;
            this.txtRemainDay.Size = new System.Drawing.Size(220, 30);
            this.txtRemainDay.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(9, 576);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số ngày còn lại";
            // 
            // txtExprireDate
            // 
            this.txtExprireDate.Location = new System.Drawing.Point(138, 529);
            this.txtExprireDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExprireDate.Name = "txtExprireDate";
            this.txtExprireDate.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtExprireDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtExprireDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtExprireDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtExprireDate.Properties.Appearance.Options.UseFont = true;
            this.txtExprireDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtExprireDate.Properties.ReadOnly = true;
            this.txtExprireDate.Size = new System.Drawing.Size(561, 30);
            this.txtExprireDate.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(9, 531);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày hết hạn";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(138, 347);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBirthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtBirthday.Properties.Appearance.Options.UseBackColor = true;
            this.txtBirthday.Properties.Appearance.Options.UseFont = true;
            this.txtBirthday.Properties.ReadOnly = true;
            this.txtBirthday.Size = new System.Drawing.Size(561, 30);
            this.txtBirthday.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(9, 351);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày Sinh";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(138, 301);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtFullname.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtFullname.Properties.Appearance.Options.UseBackColor = true;
            this.txtFullname.Properties.Appearance.Options.UseFont = true;
            this.txtFullname.Properties.Appearance.Options.UseForeColor = true;
            this.txtFullname.Properties.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(561, 30);
            this.txtFullname.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(9, 306);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Họ tên";
            // 
            // lblNumberTurn
            // 
            this.lblNumberTurn.AutoSize = true;
            this.lblNumberTurn.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNumberTurn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblNumberTurn.Location = new System.Drawing.Point(727, 425);
            this.lblNumberTurn.Name = "lblNumberTurn";
            this.lblNumberTurn.Size = new System.Drawing.Size(150, 18);
            this.lblNumberTurn.TabIndex = 5;
            this.lblNumberTurn.Text = "Số lượt trong ngày:";
            // 
            // grInOut
            // 
            this.grInOut.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grInOut.AppearanceCaption.Options.UseFont = true;
            this.grInOut.Controls.Add(this.dgvHistoryInOut);
            this.grInOut.Location = new System.Drawing.Point(727, 11);
            this.grInOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grInOut.Name = "grInOut";
            this.grInOut.Size = new System.Drawing.Size(490, 412);
            this.grInOut.TabIndex = 4;
            this.grInOut.Text = "Lịch sử ra vào";
            // 
            // dgvHistoryInOut
            // 
            this.dgvHistoryInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistoryInOut.Location = new System.Drawing.Point(2, 31);
            this.dgvHistoryInOut.MainView = this.gvHistoryInOut;
            this.dgvHistoryInOut.Name = "dgvHistoryInOut";
            this.dgvHistoryInOut.Size = new System.Drawing.Size(486, 379);
            this.dgvHistoryInOut.TabIndex = 3;
            this.dgvHistoryInOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistoryInOut});
            // 
            // gvHistoryInOut
            // 
            this.gvHistoryInOut.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstt,
            this.colmahoivien,
            this.coltenhoivien,
            this.colngaysinh,
            this.colgiovao,
            this.colgiora,
            this.gridColumn1});
            this.gvHistoryInOut.GridControl = this.dgvHistoryInOut;
            this.gvHistoryInOut.Name = "gvHistoryInOut";
            this.gvHistoryInOut.OptionsFind.AlwaysVisible = true;
            this.gvHistoryInOut.OptionsFind.ShowClearButton = false;
            this.gvHistoryInOut.OptionsFind.ShowCloseButton = false;
            this.gvHistoryInOut.OptionsFind.ShowFindButton = false;
            this.gvHistoryInOut.OptionsView.ShowAutoFilterRow = true;
            this.gvHistoryInOut.OptionsView.ShowGroupPanel = false;
            // 
            // colstt
            // 
            this.colstt.AppearanceCell.Options.UseTextOptions = true;
            this.colstt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // colmahoivien
            // 
            this.colmahoivien.AppearanceHeader.Options.UseTextOptions = true;
            this.colmahoivien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmahoivien.Caption = "Mã hội viên";
            this.colmahoivien.FieldName = "MaHoiVien";
            this.colmahoivien.Name = "colmahoivien";
            this.colmahoivien.OptionsColumn.AllowEdit = false;
            this.colmahoivien.Width = 121;
            // 
            // coltenhoivien
            // 
            this.coltenhoivien.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenhoivien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenhoivien.Caption = "Họ tên hội viên";
            this.coltenhoivien.FieldName = "TenHoiVien";
            this.coltenhoivien.Name = "coltenhoivien";
            this.coltenhoivien.OptionsColumn.AllowEdit = false;
            this.coltenhoivien.Visible = true;
            this.coltenhoivien.VisibleIndex = 2;
            this.coltenhoivien.Width = 121;
            // 
            // colngaysinh
            // 
            this.colngaysinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colngaysinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaysinh.Caption = "Ngày sinh";
            this.colngaysinh.FieldName = "NamSinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.OptionsColumn.AllowEdit = false;
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 3;
            this.colngaysinh.Width = 121;
            // 
            // colgiovao
            // 
            this.colgiovao.Caption = "Giờ vào";
            this.colgiovao.FieldName = "GioVao";
            this.colgiovao.Name = "colgiovao";
            this.colgiovao.OptionsColumn.AllowEdit = false;
            this.colgiovao.Visible = true;
            this.colgiovao.VisibleIndex = 4;
            // 
            // colgiora
            // 
            this.colgiora.Caption = "Giờ ra";
            this.colgiora.FieldName = "GioRa";
            this.colgiora.Name = "colgiora";
            this.colgiora.OptionsColumn.AllowEdit = false;
            this.colgiora.Visible = true;
            this.colgiora.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã vạch";
            this.gridColumn1.FieldName = "MaThe";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // timer_Datetime
            // 
            this.timer_Datetime.Interval = 1000;
            this.timer_Datetime.Tick += new System.EventHandler(this.timer_Datetime_Tick);
            // 
            // timer_Reset
            // 
            this.timer_Reset.Tick += new System.EventHandler(this.timer_Reset_Tick);
            // 
            // lblNotice
            // 
            this.lblNotice.AllowDrop = true;
            this.lblNotice.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblNotice.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNotice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNotice.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblNotice.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblNotice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNotice.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblNotice.Location = new System.Drawing.Point(727, 452);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(488, 172);
            this.lblNotice.TabIndex = 6;
            // 
            // frm_CheckIn
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 635);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.lblNumberTurn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grInOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_CheckIn";
            this.Text = "Checkin Mã vạch";
            this.Load += new System.EventHandler(this.frm_CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExprireDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInOut)).EndInit();
            this.grInOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryInOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistoryInOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private System.Windows.Forms.PictureBox pbAvatar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Label lblcanhbaohethan;
        private System.Windows.Forms.TextBox txtRemainTurn;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox txtPractice;
        private System.Windows.Forms.TextBox txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbClub;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtPackageName;
        private DevExpress.XtraEditors.LabelControl lblMaThe;
        private DevExpress.XtraEditors.TextEdit txtRemainDay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtExprireDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtBirthday;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFullname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label lblNumberTurn;
        private DevExpress.XtraEditors.GroupControl grInOut;
        private DevExpress.XtraGrid.GridControl dgvHistoryInOut;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistoryInOut;
        private DevExpress.XtraGrid.Columns.GridColumn colstt;
        private DevExpress.XtraGrid.Columns.GridColumn colmahoivien;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhoivien;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colgiovao;
        private DevExpress.XtraGrid.Columns.GridColumn colgiora;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Timer timer_Datetime;
        private System.Windows.Forms.Timer timer_Reset;
        private DevExpress.XtraEditors.LabelControl lblNotice;
    }
}