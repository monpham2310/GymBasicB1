using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrarySoft;
using System.Data.SqlClient;
using System.Data;

namespace VnApptech_GYM_Soft.DanhMuc
{
    public partial class BLL_DanhMuc
    {
        cls_Database data;
        public BLL_DanhMuc(string path)
        {
            data = new cls_Database(path);
        }

        #region Lưu trữ thông tin về ca làm việc
        /// <summary>
        /// Ngày tạo: 29-08-2016
        /// Người tạo: Nguyễn Minh Phúc
        /// Phương thức lấy thông tin danh sách ca làm việc
        /// 
        /// </summary>
        /// <param name="err">Biến tham chiếu lưu lỗi</param>
        /// <returns>Trả về dữ liệu danh sách ca làm việc của tất cả nhân viên</returns>
        public DataTable LayThongTinDanhSachCaLamViec(ref string err)
        {
            return data.GetDataTable("B1_Psp_CaLamViec_selectall", CommandType.StoredProcedure, ref err);
        }
        /// <summary>
        /// Ngày tạo: 29-08-2016
        /// Người tạo: Nguyễn Minh Phúc
        /// Phương thức thêm ca làm việc cho danh mục ca làm việc
        /// </summary>
        /// <param name="gioBatDau">Giờ bắt đầu ca làm việc</param>
        /// <param name="gioKetThuc">Giờ kết thúc ca làm việc</param>
        /// <param name="ghiChu">Ghi chú trên ca làm việc</param>
        /// <param name="tinhTrang">Tình trạng còn sử dụng hay không sử dụng của ca làm việc; 1: Còn sử dụng; 0: không còn sử dụng</param>
        /// <returns>Nếu thêm thành công trả về true, ngược lại trả về false</returns>
        public bool ThemCaLamViec(string gioBatDau, string gioKetThuc, string ghiChu, int tinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_CaLamViec_Insert", CommandType.StoredProcedure,
                                    new SqlParameter("@GioBatDau", gioBatDau),
                                    new SqlParameter("@GioKetThuc", gioKetThuc),
                                    new SqlParameter("@GhiChu", ghiChu),
                                    new SqlParameter("@TinhTrang", tinhTrang));
        }
        /// <summary>
        /// Ngày tạo: 29-08-2016
        /// Người tạo: Nguyễn Minh Phúc
        /// ----------------------------
        /// - Phương thức để xóa ca làm việc theo mã ca làm việc
        /// </summary>
        /// <param name="maCaLamViec">Mã ca làm việc kiểu số</param>
        /// <returns>Nếu xóa được trả về true, ngược lại trả về false</returns>
        public bool XoaCaLamViecTheoMaCaLamViec(int maCaLamViec)
        {
            return data.MyExcuteNonQuery("B1_PSP_CaLamViec_Delete_MaCaLamViec", CommandType.StoredProcedure,
                                    new SqlParameter("@MaCaLamViec", maCaLamViec));
        }
        /// <summary>
        /// Ngày tạo: 29-08-2016
        /// Người tạo: Nguyễn Minh Phúc
        /// -----------------------------
        /// Phương thức lấy ca làm việc theo mã ca làm việc
        /// </summary>
        /// <param name="maCaLamViec">Mã ca làm việc</param>
        /// <param name="err">Biến lưu lỗi</param>
        /// <returns>Trả về ca làm việc của ca làm việc theo mã số</returns>
        public DataTable LayThongTinCaLamViecTheoMaCaLamViec(ref string err,int maCaLamViec)
        {
            return data.GetDataTable("B1_PSP_CaLamViec_Select_MaCaLamViec", CommandType.StoredProcedure, ref err,
                                    new SqlParameter("@MaCaLamViec", maCaLamViec));
        }
       /// <summary>
        /// Ngày tạo: 29-08-2016
        /// Người tạo: Nguyễn Minh Phúc
        /// ---------------------------
        /// Phương thức sửa thông tin ca làm việc theo mã ca làm việc
       /// </summary>
       /// <param name="err">Biến lưu lỗi</param>
       /// <param name="maCaLamViec">mã ca làm việc</param>
       /// <param name="gioBatDau">giờ bắt đầu</param>
       /// <param name="gioKetThuc">giờ kết thúc</param>
       /// <param name="ghiChu">Ghi chú</param>
       /// <param name="tinhTrang">Tình trạng</param>
       /// <returns>Trả về true nếu sửa thành công, ngược lại trả về false</returns>
        public bool SuaThongTinCaLamViecTheoMaCaLamViec(ref string err,int maCaLamViec, string gioBatDau, string gioKetThuc, string ghiChu, int tinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_CaLamViec_Update_MaCaLamViec", CommandType.StoredProcedure,
                                    new SqlParameter("@MaCaLamViec", maCaLamViec),
                                    new SqlParameter("@GioBatDau", gioBatDau),
                                    new SqlParameter("@GioKetThuc", gioKetThuc),
                                    new SqlParameter("@GhiChu", ghiChu),
                                    new SqlParameter("@TinhTrang", tinhTrang));
        }
        #endregion

        #region Lưu trữ các hàm để cập nhật loại khách hàng
        public DataTable LayThongTinDanhSachLoaiKhachHang(ref string err)
        {
            return data.GetDataTable("B1_PSP_LoaiKhachHang_SelectAll", CommandType.StoredProcedure, ref err);
        }

        public bool ThemLoaiKhachHang(string tenLoaiKhach, string ghiChu, int tinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_LoaiKhachHang_Insert", CommandType.StoredProcedure,
                                    new SqlParameter("@TenLoaiKhach", tenLoaiKhach),
                                    new SqlParameter("@GhiChu", ghiChu),
                                    new SqlParameter("@TinhTrang", tinhTrang));
        }
        public bool XoaLoaiKhachHangTheoMaLoaiKhach(int maLoaiKhach)
        {
            return data.MyExcuteNonQuery("B1_PSP_LoaiKhachHang_Delete_MaLoaiKhach", CommandType.StoredProcedure,
                                    new SqlParameter("@MaLoaiKhach", maLoaiKhach));
        }
        public DataTable LayThongTinLoaiKhachHangTheoMaLoaiKhach(int maLoaiKhach, ref string err)
        {
            return data.GetDataTable("B1_PSP_LoaiKhachHang_Select_MaLoaiKhach", CommandType.StoredProcedure, ref err,
                                    new SqlParameter("@MaLoaiKhach", maLoaiKhach));
        }
        public bool SuaThongTinLoaiKhachHangTheoMaLoaiKhach(int maLoaiKhach, string tenLoaiKhach, string ghiChu, int tinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_LoaiKhachHang_Update_MaLoaiKhach", CommandType.StoredProcedure,
                                    new SqlParameter("@MaLoaiKhach", maLoaiKhach),
                                    new SqlParameter("@TenLoaiKhach", tenLoaiKhach),
                                    new SqlParameter("@GhiChu", ghiChu),
                                    new SqlParameter("@TinhTrang", tinhTrang));
        }
        #endregion

        #region Lưu trữ các hàm để cập nhật nhân viên
        public DataTable LayThongTinDanhSachNhanVien(ref string err)
        {
            return data.GetDataTable("B1_PSP_NhanVien_SelectAll", CommandType.StoredProcedure, ref err);
        }
        public bool ThemNhanVien(string tenNhanVien, int Phai, DateTime NamSinh, string DienThoai, string TenDangNhap, int MaTaiKhoan, string matKhau, int TinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_NhanVien_Insert", CommandType.StoredProcedure,
                                    new SqlParameter("@TenNhanVien", tenNhanVien),
                                    new SqlParameter("@Phai", Phai),
                                    new SqlParameter("@NamSinh", NamSinh),
                                    new SqlParameter("@DienThoai", DienThoai),
                                    new SqlParameter("@TenDangNhap", TenDangNhap),
                                     new SqlParameter("@MaTaiKhoan", MaTaiKhoan),
                                     new SqlParameter("@MatKhau", matKhau),
                                    new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool XoaNhanVienTheoMaNhanVien(int maNhanVien)
        {
            return data.MyExcuteNonQuery("B1_PSP_NhanVien_Delete_MaNhanVien", CommandType.StoredProcedure,
                                    new SqlParameter("@MaNhanVien", maNhanVien));
        }
        public DataTable LayThongTinNhanVienTheoMaNhanVien(int maNhanVien, ref string err)
        {
            return data.GetDataTable("B1_PSP_NhanVien_Select_MaNhanVien", CommandType.StoredProcedure, ref err,
                                    new SqlParameter("@MaNhanVien", maNhanVien));
        }
        public bool SuaThongTinNhanVienTheoMaNhanVien(int maNhanVien, string tenNhanVien, int phai, DateTime namSinh, string dienThoai, string tenDangNhap, int maTaiKhoan, int tinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_NhanVien_Update_MaNhanVien", CommandType.StoredProcedure,
                                    new SqlParameter("@MaNhanVien", maNhanVien),
                                    new SqlParameter("@TenNhanVien", tenNhanVien),
                                    new SqlParameter("@Phai", phai),
                                    new SqlParameter("@NamSinh", namSinh),
                                    new SqlParameter("@DienThoai", dienThoai),
                                    new SqlParameter("@TenDangNhap", tenDangNhap),
                                    new SqlParameter("@MaTaiKhoan", maTaiKhoan),
                                    new SqlParameter("@TinhTrang", tinhTrang));
        }
        #endregion

        #region Lưu trữ các hàm để cập nhật tài khoản
        public DataTable LayThongTinDanhSachTaiKhoan(ref string err)
        {
            return data.GetDataTable("B1_PSP_TaiKhoan_SelectAll", CommandType.StoredProcedure, ref err);
        }

        public bool ThemTaiKhoan(string tenTaiKhoan, int TinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_TaiKhoan_Insert", CommandType.StoredProcedure,
                                    new SqlParameter("@TenTaiKhoan", tenTaiKhoan),
                                    new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool XoaTaiKhoanTheoMaTaiKhoan(int maTaiKhoan)
        {
            return data.MyExcuteNonQuery("B1_PSP_TaiKhoan_Delete_MaTaiKhoan", CommandType.StoredProcedure,
                                    new SqlParameter("@MaTaiKhoan", maTaiKhoan));
        }
        public DataTable LayThongTinTaiKhoanTheoMaTaiKhoan(int maTaiKhoan, ref string err)
        {
            return data.GetDataTable("B1_PSP_TaiKhoan_Select_MaTaiKhoan", CommandType.StoredProcedure, ref err,
                                    new SqlParameter("@MaTaiKhoan", maTaiKhoan));
        }
        public bool SuaThongTinTaiKhoanTheoMaTaiKhoan(int maTaiKhoan, string tenTaiKhoan, int tinhTrang)
        {
            return data.MyExcuteNonQuery("B1_PSP_TaiKhoan_Update_MaTaiKhoan", CommandType.StoredProcedure,
                                    new SqlParameter("@MaTaiKhoan", maTaiKhoan),
                                    new SqlParameter("@TenTaiKhoan", tenTaiKhoan),
                                    new SqlParameter("@TinhTrang", tinhTrang));
        }
        #endregion
    }
}
