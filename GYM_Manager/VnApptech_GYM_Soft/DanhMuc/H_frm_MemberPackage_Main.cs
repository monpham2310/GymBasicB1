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
    public partial class H_frm_MemberPackage_Main : DevExpress.XtraEditors.XtraForm
    {
        private BLL_DanhMuc bll;
        private string err = "";
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private DataRow drMemberPackage;

        public H_frm_MemberPackage_Main()
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        private void GetDataOnMemberPackage()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bll.H_GetMemberPackageList(ref err);
                dgvMemberPackage.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetDataOnMemberPackage Error!\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void H_frm_MemberPackage_Main_Load(object sender, EventArgs e)
        {
            GetDataOnMemberPackage();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetDataOnMemberPackage();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            H_MemberPackage_Modify frm = new H_MemberPackage_Modify();
            frm.ShowDialog();
            GetDataOnMemberPackage();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (drMemberPackage != null)
            {
                H_MemberPackage_Modify frm = new H_MemberPackage_Modify(true, drMemberPackage);
                frm.ShowDialog();
                GetDataOnMemberPackage();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn gói tập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool result = false;
                if (drMemberPackage != null)
                {
                    result = bll.H_DeleteMemberPackage(ref err, (int)drMemberPackage["MaGoiTap"]);
                }

                if (result)
                {
                    MessageBox.Show("Xóa gói tập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetDataOnMemberPackage();
                }
                else
                    MessageBox.Show("Xóa gói tập thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("btnDelete_Click Error!\n" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportToXls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel|*.xls";
                saveFile.Title = "Save an File";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    dgvMemberPackage.ExportToXlsx(saveFile.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form H_MemberPackage_Main: btnExportToXls_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void gvMemberPackage_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            drMemberPackage = gvMemberPackage.GetDataRow(e.RowHandle);
        }

        private void gvMemberPackage_DoubleClick(object sender, EventArgs e)
        {
            if (drMemberPackage != null)
            {
                H_MemberPackage_Modify frm = new H_MemberPackage_Modify(true, drMemberPackage);
                frm.ShowDialog();
                GetDataOnMemberPackage();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn gói tập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}