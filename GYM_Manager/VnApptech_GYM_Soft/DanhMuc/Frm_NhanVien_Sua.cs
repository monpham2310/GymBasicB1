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
    public partial class Frm_NhanVien_Sua : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhanVien_Sua()
        {
            InitializeComponent();
        }

        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
      
        private string MaNhanVien = "";
        private string MaTaiKhoan = "";
        #endregion
        private void LoadDanhSachTaiKhoanLenComboBox(int maTaiKhoan)
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
                    cboLoaiTaiKhoan.SelectedValue = maTaiKhoan;
                    //cboLoaiTaiKhoan.Text = "Chọn người dùng";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Lỗi form Frm_NhanVien_Sua: hàm LoadDanhSachTaiKhoanLenComboBox - " + ex.Message);
            }
        }
        private void LoadDanhPhongTapLenComboBox()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bd.LayThongTinDanhSachPhongTap(ref err);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Form Frm_NhanVien_Them, Hàm LoadDanhPhongTapLenComboBox: Chưa lấy được dử liệu trong bảng PhongTap");
                }
                else
                {
                    cboPhongTap.DataSource = dt;
                    cboPhongTap.ValueMember = "MaPhongTap";
                    cboPhongTap.DisplayMember = "TenPhongTap";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Lỗi form Frm_NhanVien_Them: hàm LoadDanhPhongTapLenComboBox - " + ex.Message);
            }
        }
        private void Frm_NhanVien_Sua_Load(object sender, EventArgs e)
        {
            try
            {
                //Load danh sach tai khoản lên combobox
                MaNhanVien = Frm_NhanVien_Main.MaNhanVien;
                MaTaiKhoan = Frm_NhanVien_Main.MaTaiKhoan;
                LoadDanhSachTaiKhoanLenComboBox(int.Parse(MaTaiKhoan));
                LoadDanhPhongTapLenComboBox();
                
                //load các thông tin của nhân viên
                MaNhanVien = Frm_NhanVien_Main.MaNhanVien;
                DataTable dt = bd.LayThongTinNhanVienTheoMaNhanVien(int.Parse(MaNhanVien), ref err);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Form Frm_NhanVien_Sua, Hàm Frm_NhanVien_Sua_Load: Chưa lấy được dử liệu trong bảng NhanVien");
                }
                else
                {
                    txtTenNhanVien.Text = dt.Rows[0]["TenNhanVien"].ToString();
                    txtDienThoai.Text = dt.Rows[0]["DienThoai"].ToString();
                    txtTenDangNhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
                    dtpNamSinh.Value = Convert.ToDateTime(dt.Rows[0]["NamSinh"].ToString());
                    if (dt.Rows[0]["GioiTinh"].ToString() == "True")
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;
                    cboPhongTap.SelectedValue = dt.Rows[0]["PhongTap"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Sua: Hàm Frm_NhanVien_Sua_Load: " + ex.Message);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_NhanVien_Main.MaNhanVien = "";
            Frm_NhanVien_Main.MaTaiKhoan = "";
            this.Close();
        }
        private bool checkOldPassword(int id, string password)
        {
            DataTable result = bd.HSP_CheckOldPass(ref err, id, password);
            return (result.Rows.Count > 0)? true : false;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtTenNhanVien.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên nhân viên");
                    return;
                }
                int Phai = 0;
                if (radNam.Checked == true)
                    Phai = 1;
                else
                    Phai = 0;
                if (cboLoaiTaiKhoan.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại tài khoản.");
                    return;
                }
                if (cboPhongTap.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn phòng tập.");
                    return;
                }
                if (!string.IsNullOrEmpty(txtMatKhauCu.Text))
                {
                    if (string.IsNullOrEmpty(txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới.");
                        return;
                    }
                    if (!checkOldPassword(int.Parse(MaNhanVien), txtMatKhauCu.Text))
                    {
                        MessageBox.Show("Mật khẩu cũ không khớp.");
                        return;
                    }
                    if (bd.SuaThongTinNhanVienTheoMaNhanVien(ref err, int.Parse(MaNhanVien), txtTenNhanVien.Text, Phai, dtpNamSinh.Value, txtDienThoai.Text, txtTenDangNhap.Text, int.Parse(cboLoaiTaiKhoan.SelectedValue.ToString()), 1, int.Parse(cboPhongTap.SelectedValue.ToString()), txtMatKhauMoi.Text) == true)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    if (bd.SuaThongTinNhanVienTheoMaNhanVien(ref err, int.Parse(MaNhanVien), txtTenNhanVien.Text, Phai, dtpNamSinh.Value, txtDienThoai.Text, txtTenDangNhap.Text, int.Parse(cboLoaiTaiKhoan.SelectedValue.ToString()), 1, int.Parse(cboPhongTap.SelectedValue.ToString())) == true)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Sua: Hàm barButtonItem1_ItemClick: " + ex.Message);
            }
        }
    }
}
