using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevComponents.DotNetBar;
using VnApptech_GYM_Soft.HeThong;
using System.Collections;
using VnApptech_GYM_Soft.DanhMuc;
using System.IO;


namespace VnApptech_GYM_Soft
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {    
        public Frm_Main()
        {
            InitializeComponent();
            cls_Main.docfilecauhinh(ref err, cls_Main.pathconfig);
            cls_Main.Frm_Main = this;
            this.Text = cls_Main.title;
            this.ribbon.Toolbar.ItemLinks.Add(this.barSubItem1);
            this.barSubItem1.Popup += new System.EventHandler(this.barSubItem1_Popup);                    
        }
        #region khai báo biến 
       
        string sTieuDe;
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        BLL_HeThong bd = new BLL_HeThong(cls_Main.pathconnect);

       
      
        #endregion
        /// <summary>
        /// event khi click vào chọn skin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      
        #region các sự kiện chỉnh form
         private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {

            TabItem t = tabMain.SelectedTab;
            //if (t.Name == "frmCheckin")
            //    return;
            tabMain.Tabs.Remove(t);
        }
        
        public void vDoiTenTab()
        {
            for (int i = 0; i < tabMain.Tabs.Count; i++)
            {
                if (tabMain.Tabs[i].Text == "sldalsd,asd")
                {
                    tabMain.SelectedTabIndex = i;
                }
            }
        }
        void OnPaintStyleClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString());

        }
        private void barSubItem1_Popup(object sender, EventArgs e)
        {
            foreach (BarItemLink link in barSubItem1.ItemLinks)
                ((BarCheckItem)link.Item).Checked = link.Item.Caption == defaultLookAndFeel1.LookAndFeel.ActiveSkinName;
        }
        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1, "Thông báo", "Nhấn chuột phải chọn hiển thị lại để mở lại cửa sổ hoặc double click vào icon chương trình", ToolTipIcon.Info);

            }
        }
        private void notifyIcon()
        {
            notifyIcon1.Text = "VNAPPTECH";
            notifyIcon1.ShowBalloonTip(1, "CHÀO BẠN", "Mọi thứ đã sẵn sàng! Bắt đầu nhé!!!", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void mnuhien_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuan_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.ShowBalloonTip(1, "Thông báo", "Nhấn chuột phải chọn hiển thị lại để mở lại cửa sổ hoặc double click vào icon chương trình", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            #region load theme

            foreach (DevExpress.Skins.SkinContainer skin in DevExpress.Skins.SkinManager.Default.Skins)
            {
                BarCheckItem item = ribbon.Items.CreateCheckItem(skin.SkinName, false);
                item.Tag = skin.SkinName;
                item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(OnPaintStyleClick);
                barSubItem1.ItemLinks.Add(item);
            }
            #endregion
            notifyIcon();
           
            #region mở from đăng nhập
            phanquyentheogoi();
            //đóng mở menu khi chương trình không muốn cho sử dụng
            //bằng cách sửa trong file ini
            //MenuDanhMuc.ini
            //MenuHeThong.ini
            //MenuTacVu.ini
            //MenuThongKe.ini
            //MenuTroGiup.ini
            Frm_Login _login = new Frm_Login();
            _login.ShowDialog();
            if (!string.IsNullOrEmpty(cls_Main.tenNhanVien))
            {
                lblthongtindangnhap.Caption = "Hệ thông đang được đăng nhập bởi: " + cls_Main.tenNhanVien;
                if (cls_Main.songayconlai >= 0)
                {
                    lblsongaysudung.Caption = "Số ngày sử dụng còn lại là: " + cls_Main.songayconlai + " ngày";
                    lblsongaysudung.Appearance.ForeColor = Color.Red;
                }
                //Phân quyền

                phanquyentheogoi();
            #endregion

                #region load form thông tin

                sTieuDe = "Thông tin";
                if (!checkOpenTabs(sTieuDe))
                {
                    TabItem t = tabMain.CreateTab(sTieuDe);
                    t.Name = "frmthongtin";
                    Frm_ThongTin dt = new Frm_ThongTin();
                    dt.deDongTab = new Frm_ThongTin._deDongTab(vDOngTab);
                    dt.frm = this;
                    dt.TopLevel = false;
                    dt.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(dt);
                    dt.Show();
                    tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
                }
                #endregion
            }
            else
            {
                _login.ShowDialog();
            }



        }
        private bool checkOpenTabs(string name)
        {
            for (int i = 0; i < tabMain.Tabs.Count; i++)
            {
                if (tabMain.Tabs[i].Text == name)
                {
                    tabMain.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        
        private void vDOngTab()
        {
            foreach (TabItem item in tabMain.Tabs)
            {
                if (item.IsSelected)
                {
                    tabMain.Tabs.Remove(item);
                    //MessageBox.Show(item.Name.ToString());
                    return;
                }
            }
        }
        private void btncauhinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_CauHinh _frmcauhinh = new Frm_CauHinh();
            _frmcauhinh.ShowDialog();
            //doc lai file cau hinh moi.
            
        }

        private void btnthoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
            }

        }

        private void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            lblthongtindangnhap.Caption = "";
            cls_Main.dangxuat = true;
            cls_Main.tenCaLamViec = "";
            cls_Main.tenDangNhap = "";
            cls_Main.tenNhanVien = "";
            cls_Main.songayconlai = 0;
            Frm_Login _frmlogin = new Frm_Login();
            _frmlogin.ShowDialog();
            if (!string.IsNullOrEmpty(cls_Main.tenNhanVien))
            {
                lblthongtindangnhap.Caption = "Hệ thông đang được đăng nhập bởi: " + cls_Main.tenNhanVien;
                if (cls_Main.songayconlai >= 0)
                {
                    lblsongaysudung.Caption = "Số ngày sử dụng còn lại là: " + cls_Main.songayconlai + " ngày";
                    lblsongaysudung.Appearance.ForeColor = Color.Red;
                }         

                #region load form thông tin

                sTieuDe = "Thông tin";
                if (!checkOpenTabs(sTieuDe))
                {
                    TabItem t = tabMain.CreateTab(sTieuDe);
                    t.Name = "frmthongtin";
                    Frm_ThongTin dt = new Frm_ThongTin();
                    dt.deDongTab = new Frm_ThongTin._deDongTab(vDOngTab);
                    dt.frm = this;
                    dt.TopLevel = false;
                    dt.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(dt);
                    dt.Show();
                    tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1; 
                    cls_Main.dangxuat = false;
                }
                #endregion
            }
            else
            {
                _frmlogin.ShowDialog();
            }

          
        }

        private void btnphuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SaoLuuPhucHoi _frmphuchoi = new Frm_SaoLuuPhucHoi("Chọn tập tin","Phục hồi dữ liệu",false);
            _frmphuchoi.ShowDialog();
        }

        private void btnsaoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SaoLuuPhucHoi _frmsaoluu = new Frm_SaoLuuPhucHoi("Chọn đường dẫn lưu","Sao lưu dữ liệu",true);
            _frmsaoluu.ShowDialog();
        }

        private void btndoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DoiMatKhau _doimatkhau = new Frm_DoiMatKhau();
            _doimatkhau.ShowDialog();
        }

        private void btnketnoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_KetNoi _frmketnoi = new Frm_KetNoi();
            _frmketnoi.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            sTieuDe = "Thông tin";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabMain.CreateTab(sTieuDe);
                t.Name = "frmthongtin";
                Frm_ThongTin dt = new Frm_ThongTin();
                dt.deDongTab = new Frm_ThongTin._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }

      
     

        private void btnbanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_capnhatbanquyen _capnhatbanquyen = new frm_capnhatbanquyen();
            _capnhatbanquyen.ShowDialog();
        }

       

        string err = "";
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cls_Main.thoat == false && cls_Main.maTaiKhoan!="1")
            {
                if (MessageBox.Show("Bạn có thật sự muốn kết thúc ca làm việc của mình vào lúc :" + DateTime.Now.ToShortTimeString() + " ngày " + DateTime.Now.ToShortDateString() + "\nNếu chọn OK thì sẽ kết thúc ca làm việc và không thể đăng nhập vào ca lại Chọn Cancel để hủy tác cụ này\nNếu Vẫn muốn thoát khỏi chương trình hãy đăng xuất để thoát khỏi chương trình tạm thời", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bd.capnhatgioracuanhanvien(ref err, cls_Main.maNhanVien, cls_Main.maCaLamViec, DateTime.Now.ToShortTimeString());
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

     
      

       
                
      
       

        
        
      

       
        private void btnhuongdan_ItemClick(object sender, ItemClickEventArgs e)
        {
            sTieuDe = "Hướng dẫn sử dụng";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabMain.CreateTab(sTieuDe);
                t.Name = "Frm_HuongDan";
                Frm_HuongDan dt = new Frm_HuongDan();
                dt.deDongTab = new Frm_HuongDan._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }

        private void btncalamviec_ItemClick(object sender, ItemClickEventArgs e)
        {
            sTieuDe = "Ca làm việc";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabMain.CreateTab(sTieuDe);
                t.Name = "Frm_CaLamViec";
                Frm_CaLamViec_Main dt = new Frm_CaLamViec_Main();
                dt.deDongTab = new Frm_CaLamViec_Main._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }

       

        private void btnloaitaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            sTieuDe = "Loại Tài Khoản";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabMain.CreateTab(sTieuDe);
                t.Name = "Frm_Loaitaikhoan";
                Frm_TaiKhoan_Main dt = new Frm_TaiKhoan_Main();
                dt.deDongTab = new Frm_TaiKhoan_Main._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }

        private void btnnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            sTieuDe = "Nhân viên";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabMain.CreateTab(sTieuDe);
                t.Name = "Frm_nhanvien";
                Frm_NhanVien_Main dt = new Frm_NhanVien_Main();
                dt.deDongTab = new Frm_NhanVien_Main._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }


      

       

        public void showToolText(string text)
        {
            notifyIcon1.BalloonTipText = text;
        }

        private void btnphanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            sTieuDe = "Phân quyền";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabMain.CreateTab(sTieuDe);
                t.Name = "Frm_PhanQuyen";
                Frm_PhanQuyen dt = new Frm_PhanQuyen();
                dt.deDongTab = new Frm_PhanQuyen._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }


       
       

      

       

        

    }
}
