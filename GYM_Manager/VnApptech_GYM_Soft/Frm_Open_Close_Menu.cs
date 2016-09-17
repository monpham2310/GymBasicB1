using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using DevExpress.XtraBars;

namespace VnApptech_GYM_Soft
{
    partial class Frm_Main
    {
        BarItemVisibility chuyenthuoctinh(bool trangthai)
        {
            if (trangthai == true)
                return BarItemVisibility.Always;
            return BarItemVisibility.Never;
        }
        private void phanquyentheogoi()
        {
            Hashtable menuhethong, menudanhmuc, menutacvu, menuthongke, menutrogiup;
            menuhethong = new Hashtable();
            menudanhmuc = new Hashtable();
            menutacvu = new Hashtable();
            menuthongke = new Hashtable();
            menutrogiup = new Hashtable();
            loadmenuhethong(ref menuhethong);
            loadmenudanhmuc(ref menudanhmuc);
            loadmenutacvu(ref menutacvu);
            loadmenuthongke(ref menuthongke);
            loadmenutrogiup(ref menutrogiup);

        }
        private void loadmenuhethong(ref Hashtable danhsachmenu)
        {
            using (StreamReader rd = new StreamReader(cls_Main.pathmenuhethong))
            {
                string line = "";

                while ((line = rd.ReadLine()) != null)
                {
                    danhsachmenu.Add(line.Substring(0, line.IndexOf('=')), line.Substring(line.IndexOf('=') + 1));
                }
            }
            //Ẩn hiện các control trên menu của form main
            foreach (string item in danhsachmenu.Keys)
            {
                switch (item)
                {
                    case "page_hethong"://Những trang
                        page_hethong.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;
                    case "group_thoat"://những group
                        group_thoat.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;
                    case "btnthoat"://cho các button trên memu
                        btnthoat.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "btndangxuat":
                        btndangxuat.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "btndoimatkhau":
                        btndoimatkhau.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "group_dulieu":
                        group_dulieu.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;
                    case "btnsaoluu":
                        btnsaoluu.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "btnphuchoi":
                        btnphuchoi.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "btnketnoi":
                        btnketnoi.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "btncauhinh":
                        btncauhinh.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                    case "btnphanquyen":
                        btnphanquyen.Visibility = chuyenthuoctinh(Convert.ToBoolean(danhsachmenu[item]));
                        break;
                }
            }
        }
        private void loadmenudanhmuc(ref Hashtable danhsachmenu)
        {
            using (StreamReader rd = new StreamReader(cls_Main.pathmenudanhmuc))
            {
                string line = "";

                while ((line = rd.ReadLine()) != null)
                {
                    danhsachmenu.Add(line.Substring(0, line.IndexOf('=')), line.Substring(line.IndexOf('=') + 1));
                }
            }
            //Ẩn hiện các control trên menu của form main
            foreach (string item in danhsachmenu.Keys)
            {
                switch (item)
                {
                    case "page_danhmuc"://Những trang
                        page_danhmuc.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;
                }
            }
        }
        private void loadmenutacvu(ref Hashtable danhsachmenu)
        {
            using (StreamReader rd = new StreamReader(cls_Main.pathmenutacvu))
            {
                string line = "";

                while ((line = rd.ReadLine()) != null)
                {
                    danhsachmenu.Add(line.Substring(0, line.IndexOf('=')), line.Substring(line.IndexOf('=') + 1));
                }
            }
            //Ẩn hiện các control trên menu của form main
            foreach (string item in danhsachmenu.Keys)
            {
                switch (item)
                {
                    case "page_hethong"://Những trang
                        page_hethong.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;

                }
            }
        }
        private void loadmenuthongke(ref Hashtable danhsachmenu)
        {
            using (StreamReader rd = new StreamReader(cls_Main.pathmenuthongke))
            {
                string line = "";

                while ((line = rd.ReadLine()) != null)
                {
                    danhsachmenu.Add(line.Substring(0, line.IndexOf('=')), line.Substring(line.IndexOf('=') + 1));
                }
            }
            //Ẩn hiện các control trên menu của form main
            foreach (string item in danhsachmenu.Keys)
            {
                switch (item)
                {
                    case "page_hethong"://Những trang
                        page_hethong.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;

                }
            }
        }
        private void loadmenutrogiup(ref Hashtable danhsachmenu)
        {
            using (StreamReader rd = new StreamReader(cls_Main.pathmenutrogiup))
            {
                string line = "";

                while ((line = rd.ReadLine()) != null)
                {
                    danhsachmenu.Add(line.Substring(0, line.IndexOf('=')), line.Substring(line.IndexOf('=') + 1));
                }
            }
            //Ẩn hiện các control trên menu của form main
            foreach (string item in danhsachmenu.Keys)
            {
                switch (item)
                {
                    case "page_hethong"://Những trang
                        page_hethong.Visible = Convert.ToBoolean(danhsachmenu[item]);
                        break;

                }
            }
        }
    }
}
