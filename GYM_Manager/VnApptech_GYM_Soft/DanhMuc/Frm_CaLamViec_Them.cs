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
    public partial class Frm_CaLamViec_Them : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CaLamViec_Them()
        {
            InitializeComponent();
        }
        #region các biến được khai báo
        string err = "";
        BLL_DanhMuc bd = new BLL_DanhMuc(cls_Main.pathconnect);
        #endregion

        private void Frm_CaLamViec_Them_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
      


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bd.ThemCaLamViec(dtpGioBatDau.Value.ToShortTimeString(),dtbGioKetThuc.Value.ToShortTimeString(), txtGhiChu.Text, 1) == true)
                {
                    MessageBox.Show("Thêm ca làm việc thành công");
                    txtGhiChu.Text = "";
                }
                else
                {
                    MessageBox.Show("Chưa thêm được");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Lỗi form Frm_CaLamViec_Them: hàm barButtonItem1_ItemClick - " + ex.Message);
            }
        }
    }
}
