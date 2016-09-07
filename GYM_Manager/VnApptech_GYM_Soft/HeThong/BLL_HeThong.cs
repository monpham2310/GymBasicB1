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
            return data.GetDataTable("PSP_CaLamViec_GetData", CommandType.StoredProcedure, ref err, null);
        }
        
        public DataTable LayThongTinDangNhap(ref string err, string taikhoan, string matkhau)
        {
            return data.GetDataTable("PSP_LayThongTinDangNhap", CommandType.StoredProcedure, ref err, new SqlParameter("@taikhoan", taikhoan), new SqlParameter("@matkhau", matkhau));
        }

        public DataTable ChiTietLamViecNhanVien_insert(string macalamviec,string manhanvien,string ghichu,string giovao)
        {
            return data.GetDataTable("PSP_ChiTietLamViecNhanVien_Insert", CommandType.StoredProcedure
                , new SqlParameter("@MaNhanVien", manhanvien)
                , new SqlParameter("@MaCaLamViec", macalamviec)
                , new SqlParameter("@GhiChu", ghichu)
                , new SqlParameter("@GioVao", giovao));
        }

        public bool capnhatgioracuanhanvien(ref string err,string manhanvien,int macalamviec,string giora)
        {
            return data.MyExcuteNonQuery("PSP_CapNhatRaCuaNhanVien", CommandType.StoredProcedure, ref err,  new SqlParameter("@MaNhanVien", manhanvien)
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
          return data.MyExcuteNonQuery("PSP_DoiMatKhau", CommandType.StoredProcedure, new SqlParameter("@taikhoan", username), new SqlParameter("@matkhau", pass));
        }

        #endregion

        #region form ketnoi
        public void ghichuoiketnoi(string path, string servername, string databasename, string uid, string pass)
        {
            data.ghichuoiketnoi(path, servername, databasename, uid, pass);
        }
        #endregion
    }
}
