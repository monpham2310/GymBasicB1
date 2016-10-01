using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.ThongKe
{
    public partial class Frm_BangKeLichSuRaVaoTheoThoiGian : DevExpress.XtraEditors.XtraForm
    {
        BLL_ThongKe bll = new BLL_ThongKe(cls_Main.pathconnect);


        public Frm_BangKeLichSuRaVaoTheoThoiGian()
        {
            InitializeComponent();
        }
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        private void Frm_BangKeLichSuRaVaoTheoThoiGian_Load(object sender, EventArgs e)
        {
            date_From.Value = DateTime.Now;
            date_To.Value = DateTime.Now;
            statisticInOutOfMember();
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 1/10/2016
        /// Content: Xuất excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls";
                saveFileDialog1.Title = "Save an File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    dgvlichsuravao.ExportToXls(saveFileDialog1.FileName);
                }
            }
            catch (Exception) { MessageBox.Show("Xin thử lại!"); }
        }

        private void btnthongke_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            statisticInOutOfMember();
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 1/10/2016
        /// Content: Hiển thị thông tin chi tiết ra vào của các hội viên
        /// </summary>
        private void statisticInOutOfMember()
        {
            try
            {
                DataTable _mytable = new DataTable();
                _mytable = bll.JDT_HoiVien_ChiTietVaoPhong(date_From.Value, date_To.Value);
                for (int i = 0; i < _mytable.Rows.Count; i++)
                {
                    _mytable.Rows[i]["STT"] = i + 1;
                }
                if (_mytable.Rows.Count == 0)
                    MessageBox.Show("Dữ liệu hiện tại chưa có, xin thử lại!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvlichsuravao.DataSource = _mytable;
            }
            catch { }
        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }
    }
}
