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
    public partial class H_Frm_Practice_Main : DevExpress.XtraEditors.XtraForm
    {
        private IBLL_DanhMuc bll;
        private string err = "";
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private DataRow drPractice = null;

        public H_Frm_Practice_Main()
        {
            InitializeComponent();
            bll = new BLL_DanhMuc(cls_Main.pathconnect);
        }

        private void LoadAllPracticeFromDB()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bll.H_GetAllPracticeFromDB(ref err);
                dgvPractice.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error at LoadAllPracticeFromDB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void H_Frm_Practice_Main_Load(object sender, EventArgs e)
        {
            LoadAllPracticeFromDB();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (drPractice != null)
            {
                try
                {
                    int practiceId = int.Parse(drPractice["MaMonTap"].ToString());
                    bool result = bll.H_DeletePractice(ref err, practiceId);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllPracticeFromDB();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at btnDelete_ItemClick: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn tập cần xóa.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadAllPracticeFromDB();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            H_Frm_Practice_Modify frm = new H_Frm_Practice_Modify();
            frm.ShowDialog();
            LoadAllPracticeFromDB();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (drPractice != null)
            {
                H_Frm_Practice_Modify frm = new H_Frm_Practice_Modify(true, drPractice);
                frm.ShowDialog();
                LoadAllPracticeFromDB();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn tập.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    dgvPractice.ExportToXlsx(saveFile.FileName);

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

        private void gvPractice_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            drPractice = gvPractice.GetDataRow(e.RowHandle);
        }

        private void gvPractice_DoubleClick(object sender, EventArgs e)
        {
            if (drPractice != null)
            {
                H_Frm_Practice_Modify frm = new H_Frm_Practice_Modify(true, drPractice);
                frm.ShowDialog();
                LoadAllPracticeFromDB();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn tập.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
                
    }
}