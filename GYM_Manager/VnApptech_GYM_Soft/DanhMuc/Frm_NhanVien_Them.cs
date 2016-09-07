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
    public partial class Frm_NhanVien_Them : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhanVien_Them()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
      
        #endregion
        private void LoadDanhSachTaiKhoanLenComboBox()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bd.LayThongTinDanhSachTaiKhoan(ref err);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Form Frm_NhanVien_Sua, Hàm LoadDanhSachTaiKhoanLenComboBox: Chưa lấy được dử liệu trong bảng TaiKhoan");
                }
                else
                {
                    cboLoaiTaiKhoan.DataSource = dt;
                    cboLoaiTaiKhoan.ValueMember = "MaTaiKhoan";
                    cboLoaiTaiKhoan.DisplayMember = "TenTaiKhoan";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Lỗi form Frm_NhanVien_Them: hàm LoadDanhSachTaiKhoanLenComboBox - " + ex.Message);
            }
        }
        private void Frm_NhanVien_THem_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoanLenComboBox();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTenNhanVien.Text))
                {
                    int Phai = 0;
                    if (radNam.Checked == true)
                        Phai = 1;
                    else
                        Phai = 0;
                    if (bd.ThemNhanVien(txtTenNhanVien.Text, Phai, dtpNamSinh.Value, txtDienThoai.Text, txtTenDangNhap.Text, int.Parse(cboLoaiTaiKhoan.SelectedValue.ToString()), txtMatKhau.Text, 1) == true)
                    {
                        MessageBox.Show("Thêm loại nhân viên thành công");
                        txtDienThoai.Text = "";
                        txtTenDangNhap.Text = "";
                        txtTenNhanVien.Text = "";
                        radNam.Checked = true;
                        //cboLoaiTaiKhoan.Text = "Chọn người dùng";
                        txtMatKhau.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Chưa thêm được nhân viên");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Lỗi form Frm_NhanVien_Them: hàm barButtonItem1_ItemClick - " + ex.Message);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked == true)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void Frm_NhanVien_Them_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
