namespace VnApptech_GYM_Soft.HeThong
{
    partial class Frm_ThongTin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCelPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblVanPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblCelPhone);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblDienThoai);
            this.panel1.Controls.Add(this.lblVanPhong);
            this.panel1.Location = new System.Drawing.Point(3, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 144);
            this.panel1.TabIndex = 0;
            // 
            // lblCelPhone
            // 
            this.lblCelPhone.AutoSize = true;
            this.lblCelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCelPhone.Location = new System.Drawing.Point(9, 107);
            this.lblCelPhone.Name = "lblCelPhone";
            this.lblCelPhone.Size = new System.Drawing.Size(355, 19);
            this.lblCelPhone.TabIndex = 3;
            this.lblCelPhone.Text = "CellPhone HotLine: 0917286162 - 091 264 2826";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEmail.Location = new System.Drawing.Point(9, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(230, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email: info@vnapptech.com.vn";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDienThoai.Location = new System.Drawing.Point(9, 80);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(202, 19);
            this.lblDienThoai.TabIndex = 1;
            this.lblDienThoai.Text = "điện thoại : (0613) 951618";
            // 
            // lblVanPhong
            // 
            this.lblVanPhong.AutoSize = true;
            this.lblVanPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblVanPhong.Location = new System.Drawing.Point(9, 26);
            this.lblVanPhong.Name = "lblVanPhong";
            this.lblVanPhong.Size = new System.Drawing.Size(97, 19);
            this.lblVanPhong.TabIndex = 0;
            this.lblVanPhong.Text = "Văn phòng: ";
            // 
            // Frm_ThongTin
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 391);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThongTin";
            this.Text = "Frm_ThongTin";
            this.Load += new System.EventHandler(this.Frm_ThongTin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCelPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblVanPhong;
    }
}