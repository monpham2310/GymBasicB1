using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DLLDungChung;

namespace VnApptech_GYM_Soft.TacVu
{
    public interface IBLL_TacVu
    {
        DataTable GetMemberListFromDB(ref string err);
        bool DeleteMemberToDB(ref string err, int memberId);
        bool UpdateMemberDataToDB(ref string err, int memberId, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address, byte[] imageData);
        bool UpdateMemberDataNoneImgToDB(ref string err, int memberId, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address);
        bool AddMemberDataToDB(ref string err, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address, byte[] imageData);
        bool AddMemberDataNoneImgToDB(ref string err, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address);
        DataTable H_GetHistoryInOutFromDB(ref string err, int clubId);
    }

    public partial class BLL_TacVu : IBLL_TacVu
    {
        public DataTable GetMemberListFromDB(ref string err)
        {
            return data.GetDataTable("HSP_GetMemberList", CommandType.StoredProcedure, ref err);
        }

        public bool DeleteMemberToDB(ref string err, int memberId) 
        {
            return data.MyExcuteNonQuery("HSP_DeleteMember", CommandType.StoredProcedure, ref err, new SqlParameter("@MemberId", memberId));
        }

        public bool UpdateMemberDataToDB(ref string err, int memberId, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address, byte[] imageData)
        {
            string lastName = DLLDungChung.XuLyChuoi.tachho(memberName);
            string firstName = DLLDungChung.XuLyChuoi.tachten(memberName);
            return data.MyExcuteNonQuery("HSP_UpdateMemberData", CommandType.StoredProcedure, ref err, new SqlParameter("@MemberId", memberId)
                                        , new SqlParameter("@LastName", lastName)
                                        , new SqlParameter("@FirstName", firstName)
                                        , new SqlParameter("@Barcode", barcode)
                                        , new SqlParameter("@Gender", gender)
                                        , new SqlParameter("@IdCard", idCard)
                                        , new SqlParameter("@Birthday", birthday)
                                        , new SqlParameter("@Phone", phone)
                                        , new SqlParameter("@Email", email)
                                        , new SqlParameter("@Address", address)
                                        , new SqlParameter("@Image", imageData));
        }

        public bool UpdateMemberDataNoneImgToDB(ref string err, int memberId, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address)
        {
            string lastName = DLLDungChung.XuLyChuoi.tachho(memberName);
            string firstName = DLLDungChung.XuLyChuoi.tachten(memberName);
            return data.MyExcuteNonQuery("HSP_UpdateMemberDataNoneImg", CommandType.StoredProcedure, ref err, new SqlParameter("@MemberId", memberId)
                                        , new SqlParameter("@LastName", lastName)
                                        , new SqlParameter("@FirstName", firstName)
                                        , new SqlParameter("@Barcode", barcode)
                                        , new SqlParameter("@Gender", gender)
                                        , new SqlParameter("@IdCard", idCard)
                                        , new SqlParameter("@Birthday", birthday)
                                        , new SqlParameter("@Phone", phone)
                                        , new SqlParameter("@Email", email)
                                        , new SqlParameter("@Address", address));
        }

        public bool AddMemberDataToDB(ref string err, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address, byte[] imageData)
        {
            string lastName = DLLDungChung.XuLyChuoi.tachho(memberName);
            string firstName = DLLDungChung.XuLyChuoi.tachten(memberName);
            return data.MyExcuteNonQuery("HSP_AddMemberData", CommandType.StoredProcedure, ref err
                                        , new SqlParameter("@LastName", lastName)
                                        , new SqlParameter("@FirstName", firstName)
                                        , new SqlParameter("@Barcode", barcode)
                                        , new SqlParameter("@Gender", gender)
                                        , new SqlParameter("@IdCard", idCard)
                                        , new SqlParameter("@Birthday", birthday)
                                        , new SqlParameter("@Phone", phone)
                                        , new SqlParameter("@Email", email)
                                        , new SqlParameter("@Address", address)
                                        , new SqlParameter("@Image", imageData));
        }

        public bool AddMemberDataNoneImgToDB(ref string err, string memberName, string barcode, bool gender, string idCard, DateTime birthday, string phone, string email, string address)
        {
            string lastName = DLLDungChung.XuLyChuoi.tachho(memberName);
            string firstName = DLLDungChung.XuLyChuoi.tachten(memberName);
            return data.MyExcuteNonQuery("HSP_AddMemberDataNoneImg", CommandType.StoredProcedure, ref err
                                        , new SqlParameter("@LastName", lastName)
                                        , new SqlParameter("@FirstName", firstName)
                                        , new SqlParameter("@Barcode", barcode)
                                        , new SqlParameter("@Gender", gender)
                                        , new SqlParameter("@IdCard", idCard)
                                        , new SqlParameter("@Birthday", birthday)
                                        , new SqlParameter("@Phone", phone)
                                        , new SqlParameter("@Email", email)
                                        , new SqlParameter("@Address", address));
        }

        public DataTable H_GetHistoryInOutFromDB(ref string err, int clubId)
        {
            return data.GetDataTable("B1_PSP_HienThiThongTinCheckin", CommandType.StoredProcedure, ref err, new SqlParameter("@maphongtap", clubId));
        }
    }
}
