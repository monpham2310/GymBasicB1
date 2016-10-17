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
    public partial class H_Frm_Club_Main : DevExpress.XtraEditors.XtraForm
    {
        private IBLL_DanhMuc bll;
        private string err = "";
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private DataRow drClub = null;

        public H_Frm_Club_Main()
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        private void LoadAllClubFromDB()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bll.H_GetAllClubFromDB(ref err);
                dgvClub.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadAllClubFromDB: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void H_Frm_Club_Main_Load(object sender, EventArgs e)
        {
            LoadAllClubFromDB();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadAllClubFromDB();
        }

        private void updateClub()
        {
            if (drClub != null)
            {
                H_Frm_Club_Modify frm = new H_Frm_Club_Modify(true, drClub);
                frm.ShowDialog();
                LoadAllClubFromDB();
            }
            else
                MessageBox.Show("Vui lòng chọn phòng tập cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            H_Frm_Club_Modify frm = new H_Frm_Club_Modify();
            frm.ShowDialog();
            LoadAllClubFromDB();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateClub();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (drClub != null)
            {
                try
                {
                    int clubId = int.Parse(drClub["MaPhongTap"].ToString());
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool result = bll.H_DeleteClub(ref err, clubId);
                        if (result)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllClubFromDB();
                        }
                        else
                            MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at btnDelete_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng tập cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    dgvClub.ExportToXlsx(saveFile.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form H_Club_Main: btnExportToXls_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void gvClub_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            drClub = gvClub.GetDataRow(e.RowHandle);
        }

        private void gvClub_DoubleClick(object sender, EventArgs e)
        {
            updateClub();
        }
    }
}