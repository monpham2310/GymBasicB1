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
    public partial class H_Frm_Club_Modify : DevExpress.XtraEditors.XtraForm
    {
        private bool isUpdate = false;
        private DataRow drClub = null;
        private IBLL_DanhMuc bll;
        private string err = "";

        public H_Frm_Club_Modify()
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        public H_Frm_Club_Modify(bool isUpdate, DataRow dr)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            drClub = dr;
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void H_Frm_Club_Modify_Load(object sender, EventArgs e)
        {
            if (isUpdate && drClub != null)
            {
                txtClubName.Text = drClub["TenPhongTap"].ToString();
                txtNumberPeople.Text = drClub["SoNguoiToiDa"].ToString();
                txtAddress.Text = drClub["DiaChi"].ToString();
                txtPhone.Text = drClub["SoDienThoai"].ToString();
                txtNote.Text = drClub["GhiChu"].ToString();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool result = false;
                string clubName = txtClubName.Text;
                int numberPeople = int.Parse(txtNumberPeople.Text);
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string note = txtNote.Text;
                if (isUpdate && drClub != null)
                {
                    int clubId = int.Parse(drClub["MaPhongTap"].ToString());
                    result = bll.H_UpdateClub(ref err, clubId, clubName, numberPeople, address, phone, note);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    result = bll.H_AddClub(ref err, clubName, numberPeople, address, phone, note);
                    if (result)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resetControls();
                    }
                    else
                        MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at btnSave_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetControls()
        {
            txtClubName.Clear();
            txtNumberPeople.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtNote.Clear();
        }
    }
}