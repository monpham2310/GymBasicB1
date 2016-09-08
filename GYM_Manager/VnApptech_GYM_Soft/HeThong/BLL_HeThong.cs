using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrarySoft;
using System.Data;
using System.Data.SqlClient;

namespace VnApptech_GYM_Soft.HeThong
{
    public partial class BLL_HeThong
    {
        cls_Database data;
        public BLL_HeThong(string path)
        {
            data = new cls_Database(path);
        }
        public BLL_HeThong(string path, ref string servername, ref string databasename, ref string userid, ref string pass)
        {
            data = new cls_Database(path, ref servername, ref databasename, ref userid, ref pass);
        }
        #region form login
        public bool kiemtraketnoi()
        {
            return data.kiemtraketnoi();
        }
        public DataTable laytaikhoan(ref string err)
        {
            return data.GetDataTable("Select distinct TenDangNhap from NhanVien", CommandType.Text, ref err, null);
        }
        public DataTable Laycalamviec(ref string err)
        {
            return data.GetDataTable("B1_PSP_CaLamViec_GetData", CommandType.StoredProcedure, ref err, null);
        }
        
        public DataTable LayThongTinDangNhap(ref string err, string taikhoan, string matkhau)
        {
            return data.GetDataTable("B1_PSP_LayThongTinDangNhap", CommandType.StoredProcedure, ref err, new SqlParameter("@taikhoan", taikhoan), new SqlParameter("@matkhau", matkhau));
        }

        public DataTable ChiTietLamViecNhanVien_insert(string macalamviec,string manhanvien,string ghichu,string giovao)
        {
            return data.GetDataTable("B1_PSP_ChiTietLamViecNhanVien_Insert", CommandType.StoredProcedure
                , new SqlParameter("@MaNhanVien", manhanvien)
                , new SqlParameter("@MaCaLamViec", macalamviec)
                , new SqlParameter("@GhiChu", ghichu)
                , new SqlParameter("@GioVao", giovao));
        }

        public bool capnhatgioracuanhanvien(ref string err,string manhanvien,int macalamviec,string giora)
        {
            return data.MyExcuteNonQuery("B1_PSP_CapNhatRaCuaNhanVien", CommandType.StoredProcedure, ref err,  new SqlParameter("@MaNhanVien", manhanvien)
                , new SqlParameter("@MaCaLamViec", macalamviec),new SqlParameter("@GioRa",giora));
        }
        #endregion

        #region Form sao lưu phục hồi
        public bool saoluu(ref string err, string path)
        {
            return data.MyExcuteNonQuery("PSP_Backup", CommandType.StoredProcedure, ref err, new SqlParameter("@duongdan", path));
        }
        public bool phuchoi(string sql, ref string err)
        {
            return data.MyExcuteNonQuery(sql, CommandType.Text, ref err, null);
        }
        #endregion

        #region Form cấu hình
        #endregion

        #region form đổi mật khẩu
        public bool doimatkhau(string username, string pass)
        {
          return data.MyExcuteNonQuery("B1_PSP_DoiMatKhau", CommandType.StoredProcedure, new SqlParameter("@taikhoan", username), new SqlParameter("@matkhau", pass));
        }

        #endregion

        #region form ketnoi
        public void ghichuoiketnoi(string path, string servername, string databasename, string uid, string pass)
        {
            data.ghichuoiketnoi(path, servername, databasename, uid, pass);
        }

        /// <summary>
        /// Phương thức lấy giá trị phần quyền trên từng form để phần quyền.
        /// Mỗi form có 4 quyền
        /// 1. view (1)
        /// 2. Thêm (2)
        /// 3. Sửa (4)
        /// 4. Xóa (8)
        /// </summary>
        /// <param name="err">Biến lưu lỗi</param>
        /// <param name="mataikhoan">Tài khoản người dùng khi đăng nhập</param>
        /// <param name="TenForm">Tên của form</param>
        /// <returns>Giá trị quyền</returns>
        public  object GetPermission(ref string err, int mataikhoan, string TenForm)
        {
            return data.myExcute_Scalar("B1_PSP_PhanQuyen_LayGiaTriPhanQuyen", System.Data.CommandType.StoredProcedure, ref err, new SqlParameter("@MaTaiKhoan", mataikhoan), new SqlParameter("@KyHieu", TenForm));
        }

        public DataTable GetChucNang(ref string err)
        {
            return data.GetDataTable("B1_PSP_PhanQuyen_Select", CommandType.StoredProcedure, null);
        }
        public bool CapNhat(ref string err, int machucnang, int mataikhoan, int giatriquyen)
        {
            return data.MyExcuteNonQuery("B1_PSP_PhanQuyen_Update", CommandType.StoredProcedure, ref err, new SqlParameter("@MaTaiKhoan", mataikhoan), new SqlParameter("@MaChucNang", machucnang), new SqlParameter("@GiaTriQuyen", giatriquyen));
        }
        #endregion
    }
}
