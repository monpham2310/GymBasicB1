using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrarySoft;
using System.Data;
using System.Data.SqlClient;

namespace VnApptech_GYM_Soft.ThongKe
{
    /// <summary>
    /// Người tạo:
    /// Ngày tạo:
    /// Người sửa:
    /// Ngày sửa:
    /// Nội dung sửa:
    /// 
    /// 
    /// </summary>
  public partial  class BLL_ThongKe
    {
      cls_Database data;
      public BLL_ThongKe(string path)
      {
          data = new cls_Database(path);
      }
      //Viết code cho lớp tại đây

      /// <summary>
      /// Creater: JDT Đỗ Tín
      /// Create date: 01/10/2016
      /// Content: Hiển thị chi tiết vào phòng của toàn bộ học viên
      /// </summary>
      /// <param name="From">Từ ngày nào</param>
      /// <param name="To">Đến ngày nào</param>
      /// <returns>Trả về table chứa kết quả là chi tiết toàn bộ thông tin</returns>
      public DataTable JDT_HoiVien_ChiTietVaoPhong(DateTime From, DateTime To)
      {
          return data.GetDataTable("JDT_HocVien_ChiTietVaoPhong_ViewAll", CommandType.StoredProcedure, new SqlParameter("@From",From), new SqlParameter("@To",To));
      }
    }
}
