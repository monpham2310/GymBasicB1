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
    public partial class Frm_ChiTietHoiVien_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ChiTietHoiVien_Main()
        {
            InitializeComponent();
            Init();
        }
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private BLL_TacVu bll = new BLL_TacVu(cls_Main.pathconnect);

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 30/09/2016
        /// Content: Biến
        /// </summary>
        private bool _GioiTinh;
        private string _MaHD, _MaHV, _TenHV, _MaThe, _DienThoai, _Email, _DiaChi, _GoiTap, _PhongTap, _ConLai, _DonGia, _GiamGia, _ThanhTien, _NhanVien, _NVKD;
        private DateTime _NamSinh, _NgayBD, _NgayKT;

        private void Frm_ChiTietHoiVien_Main_Load(object sender, EventArgs e)
        {
            refresh_Data();
        }

        private void btnrefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refresh_Data();
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 30/09/2016
        /// Content: Hiển thị thông tin chi tiết của các hội viên
        /// 
        /// </summary>
        private void refresh_Data()
        {
            DataTable _mytable = new DataTable();
            _mytable = bll.JDT_Load_ChiTietHocVienMember();
            for (int i = 0; i < _mytable.Rows.Count; i++)
            {
                _mytable.Rows[i]["STT"] = i + 1;
            }
            dgvChiTietHoiVienList.DataSource = _mytable;
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 30/09/2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 30/09/2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_MaHD != null && !_MaHD.Equals(""))
                {
                    if (MessageBox.Show("Mọi dữ liệu liên quan đều sẽ bị xóa tất cả! Bạn có chắc rằng muốn thực hiện điều đó?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable _mytable = new DataTable();
                        _mytable = bll.JDT_Delete_ChiTietHocVienMember(_MaHD);
                        if (_mytable.Rows.Count != 0)
                            MessageBox.Show(_mytable.Rows[0]["ErrMsg"].ToString(), "Thông Báo");
                        refresh_Data();
                    }
                }
                else MessageBox.Show("Xin hãy chọn dữ liệu cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 30/09/2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvMemberPackage_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gvMemberPackage.GetDataRow(e.RowHandle);
                this._MaHD = dtr["MaHD"].ToString();
                this._MaHV = dtr["MaHoiVien"].ToString(); 
                this._TenHV = dtr["HoTen"].ToString(); 
                this._MaThe = dtr["MaThe"].ToString();
                this._GioiTinh = bool.Parse(dtr["GioiTinh"].ToString());
                this._DienThoai = dtr["DienThoai"].ToString(); 
                this._Email = dtr["Email"].ToString();
                this._DiaChi = dtr["DiaChi"].ToString();
                this._GoiTap = dtr["TenGoiTap"].ToString();
                this._PhongTap = dtr["TenPhongTap"].ToString();
                this._ConLai = dtr["NgayConLai"].ToString();
                this._DonGia = dtr["DonGia"].ToString(); 
                this._GiamGia = dtr["GiamGia"].ToString(); 
                this._ThanhTien = dtr["ThanhTien"].ToString(); 
                this._NhanVien = dtr["NhanVienTruc"].ToString(); 
                this._NVKD = dtr["NhanVienKD"].ToString(); 
                this._NamSinh = DateTime.Parse(dtr["NamSinh"].ToString());
                this._NgayBD = DateTime.Parse(dtr["NgayBatDau"].ToString());
                this._NgayKT = DateTime.Parse(dtr["NgayHetHan"].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng thử lại!\n" + ex.Message);
            }
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 30/09/2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_MaHD!=null&&!_MaHD.Equals(""))
                {
                    Frm_ChiTietHoiVien_Modify frm = new Frm_ChiTietHoiVien_Modify();
                    frm.Init(_MaHD, _MaHV, _TenHV, _MaThe, _GioiTinh, _DienThoai, _Email, _DiaChi, _GoiTap, _PhongTap, _ConLai, _DonGia, _GiamGia, _ThanhTien, _NhanVien, _NVKD, _NamSinh, _NgayBD, _NgayKT);
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else MessageBox.Show("Xin hãy chọn dữ liệu cần sửa", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch { }
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 01/10/2016
        /// Content: Khởi tạo giá trị rỗng
        /// </summary>
        public void Init()
        {
            this._MaHD = "";
            this._MaHV = "";
            this._TenHV = "";
            this._MaThe = "";
            this._GioiTinh = true;
            this._DienThoai = "";
            this._Email = "";
            this._DiaChi = "";
            this._GoiTap = "";
            this._PhongTap = "";
            this._ConLai = "";
            this._DonGia = "";
            this._GiamGia = "";
            this._ThanhTien = "";
            this._NhanVien = "";
            this._NVKD = "";
            this._NamSinh = DateTime.Now;
            this._NgayBD = DateTime.Now;
            this._NgayKT = DateTime.Now;
        }
    }
}
