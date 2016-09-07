using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace VnApptech_GYM_Soft
{
    public partial class Frm_CauHinh : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CauHinh()
        {
            InitializeComponent();
        }

        #region khaibaobien
       
        #endregion
        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_CauHinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu lại những thay đổi trên cửa sổ cấu hình trước khi tắt\n Nếu chọn \"OK\" các dữ liệu sẽ lưu lại.\n Ngược lại sẽ tắt và không lưu dữ liệu lại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnluu.PerformClick();
            }
        }
        ArrayList tenbien = new ArrayList();
        ArrayList giatri = new ArrayList();
        private void Frm_CauHinh_Load(object sender, EventArgs e)
        {
            //int i = 0;
            cls_Main.docfilecauhinh(ref tenbien ,ref giatri,Application.StartupPath + @"\Conf.ini");
            //foreach (string item in tenbien)
            //{
            //    dgvdanhsachbien.Rows[i].Cells["colstt"].Value = i + 1;
            //    dgvdanhsachbien.Rows[i].Cells["coltenbien"].Value = item;
               
            //    i++;
            //}
            //int j = 0;
            //foreach (string item in giatri)
            //{
            //    dgvdanhsachbien.Rows[j].Cells["colgiatri"].Value = item;
            //    j++;
            //}
               
            
            
        }

       
        
    }
}
