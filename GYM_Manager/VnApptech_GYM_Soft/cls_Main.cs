using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using VnApptech_GYM_Soft.HeThong;

namespace VnApptech_GYM_Soft
{
    public partial class cls_Main
    {
        #region Các biến toàn cục
        //các biến về cấu hình ban đầu của chương trình
        //các biến này được lưu trong file config.ini
        //---------------07-09-2016------------------
        public static string title = "";
        public static int numberCard = 0;//số ký tự của mã vạch và rfid
        public static int deviceType = 0;//0:mã vạch và mã rfid 125;1:vân tay; 2: mã rfid 13.5
        //-------------------------------------------------------------------------------
        public static string chuoimahoaDemo = "";//chuỗi ký tự lưu khi chưa có key
        public static int songayconlai = 0;
        
        public static bool dangxuat = false;//lưu trạng thái đăng xuất của chương trình; nếu là false chưa đăng xuất
        public static bool thoat = false;//lưu trạng thái thoát của chương trình
        public static string err = "";//lưu thông tin lỗi của tất cả các lỗi.
        //Thiết bị
        public static string pathconnect = Application.StartupPath + @"\Connect.ini";//lưu đường dẫn chuỗi kết nối.
        //lưu đường dẫn file cấu hình.
        public static string pathconfig = Application.StartupPath + @"\Config.ini";
        
        //form
        public static Frm_Main Frm_Main;
        public static Frm_Login frmLogin;
        //thông tin đăng nhập
        public static int maCaLamViec;
        public static string tenCaLamViec;
        //Lưu thông tin kết nối
        public static string maNhanVien, tenNhanVien, tenDangNhap, maTaiKhoan;
        #region Các biến để lưu giá trị của chuỗi kết nối
        public static string serverName = "";
        public static string database = "";
        public static string uid = "";
        public static string pass = "";

       
        #endregion
        #endregion

        #region Các phương thức tĩnh
        static BLL_HeThong bd = new BLL_HeThong(pathconnect);
        public static int GetPermission(ref string err, int mataikhoan, string tenfrm)
        {
            object o = null;
            o = bd.GetPermission(ref err, mataikhoan, tenfrm);
            if (o != null)
            {
                return (int)o;
            }
            else
            {
                return 0;
            }
        }
        public static void docfilecauhinh(ref string err, string path)
        {
            try
            {
                using (StreamReader _reader = new StreamReader(path))
                {
                    string line = "";
                    while ((line = _reader.ReadLine()) != null)
                    {
                        switch (line.Substring(0, line.IndexOf('=')).ToLower())
                        {
                            case "numbercard":
                                numberCard = Convert.ToInt32(line.Substring(line.IndexOf('=') + 1));
                                break;
                            case "title":
                                title = line.Substring(line.IndexOf('=') + 1);
                                break;
                            case "devicetype":
                                deviceType = Convert.ToInt32(line.Substring(line.IndexOf('=') + 1));
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }
        public static bool ghifiletxt(string path, ref string err, params string[] param)
        {
            try
            {
                using (StreamWriter _write = new StreamWriter(path))
                {
                    if (param != null)
                        foreach (string item in param)
                        {
                            _write.WriteLine(item);
                        }
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public static void inloi(Label lblerr, string err)
        {
            lblerr.ForeColor = Color.Red;
            lblerr.Text = err;
        }
        public static void inloi(DevExpress.XtraBars.BarStaticItem lblerr, string err)
        {
            lblerr.Appearance.ForeColor = Color.Red;
            lblerr.Caption = err;
        }
        #endregion

       
    }
}
