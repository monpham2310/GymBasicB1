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
    public partial class Frm_TaiKhoan_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_TaiKhoan_Main()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
        public static string MaTaiKhoan = "";
        public static string TenTaiKhoan = "";
        #endregion
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        bool chothem = false;
        private void Load_DanhSachLoaiTaiKhoanLuoi()
        {
            try
            {
                DataTable DT_DanhSachTaiKhoan = bd.LayThongTinDanhSachTaiKhoan(ref err);
                gv_DSTaiKhoan.DataSource = DT_DanhSachTaiKhoan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_LoaiVe_Main: Hàm Load_DanhSachLoaiVeLenLuoi: " + ex.Message);
            }
        }
        private void Frm_TaiKhoan_Main_Load(object sender, EventArgs e)
        {
            Load_DanhSachLoaiTaiKhoanLuoi();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barEditItem1.EditValue = "";
        }


        private void txtTenTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenTaiKhoan.Text = "";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_DanhSachLoaiTaiKhoanLuoi();
        }

        private void btnnaplai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             try
             {
                 if (chothem == true&&!string.IsNullOrEmpty(txtTenTaiKhoan.Text))
                 {
                     if (bd.ThemTaiKhoan(txtTenTaiKhoan.Text, 1) == true)
                     {
                         MessageBox.Show("Thêm loại tài khoản thành công");
                         txtTenTaiKhoan.Text = "--Thêm loại tài khoản mới--";
                         txtTenTaiKhoan.TextAlign = HorizontalAlignment.Center;
                         Load_DanhSachLoaiTaiKhoanLuoi();
                         chothem = false;
                     }
                     else
                     {
                         MessageBox.Show("Chưa thêm được");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Hãy nhập tên tài khoản mới","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_LoaiVe_Them, hàm barButtonItem1_ItemClick - " + ex.Message);
            }
        }


        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MaTaiKhoan == "")
            {
                MessageBox.Show("Hãy chọn loại tài khoản muốn sửa");
            }
            else
            {
                Frm_TaiKhoan_Sua frm = new Frm_TaiKhoan_Sua();
                frm.ShowDialog();
                Load_DanhSachLoaiTaiKhoanLuoi();
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (MaTaiKhoan == "")
            {
                MessageBox.Show("Hãy chọn loại tài khoản muốn sửa");
            }
            else
            {
                Frm_TaiKhoan_Sua frm = new Frm_TaiKhoan_Sua();
                frm.ShowDialog();
                Load_DanhSachLoaiTaiKhoanLuoi();
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                MaTaiKhoan = dtr["MaTaiKhoan"].ToString();
                TenTaiKhoan = dtr["TenTaiKhoan"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_LoaiVe_Main: Hàm RowClick: " + ex.Message);
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MaTaiKhoan == "")
                    MessageBox.Show("Hãy chọn tài khoản muốn xóa");
                else
                {
                    string str = String.Format("Bạn chắc chắn muốn xóa tài khoản: " + TenTaiKhoan);
                    if (MessageBox.Show(str, "Cảnh báo xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (bd.XoaTaiKhoanTheoMaTaiKhoan(int.Parse(MaTaiKhoan)) == true)
                        {
                            MaTaiKhoan = "";
                            TenTaiKhoan = "";
                            Load_DanhSachLoaiTaiKhoanLuoi();
                        }
                        else
                        {
                            MessageBox.Show("Chưa xóa được");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_TaiKhoan_Main: Hàm btnxoa_ItemClick: " + ex.Message);
            }
        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void btnxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls";
                saveFileDialog1.Title = "Save an File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    gv_DSTaiKhoan.ExportToXls(saveFileDialog1.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_TaiKhoan_Main: Hàm btnxuatexcel_ItemClick: " + ex.Message);
            }
        }
       
        private void txtTenTaiKhoan_Click(object sender, EventArgs e)
        {
            chothem = true;
        }

      
    }
}
