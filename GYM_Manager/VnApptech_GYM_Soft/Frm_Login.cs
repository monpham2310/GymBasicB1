using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyLibrarySoft;
using System.IO;
using VnApptech_GYM_Soft.HeThong;


namespace VnApptech_GYM_Soft
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
            cls_Main.frmLogin= this;
            txtusername.Text="";
            txtpassword.Text="";
          
        }
        #region các biến được khai báo
        string err = "";
        BLL_HeThong bd = new BLL_HeThong(cls_Main.pathconnect);
        #endregion
        private void btnthoat_Click(object sender, EventArgs e)
        {
            cls_Main.thoat = true;
            Application.Exit();
        }
        private bool dangnhap(string taikhoan, string matkhau)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bd.LayThongTinDangNhap(ref err, taikhoan, matkhau);
                if (dt.Rows.Count > 0)
                {
                    cls_Main.tenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                    cls_Main.tenNhanVien = dt.Rows[0]["TenNhanVien"].ToString();
                    cls_Main.maTaiKhoan = dt.Rows[0]["MaTaiKhoan"].ToString();
                    cls_Main.maCaLamViec = Convert.ToInt32(cbocalamviec.SelectedValue.ToString());
                    cls_Main.tenCaLamViec = cbocalamviec.Text;
                    cls_Main.maNhanVien = dt.Rows[0]["MaNhanVien"].ToString();
                    
                    if (cls_Main.maTaiKhoan != "1" )
                    {
                        if (cls_Main.dangxuat == false)
                        {
                            DataTable dtlamviec = new DataTable();
                            dtlamviec = bd.ChiTietLamViecNhanVien_insert(cbocalamviec.SelectedValue.ToString(), cls_Main.maNhanVien, "Nhân viên đăng nhập thành công chương trình", DateTime.Now.ToShortTimeString());
                        }
                    }
                    else
                    {
                        DataTable dtlamviec = new DataTable();
                        dtlamviec = bd.ChiTietLamViecNhanVien_insert(cbocalamviec.SelectedValue.ToString(), cls_Main.maNhanVien, "Nhân viên đăng nhập thành công chương trình", DateTime.Now.ToShortTimeString());
                        cls_Main.thoat = true;
                    }
                    return true;
                }

            }
            catch (Exception ex)
            {
                err += ex.Message;
            }
            return false;
        }

        private void loadtaikhoan()
        {
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            DataTable dt = new DataTable();
            dt = bd.laytaikhoan(ref err);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i]["TenDangNhap"].ToString());
            }

            txtusername.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtusername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtusername.AutoCompleteCustomSource = datasource;
            cls_Main.inloi(lblerr, err);
        }
        private void loadcalamviec()
        {
            DataTable dt = new DataTable();
            dt = bd.Laycalamviec(ref err);
            if (dt.Rows.Count > 0)
            {                
                cbocalamviec.DataSource = dt;
                cbocalamviec.ValueMember = "MaCaLamViec";
                cbocalamviec.DisplayMember = "TenCa";
                cbocalamviec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbocalamviec.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbocalamviec.SelectedIndex = -1;
                cbocalamviec.Text = "--Chọn ca làm việc--";
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtusername.Text))
            {
                if (!string.IsNullOrEmpty(txtpassword.Text))
                {
                    if (dangnhap(txtusername.Text, txtpassword.Text))
                    {
                        this.Close();
                        lblerr.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblerr.Text = err;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblmatkhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
            }
        }
        private string value = "";

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong(cls_Main.pathconnect, ref cls_Main.serverName, ref cls_Main.database, ref cls_Main.uid, ref cls_Main.pass);
            
            if (cls_GetIDMachine.readRegistry(ref value, ref cls_GetIDMachine.ngayHetHan, ref cls_GetIDMachine.active) == false || String.IsNullOrEmpty(value))
            {
                cls_GetIDMachine.writeRegistry(cls_Main.chuoimahoaDemo, DateTime.Now.AddDays(30));
            }
            //doc mã trong registry
            if (cls_GetIDMachine.readRegistry(ref value, ref cls_GetIDMachine.ngayHetHan, ref cls_GetIDMachine.active) && value != cls_GetIDMachine.laycauhinh(ref err))
            {
                if (cls_GetIDMachine.ngayHetHan > DateTime.Now)
                {
                    lblerr.Text = "Bạn đang sử dụng phiên bản dùng thử\nNếu muốn sử dụng chính thức hãy liên hệ CÔNG TY TNHH VNAPPTECH Website: http://vnapptech.com.vn\n " + err + "\nSố ngày còn lại là: " + Convert.ToInt32(cls_GetIDMachine.ngayHetHan.Subtract(DateTime.Now).TotalDays).ToString();
                    cls_Main.songayconlai = Convert.ToInt32(cls_GetIDMachine.ngayHetHan.Subtract(DateTime.Now).TotalDays);
                    if (!File.Exists("Chuoiketnoi.ini"))
                    {

                        if (!bd.kiemtraketnoi())
                        {
                            Frm_KetNoi _frmketnoi = new Frm_KetNoi();
                            _frmketnoi.ShowDialog();

                            bd = new BLL_HeThong(cls_Main.pathconnect, ref cls_Main.serverName, ref cls_Main.database, ref cls_Main.uid, ref cls_Main.pass);
                        }

                    }
                    else
                    {
                        if (bd.kiemtraketnoi() == false)
                        {
                            MessageBox.Show("Lỗi kết nối server, vui lòng kiểm tra thông tin kết nối");
                            Frm_KetNoi f = new Frm_KetNoi();
                            f.ShowDialog();
                            bd = new BLL_HeThong(cls_Main.pathconnect, ref cls_Main.serverName, ref cls_Main.database, ref cls_Main.uid, ref cls_Main.pass);
                            lblerr.Text = "Hệ thống đang kết nối đến database:" + cls_Main.database;
                        }
                        else
                        {
                            txtusername.Focus();
                        }
                    }
                    loadtaikhoan();
                    loadcalamviec();
                }
                else
                {
                    //trường hợp hết hạn sử dụng
                    if (MessageBox.Show("Bạn đang sử dụng phiên bản dùng thử\nNếu muốn sử dụng chính thức hãy liên hệ CÔNG TY TNHH VNAPPTECH Website: http://vnapptech.com.vn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        frm_capnhatbanquyen _frmcapnhatbanquyen = new frm_capnhatbanquyen();
                        _frmcapnhatbanquyen.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }
                  
                }
            }
            
        }

        private void cbocalamviec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbocalamviec.SelectedIndex > -1)
            {
                txtpassword.Enabled = true;
                txtusername.Enabled = true;
                txtusername.Focus();
                btndangnhap.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_KetNoi frm = new Frm_KetNoi();
            frm.ShowDialog();
        }
           
    }
}
