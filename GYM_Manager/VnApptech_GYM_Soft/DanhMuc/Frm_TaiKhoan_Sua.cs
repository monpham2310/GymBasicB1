using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.DanhMuc
{
    public partial class Frm_TaiKhoan_Sua : DevExpress.XtraEditors.XtraForm
    {
        public Frm_TaiKhoan_Sua()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
        private string MaTaiKhoan = "";
        private string TenTaiKhoan = "";
        #endregion
        private void Frm_TaiKhoan_Sua_Load(object sender, EventArgs e)
        {
            TenTaiKhoan=Frm_TaiKhoan_Main.TenTaiKhoan;
            MaTaiKhoan = Frm_TaiKhoan_Main.MaTaiKhoan;
            lblTenTaiKhoan.Text = TenTaiKhoan;
        }

      

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_TaiKhoan_Main.TenTaiKhoan = "";
            Frm_TaiKhoan_Main.MaTaiKhoan = "";
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtTenTaiKhoanMoi.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên tên tài khoản mới");
                    return;
                }
                if (bd.SuaThongTinTaiKhoanTheoMaTaiKhoan(int.Parse(MaTaiKhoan), txtTenTaiKhoanMoi.Text, 1) == true)
                {
                    MessageBox.Show("Sửa thông tin tài khoản thành công");
                    lblTenTaiKhoan.Text = txtTenTaiKhoanMoi.Text;
                    Frm_TaiKhoan_Main.TenTaiKhoan = txtTenTaiKhoanMoi.Text;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_TaiKhoan_Sua: Hàm barButtonItem1_ItemClick: " + ex.Message);
            }
        }
    }
}
