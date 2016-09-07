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
    public partial class Frm_KetNoi : DevExpress.XtraEditors.XtraForm
    {
        public Frm_KetNoi()
        {
            InitializeComponent();
        }
        BLL_HeThong bd;// 
       private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu lại những thay đổi trên cửa sổ cấu hình trước khi tắt\n Nếu chọn \"OK\" các dữ liệu sẽ lưu lại.\n Ngược lại sẽ tắt và không lưu dữ liệu lại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnluuketnoi.PerformClick();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btnluuketnoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtservername.Text))
                {
                    if (!string.IsNullOrEmpty(txtdatabasename.Text))
                    {
                        if (!string.IsNullOrEmpty(txtusername.Text))
                        {
                            if (!string.IsNullOrEmpty(txtpassword.Text))
                            {
                                bd.ghichuoiketnoi(cls_Main.pathconnect, txtservername.Text, txtdatabasename.Text, txtusername.Text, txtpassword.Text);
                                MessageBox.Show("Đã lưu chuỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                bd = new BLL_HeThong(cls_Main.pathconnect, ref cls_Main.serverName, ref cls_Main.database, ref cls_Main.uid, ref cls_Main.pass);
                            }
                            else
                            {
                                MessageBox.Show("Chưa nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtpassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtusername.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập Databasename", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtdatabasename.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập Servername", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtservername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình lưu file!\n Hãy kiểm tra lại quyền truy cập trong thư mục cài đặt\n"+ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnkiemtraketnoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bd.kiemtraketnoi() == true)
            {
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void Frm_KetNoi_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong(cls_Main.pathconnect, ref cls_Main.serverName, ref cls_Main.database, ref cls_Main.uid, ref cls_Main.pass);
            txtservername.Text = cls_Main.serverName;
            txtdatabasename.Text = cls_Main.database;
            txtusername.Text = cls_Main.uid;
            txtpassword.Text = cls_Main.pass;
        }
    }
}
