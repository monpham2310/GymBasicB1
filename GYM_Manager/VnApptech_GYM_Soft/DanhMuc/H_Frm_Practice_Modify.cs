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
    public partial class H_Frm_Practice_Modify : DevExpress.XtraEditors.XtraForm
    {
        private DataRow drPractice = null;
        private bool isUpdate = false;
        private IBLL_DanhMuc bll;
        private string err = "";

        public H_Frm_Practice_Modify()
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        public H_Frm_Practice_Modify(bool isUpdate, DataRow dr)
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
            this.drPractice = dr;
            this.isUpdate = isUpdate;
        }

        private void H_Frm_Practice_Modify_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtPracticeName.Text = drPractice["TenMonTap"].ToString();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtPracticeName.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên môn tập.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (isUpdate)
                {
                    int practiceId = int.Parse(drPractice["MaMonTap"].ToString());
                    bool result = bll.H_UpdatePractice(ref err, practiceId, txtPracticeName.Text);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {                    
                    bool result = bll.H_AddPractice(ref err, txtPracticeName.Text);
                    if (result)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error at btnSave_ItemClick: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
                
    }
}