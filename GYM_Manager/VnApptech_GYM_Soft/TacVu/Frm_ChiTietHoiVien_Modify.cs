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
    public partial class Frm_ChiTietHoiVien_Modify : DevExpress.XtraEditors.XtraForm
    {
        private BLL_TacVu bll = new BLL_TacVu(cls_Main.pathconnect);

        private string _MaHD, _MaHV, _TenHV, _MaThe, _DienThoai, _Email, _DiaChi, _GoiTap, _PhongTap, _ConLai, _DonGia, _GiamGia, _ThanhTien, _NhanVien, _NVKD;
        private bool _GioiTinh;
        private DateTime _NamSinh, _NgayBD, _NgayKT;

        public Frm_ChiTietHoiVien_Modify()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 01/10/2016
        /// Content: Thêm dữ liệu vào from sau khi khởi tạo.
        /// </summary>
        /// <param name="_MaHD"></param>
        /// <param name="_MaHV"></param>
        /// <param name="_TenHV"></param>
        /// <param name="_MaThe"></param>
        /// <param name="_GioiTinh"></param>
        /// <param name="_DienThoai"></param>
        /// <param name="_Email"></param>
        /// <param name="_DiaChi"></param>
        /// <param name="_GoiTap"></param>
        /// <param name="_PhongTap"></param>
        /// <param name="_ConLai"></param>
        /// <param name="_DonGia"></param>
        /// <param name="_GiamGia"></param>
        /// <param name="_ThanhTien"></param>
        /// <param name="_NhanVien"></param>
        /// <param name="_NVKD"></param>
        /// <param name="_NamSinh"></param>
        /// <param name="_NgayBD"></param>
        /// <param name="_NgayKT"></param>
        public void Init(string _MaHD, string _MaHV, string _TenHV, string _MaThe, bool _GioiTinh, string _DienThoai, string _Email, string _DiaChi, string _GoiTap, string _PhongTap, string _ConLai, string _DonGia, string _GiamGia, string _ThanhTien, string _NhanVien, string _NVKD, DateTime _NamSinh, DateTime _NgayBD, DateTime _NgayKT)
        {
            this._MaHD = _MaHD;
            this._MaHV = _MaHV;
            this._TenHV = _TenHV;
            this._MaThe = _MaThe; 
            this._GioiTinh = _GioiTinh; 
            this._DienThoai = _DienThoai; 
            this._Email = _Email; 
            this._DiaChi = _DiaChi; 
            this._GoiTap = _GoiTap; 
            this._PhongTap = _PhongTap; 
            this._ConLai = _ConLai; 
            this._DonGia = _DonGia; 
            this._GiamGia = _GiamGia; 
            this._ThanhTien = _ThanhTien; 
            this._NhanVien = _NhanVien; 
            this._NVKD = _NVKD;
            this._NamSinh = _NamSinh;
            this._NgayBD = _NgayBD;
            this._NgayKT = _NgayKT;
            btnluu.Enabled = true;
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
            btnluu.Enabled = false;
        }

        private void Frm_ChiTietHoiVien_Modify_Load(object sender, EventArgs e)
        {
            addDataToFrom();
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create date: 01/10/2016
        /// Content: Hiển thị thông tin chi tiết gói tập của các hội viên
        /// </summary>
        private void addDataToFrom()
        {
            txt_MaHD.Text = _MaHD;
            txt_DiaChi.Text = _DiaChi;
            txt_DienThoai.Text = _DienThoai;
            txt_MaHV.Text = _MaHV;
            txt_Mail.Text = _Email;
            txt_MaThe.Text = _MaThe;
            txt_TenHV.Text = _TenHV;
            lbl_ConLai.Text = _ConLai;
            lbl_DonGia.Text = _DonGia;
            lbl_GiamGia.Text = _GiamGia;
            lbl_GoiTap.Text = _GoiTap;
            lbl_NV.Text = _NhanVien;
            lbl_NVKD.Text = _NVKD;
            lbl_PhongTap.Text = _PhongTap;
            lbl_ThanhTien.Text = _ThanhTien;
            date_NamSinh.Value = _NamSinh;
            date_NgayBD.Value = _NgayBD;
            date_NgayKT.Value = _NgayKT;
            if (_GioiTinh)
                rad_Nam.Checked = true;
            else rad_Nu.Checked = true;
        }

        /// <summary>
        // Creater: JDT Đỗ Tín
        /// Create date: 01/10/2016
        /// Content: Lưu dữ liệu hội viên sau khi sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Sửa lại dữ liệu gói tập của hội viên! Bạn có chắc rằng muốn thực hiện điều đó?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable _mytable = new DataTable();
                _mytable = bll.JDT_Update_ChiTietHocVienMember(_MaHD, date_NgayKT.Value);
                if (_mytable.Rows.Count != 0)
                    MessageBox.Show(_mytable.Rows[0]["ErrMsg"].ToString(), "Thông Báo");
            }
        }
    }
}
