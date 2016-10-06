using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.TacVu
{
    public partial class Frm_HoiVien_Main : DevExpress.XtraEditors.XtraForm
    {
        private IBLL_TacVu bll;
        private string err = "";
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private DataRow drMemberItem = null;

        public Frm_HoiVien_Main()
        {
            InitializeComponent();
            bll = new BLL_TacVu(cls_Main.pathconnect);
        }        

        private void LoadDataFromDB()
        {
            DataTable dt = new DataTable();
            dt = bll.GetMemberListFromDB(ref err);
            dgvHoiVienList.DataSource = dt;
        }

        private void UpdateMemberItem()
        {
            if (drMemberItem != null)
            {
                Frm_HoiVien_Modify frm = new Frm_HoiVien_Modify(drMemberItem);
                frm.ShowDialog();
                LoadDataFromDB();
                drMemberItem = null;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hội viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_HoiVien_Main_Load(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }

        private void btnrefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataFromDB();
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_HoiVien_Modify frm = new Frm_HoiVien_Modify();
            frm.ShowDialog();
            LoadDataFromDB();
        }

        private void btnupdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateMemberItem();           
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa hội viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (drMemberItem != null)
                {
                    int memberId = int.Parse(drMemberItem["MaHoiVien"].ToString());
                    bool result = bll.DeleteMemberToDB(ref err, memberId);
                    if (result)
                    {
                        MessageBox.Show("Xóa hội viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataFromDB();
                        return;
                    }
                    MessageBox.Show("Xóa hội viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hội viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel|*.xls";
                saveFile.Title = "Save an File";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    dgvHoiVienList.ExportToXlsx(saveFile.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Form H_HoiVien_Main: btnxuatexcel_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncaplaithe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void gvMemberList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gvMemberList.GetDataRow(e.RowHandle);
            drMemberItem = dr;
        }

        private void gvMemberList_DoubleClick(object sender, EventArgs e)
        {
            UpdateMemberItem();
        }       
    }
}
