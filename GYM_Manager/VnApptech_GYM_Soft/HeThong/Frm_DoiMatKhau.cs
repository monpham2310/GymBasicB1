using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.HeThong
{
    public partial class Frm_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BLL_HeThong bd;
        string err = "";
        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void loadnguoidung()
        {
            DataTable dt = new DataTable();
            dt = bd.laytaikhoan(ref err);
            cbonguoidung.DataSource = dt;
            cbonguoidung.ValueMember = "TenDangNhap";
            cbonguoidung.DisplayMember = "TenDangNhap";
            cbonguoidung.SelectedIndex = -1;
            cbonguoidung.Text = "Chọn người dùng";
        }
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd=new BLL_HeThong(cls_Main.pathconnect, ref cls_Main.serverName, ref cls_Main.database, ref cls_Main.uid, ref cls_Main.pass);
            groupnguoidung.Text = "Người dùng hiện tại: " + cls_Main.tenDangNhap;
            if (cls_Main.maTaiKhoan != "1")
            {
                lblchonnguoidung.Visible = false;
                cbonguoidung.Visible = false;
                btncaplaimatkhau.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                loadnguoidung();
                lblchonnguoidung.Visible = true;
                cbonguoidung.Visible = true;
                btncaplaimatkhau.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void btndoimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bd.doimatkhau(cls_Main.tenDangNhap, txtmatkhaumoi.Text)==true)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlapmatkhaumoi.Text = "";
                txtmatkhaumoi.Text = "";
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlapmatkhaumoi.Text = "";
                txtmatkhaumoi.Text = "";
                cls_Main.inloi(lblerr, err);
            }
        }

        private void txtlapmatkhaumoi_Leave(object sender, EventArgs e)
        {
            if (txtmatkhaumoi.Text.Equals(txtlapmatkhaumoi.Text) == false)
            {
                txtlapmatkhaumoi.Text = "";
                cls_Main.inloi(lblerr, "Mật khẩu không khợp xin nhập lại mật khẩu mới");
                txtlapmatkhaumoi.Focus();
                
            }
        }

        private void btncaplaimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbonguoidung.SelectedIndex > -1)
            {
                if (bd.doimatkhau(cbonguoidung.SelectedValue.ToString(), cbonguoidung.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtlapmatkhaumoi.Text = "";
                    txtmatkhaumoi.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtlapmatkhaumoi.Text = "";
                    txtmatkhaumoi.Text = "";
                    cls_Main.inloi(lblerr, err);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
