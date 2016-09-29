using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyLibrarySoft;
using System.Data.SqlClient;

namespace VnApptech_GYM_Soft.DanhMuc
{
    public interface IBLL_DanhMuc
    {
        DataTable H_GetMemberPackageList(ref string err);
        bool H_DeleteMemberPackage(ref string err, int packageId);
        DataTable H_GetAllRooms(ref string err);
        DataTable H_GetAllSubjects(ref string err);
        DataTable H_GetAllPackageType(ref string err);
        bool H_UpdateMemberPackage(ref string err, int packageId, string packageName, int roomId, int subjectId, int packageType, long dayNumber, long price, DateTime startTime, DateTime endTime, int type, long turnNumber);
        bool H_AddMemberPackage(ref string err, string packageName, int roomId, int subjectId, int packageType, long dayNumber, long price, DateTime startTime, DateTime endTime, int type, long turnNumber);
    }

    public partial class BLL_DanhMuc : IBLL_DanhMuc
    {        
        //viết những phương phức trong phần danh mục ở đây.
        public DataTable H_GetMemberPackageList(ref string err)
        {
            return data.GetDataTable("HSP_GetMemberPackageList", CommandType.StoredProcedure, ref err);
        }

        public bool H_DeleteMemberPackage(ref string err, int packageId)
        {
            return data.MyExcuteNonQuery("HSP_DeleteMemberPackage", CommandType.StoredProcedure, ref err, new SqlParameter("@packageId", packageId));
        }

        public DataTable H_GetAllRooms(ref string err)
        {
            return data.GetDataTable("HSP_GetAllRooms", CommandType.StoredProcedure, ref err);
        }

        public DataTable H_GetAllSubjects(ref string err)
        {
            return data.GetDataTable("HSP_GetAllSubjects", CommandType.StoredProcedure, ref err);
        }

        public DataTable H_GetAllPackageType(ref string err)
        {
            return data.GetDataTable("HSP_GetAllPackageType", CommandType.StoredProcedure, ref err);
        }

        public bool H_UpdateMemberPackage(ref string err, int packageId, string packageName, int roomId, int subjectId, int packageType, long dayNumber, long price, DateTime startTime, DateTime endTime, int type, long turnNumber)
        {
            return data.MyExcuteNonQuery("HSP_UpdateMemberPackage", CommandType.StoredProcedure, ref err, new SqlParameter("@packageId", packageId)
                                        , new SqlParameter("@packageName", packageName)
                                        , new SqlParameter("@roomId", roomId)
                                        , new SqlParameter("@subjectId", subjectId)
                                        , new SqlParameter("@packageType", packageType)
                                        , new SqlParameter("@dayNumber", dayNumber)
                                        , new SqlParameter("@price", price)
                                        , new SqlParameter("@startTime", startTime)
                                        , new SqlParameter("@endTime", endTime)
                                        , new SqlParameter("@type", type)
                                        , new SqlParameter("@turnNumber", turnNumber));
        }

        public bool H_AddMemberPackage(ref string err, string packageName, int roomId, int subjectId, int packageType, long dayNumber, long price, DateTime startTime, DateTime endTime, int type, long turnNumber)
        {
            return data.MyExcuteNonQuery("HSP_AddMemberPackage", CommandType.StoredProcedure, ref err
                                        , new SqlParameter("@packageName", packageName)
                                        , new SqlParameter("@roomId", roomId)
                                        , new SqlParameter("@subjectId", subjectId)
                                        , new SqlParameter("@packageType", packageType)
                                        , new SqlParameter("@dayNumber", dayNumber)
                                        , new SqlParameter("@price", price)
                                        , new SqlParameter("@startTime", startTime)
                                        , new SqlParameter("@endTime", endTime)
                                        , new SqlParameter("@type", type)
                                        , new SqlParameter("@turnNumber", turnNumber));
        }
    }
}
