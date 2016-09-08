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
    public partial class Frm_PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
        }
        BLL_HeThong bd = new BLL_HeThong(cls_Main.pathconnect);
        string err = ""; 
        DataTable dt;

        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        #region Các phương thức
        private void ViewPermission()
        {
            dt = bd.GetChucNang(ref err);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int giatriquyen = Convert.ToInt32(dt.Rows[i]["GiaTriQuyen"].ToString());
                if ((giatriquyen & 1) == 1)
                {
                    dt.Rows[i]["View"] = 1;
                }
                if ((giatriquyen & 2) == 2)
                {
                    dt.Rows[i]["Add"] = 1;
                }
                if ((giatriquyen & 4) == 4)
                {
                    dt.Rows[i]["Update"] = 1;
                }
                if ((giatriquyen & 8) == 8)
                {
                    dt.Rows[i]["Delete"] = 1;
                }
            }
            dgvviewPermission.DataSource = dt;
        }
        private void SavePemission()
        {
            DataTable dtchang = dt.GetChanges();
            for (int i = 0; i < dtchang.Rows.Count; i++)
            {
                int giatriquyen = 0;
                if (dtchang.Rows[i]["View"].ToString() == "1")
                {
                    giatriquyen += 1;
                }
                if (dtchang.Rows[i]["Add"].ToString() == "1")
                {
                    giatriquyen += 2;
                }
                if (dt.Rows[i]["Update"].ToString() == "1")
                {
                    giatriquyen += 4;
                }
                if (dtchang.Rows[i]["Delete"].ToString() == "1")
                {
                    giatriquyen += 8;
                }
                bd.CapNhat(ref err, Convert.ToInt32(dtchang.Rows[i]["MaChucNang"].ToString()),
                     Convert.ToInt32(dtchang.Rows[i]["MaTaiKhoan"].ToString()),
                     giatriquyen);
            }

            ViewPermission();
        }
        #endregion

        #region Các sự kiện
        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            ViewPermission();
        }
       
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            SavePemission();
        }
        #endregion

      

       
      
    }
}
