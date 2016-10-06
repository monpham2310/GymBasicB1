using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrarySoft;
using System.Data;
using System.Data.SqlClient;

namespace VnApptech_GYM_Soft.TacVu
{
    /// <summary>
    /// Người tạo:Nguyễn Minh Phúc
    /// Ngày tạo:29-08-2016
    /// Người sửa:
    /// Ngày sửa:
    /// Nội dung sửa:
    /// 
    /// 
    /// </summary>
    public partial class BLL_TacVu
    {
        cls_Database data;
        public BLL_TacVu(string path )
        {
            data = new cls_Database(path);
        }
        //Viết code cho lớp tại đây

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create Date: 30/09/2016
        /// Content: Load thông tin chi tiết của các học viên
        /// </summary>
        /// <returns> Trả về một table chứa thông tin các học viên</returns>
        public DataTable JDT_Load_ChiTietHocVienMember()
        {
            return data.GetDataTable("JDT_Load_ThongTinHocVienMember",CommandType.StoredProcedure,null);
        }

        /// <summary>
        /// Creater: JDT Đỗ Tín
        /// Create Date: 30/09/2016
        /// Content: Xóa thông tin chi tiết của một học viên
        /// </summary>
        /// <param name="MaHD">Mã hóa đơn của học viên member</param>
        /// <returns>Trả về table là một kết quả xóa thành công hay thất bại</returns>
        public DataTable JDT_Delete_ChiTietHocVienMember(string MaHD)
        {
            return data.GetDataTable("JDT_Delete_ThongTinHocVienMember", CommandType.StoredProcedure, new SqlParameter("@MaHD",MaHD));
        }

        public DataTable JDT_Update_ChiTietHocVienMember(string MaHD, DateTime NgayKT)
        {
            return data.GetDataTable("JDT_Update_ThongTinHocVienMember", CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD), new SqlParameter("@NgayHetHan", NgayKT));
        }
    }
}
