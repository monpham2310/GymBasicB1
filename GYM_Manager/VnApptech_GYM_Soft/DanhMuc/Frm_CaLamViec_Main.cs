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
    public partial class Frm_CaLamViec_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CaLamViec_Main()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
        public static string MaCaLamViec = "";
        #endregion
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        private void Load_DanhSachCaLamViecLenLuoi()
        {
            try
            {
                dt_DanhSachLoaiKhachHang = bd.LayThongTinDanhSachCaLamViec(ref err);
                dgvDanhSachCaLamViec.DataSource = dt_DanhSachLoaiKhachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Main: Hàm Load_DanhSachCaLamViecLenLuoi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_CaLamViec_Main_Load(object sender, EventArgs e)
        {
            Load_DanhSachCaLamViecLenLuoi();
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
                saveFileDialog1.Filter = "Excel|*.xlsx";
                saveFileDialog1.Title = "Save an File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    dgvDanhSachCaLamViec.ExportToXlsx(saveFileDialog1.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_LoaiVe_Main: Hàm btnxuatexcel_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MaCaLamViec == "")
                    MessageBox.Show("Hãy chọn ca làm việc muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string str = String.Format("Bạn chắc chắn muốn xóa");
                    if (MessageBox.Show(str, "Cảnh báo xóa", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (bd.XoaCaLamViecTheoMaCaLamViec(int.Parse(MaCaLamViec)) == true)
                        {
                            MaCaLamViec = "";
                            Load_DanhSachCaLamViecLenLuoi();
                        }
                        else
                        {
                            MessageBox.Show("Chưa xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Main: Hàm btnxoa_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                MaCaLamViec = dtr["MaCaLamViec"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Main: Hàm RowClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MaCaLamViec == "")
                {
                    MessageBox.Show("Hãy chọn ca làm việc muốn sửa");
                }
                else
                {
                    Frm_CaLamViec_Sua frm = new Frm_CaLamViec_Sua();
                    frm.ShowDialog();
                    Load_DanhSachCaLamViecLenLuoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Main: Hàm btnsua_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (MaCaLamViec == "")
                {
                    MessageBox.Show("Hãy chọn ca làm việc muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Frm_CaLamViec_Sua frm = new Frm_CaLamViec_Sua();
                    frm.ShowDialog();
                    Load_DanhSachCaLamViecLenLuoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Main: Hàm btnsua_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnnaplai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_CaLamViec_Them frm = new Frm_CaLamViec_Them();
            frm.ShowDialog();
            Load_DanhSachCaLamViecLenLuoi();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_DanhSachCaLamViecLenLuoi();
        }



        public object dt_DanhSachLoaiKhachHang { get; set; }
    }
}
