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
    public partial class Frm_CaLamViec_Sua : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CaLamViec_Sua()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
        private string MaCaLamViec = "";
        #endregion

        private void Frm_CaLamViec_Sua_Load(object sender, EventArgs e)
        {
            MaCaLamViec = Frm_CaLamViec_Main.MaCaLamViec;
            try
            {
                //load các thông tin của Ca làm việc
                MaCaLamViec = Frm_CaLamViec_Main.MaCaLamViec;
                DataTable dt = bd.LayThongTinCaLamViecTheoMaCaLamViec( ref err,int.Parse(MaCaLamViec));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Form Frm_CaLamViec_Sua, Hàm Frm_CaLamViec_Sua_Load: Chưa lấy được dử liệu trong bảng CaLamViec");
                }
                else
                {
                    dtpGioBatDau.Text = dt.Rows[0]["GioBatDau"].ToString();
                    dtbGioKetThuc.Text = dt.Rows[0]["GioKetThuc"].ToString();
                    txtGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Sua: Hàm Frm_CaLamViec_Sua_Load: " + ex.Message);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_CaLamViec_Main.MaCaLamViec = "";
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dtpGioBatDau.Value >= dtbGioKetThuc.Value)
                {
                    MessageBox.Show("Hãy nhập giờ kết thúc lớn hơn giờ bắt đầu");
                    return;
                }
                if (bd.SuaThongTinCaLamViecTheoMaCaLamViec(ref err,int.Parse(MaCaLamViec),dtpGioBatDau.Value.ToShortTimeString(),dtbGioKetThuc.Value.ToShortTimeString(), txtGhiChu.Text, 1) == true)
                {
                    MessageBox.Show("Sửa thông tin ca làm việc thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form Frm_CaLamViec_Sua: Hàm barButtonItem1_ItemClick: " + ex.Message);
            }
        }
    }
}
