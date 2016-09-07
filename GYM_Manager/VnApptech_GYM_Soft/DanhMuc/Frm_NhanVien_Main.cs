using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VnApptech_GYM_Soft.DanhMuc
{
    public partial class Frm_NhanVien_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhanVien_Main()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
        public static string MaNhanVien = "";
        public static string MaTaiKhoan = "";
        string TenNhanVien = "";
        #endregion

        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        private void Load_DanhSachNhanVienLenLuoi()
        {
            try
            {
                DataTable DT_DanhSachNhanVien = bd.LayThongTinDanhSachNhanVien(ref err);
                gv_DSNhanVien.DataSource = DT_DanhSachNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Main: Hàm Load_DanhSachNhanVienLenLuoi: " + ex.Message);
            }
        }

        private void Frm_NhanVien_Main_Load(object sender, EventArgs e)
        {
            Load_DanhSachNhanVienLenLuoi();
        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_DanhSachNhanVienLenLuoi();
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MaNhanVien == "")
                    MessageBox.Show("Hãy chọn nhân viên muốn xóa");
                else
                {
                    string str = String.Format("Bạn chắc chắn muốn xóa nhân viên: " + TenNhanVien);
                    if (MessageBox.Show(str, "Cảnh báo xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (bd.XoaNhanVienTheoMaNhanVien(int.Parse(MaNhanVien)) == true)
                        {

                            MaNhanVien = "";
                            Load_DanhSachNhanVienLenLuoi();
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
                MessageBox.Show("Exception: Form Frm_NhanVien_Main: Hàm btnxoa_ItemClick: " + ex.Message);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                MaNhanVien = dtr["MaNhanVien"].ToString();
                TenNhanVien= dtr["TenNhanVien"].ToString();
                MaTaiKhoan = dtr["MaTaiKhoan"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Main: Hàm RowClick: " + ex.Message);
            }
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
                    gv_DSNhanVien.ExportToXls(saveFileDialog1.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Main: Hàm btnxuatexcel_ItemClick: " + ex.Message);
            }
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MaNhanVien == "")
                {
                    MessageBox.Show("Hãy chọn nhân viên muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Frm_NhanVien_Sua frm = new Frm_NhanVien_Sua();
                    frm.ShowDialog();
                    Load_DanhSachNhanVienLenLuoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Main: Hàm btnsua_ItemClick: " + ex.Message);
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (MaNhanVien == "")
                {
                    MessageBox.Show("Hãy chọn nhân viên muốn sửa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    Frm_NhanVien_Sua frm = new Frm_NhanVien_Sua();
                    frm.ShowDialog();
                    Load_DanhSachNhanVienLenLuoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_NhanVien_Main: Hàm btnsua_ItemClick: " + ex.Message);
            }
        }
        private void btnnaplai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_NhanVien_Them frm = new Frm_NhanVien_Them();
            frm.ShowDialog();
            Load_DanhSachNhanVienLenLuoi();
        }

       
        
    }
}