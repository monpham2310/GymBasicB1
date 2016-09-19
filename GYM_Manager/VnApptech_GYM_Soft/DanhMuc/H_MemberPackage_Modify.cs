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
    public partial class H_MemberPackage_Modify : DevExpress.XtraEditors.XtraForm
    {
        BLL_DanhMuc bll;
        private string err = "";
        private bool isUpdate = false;
        private DataRow drPackageMember;

        public H_MemberPackage_Modify()
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        public H_MemberPackage_Modify(bool isUpdate, DataRow dr)
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
            this.isUpdate = isUpdate;
            this.drPackageMember = dr;
        }

        private void GetAllRooms()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bll.H_GetAllRooms(ref err);
                cbRoom.DataSource = dt;
                cbRoom.DisplayMember = "TenPhongTap";
                cbRoom.ValueMember = "MaPhongTap";
                cbRoom.SelectedIndex = -1;
                cbRoom.Text = "--Chọn phòng tập--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllRooms Error!\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllSubjects()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bll.H_GetAllSubjects(ref err);
                cbSubject.DataSource = dt;
                cbSubject.DisplayMember = "TenMonTap";
                cbSubject.ValueMember = "MaMonTap";
                cbSubject.SelectedIndex = -1;
                cbSubject.Text = "--Chọn môn tập--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllSubjects Error!\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllPackageType()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bll.H_GetAllPackageType(ref err);
                cbPackageType.DataSource = dt;
                cbPackageType.DisplayMember = "TenLoai";
                cbPackageType.ValueMember = "MaLoai";
                cbPackageType.SelectedIndex = -1;
                cbPackageType.Text = "--Chọn loại--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllPackageType Error!\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void H_MemberPackage_Modify_Load(object sender, EventArgs e)
        {
            GetAllRooms();
            GetAllSubjects();
            GetAllPackageType();
            if (isUpdate && drPackageMember != null)
            {
                txtPackageName.Text = drPackageMember["TenGoiTap"].ToString();
                cbSubject.SelectedValue = (int)drPackageMember["MonTap"];
                cbRoom.SelectedValue = (int)drPackageMember["PhongTap"];
                cbPackageType.SelectedValue = (int)drPackageMember["LoaiGoiTap"];
                txtDayNumber.Value = long.Parse(drPackageMember["SoNgay"].ToString());
                txtPrice.Value = long.Parse(drPackageMember["DonGia"].ToString());
                dtpStartTime.Text = drPackageMember["GioBD"].ToString();
                dtpEndTime.Text = drPackageMember["GioKT"].ToString();
                ckbType.Checked = ((int)drPackageMember["HinhThucTap"] == 1) ? true : false;
                txtTurnNumber.Value = (int)drPackageMember["SoLanTap"];
            }
        }

        private void ckbType_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbType.Checked)
            {
                lbTurnNumber.Visible = true;
                ckbType.Visible = true;
            }
            else
            {
                lbTurnNumber.Visible = false;
                ckbType.Visible = false;
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtTurnNumber.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống tên gói tập.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbRoom.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng tập.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbSubject.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn môn tập.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbPackageType.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại gói tập.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtDayNumber.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số ngày.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đơn giá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dtpStartTime.Value > dtpEndTime.Value)
                {
                    MessageBox.Show("Giờ bắt đầu phải nhỏ hơn hoặc bằng giờ kết thúc.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                
                string packageName = txtPackageName.Text;
                int roomId = (int)cbRoom.SelectedValue;
                int subjectId = (int)cbSubject.SelectedValue;
                int packageType = (int)cbPackageType.SelectedValue;
                long dayNumber = txtDayNumber.Value;
                long price = txtPrice.Value;
                DateTime startTime = dtpStartTime.Value;
                DateTime endTime = dtpEndTime.Value;
                int type = (ckbType.Checked)? 1 : 0;
                long turnNumber = (txtTurnNumber.Text != "") ? txtTurnNumber.Value : 0;
                if (isUpdate && drPackageMember != null)
                {
                    int packageId = (int)drPackageMember["MaGoiTap"];
                    bool result = false;
                    result = bll.H_UpdateMemberPackage(ref err, packageId, packageName, roomId, subjectId, packageType, dayNumber, price, startTime, endTime, type, turnNumber);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật gói tập thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật gói tập thất bại.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool result = false;
                    result = bll.H_AddMemberPackage(ref err, packageName, roomId, subjectId, packageType, dayNumber, price, startTime, endTime, type, turnNumber);
                    if (result)
                    {
                        MessageBox.Show("Thêm gói tập thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Thêm gói tập thất bại.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnSave Error!\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

                        
    }
}