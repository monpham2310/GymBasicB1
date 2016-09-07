using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VnApptech_GYM_Soft.HeThong
{
    public partial class Frm_SaoLuuPhucHoi : DevExpress.XtraEditors.XtraForm
    {
        bool saoluu;
        public Frm_SaoLuuPhucHoi(string btnduongdan, string btnsaoluu, bool saoluu)
        {
            InitializeComponent();
            this.btnlayfile.Caption = btnduongdan;
            this.btnsaoluu.Caption = btnsaoluu;
            this.saoluu = saoluu;
        }
        BLL_HeThong bd = new BLL_HeThong(cls_Main.pathconnect);
        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnlayfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (saoluu == true)
            {
                try
                {
                    SaveFileDialog _savefile = new SaveFileDialog();
                    _savefile.FileName = "FileBakup" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour + ".bak"; ;
                    _savefile.Filter = "Text Bakup (*.bak)|*.bak|All files (*.*)|*.*";
                    _savefile.RestoreDirectory = true;

                    if (_savefile.ShowDialog() == DialogResult.OK)
                    {
                        txtduongdan.Text = _savefile.FileName;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                try
                {
                    OpenFileDialog _openfile = new OpenFileDialog();
                    _openfile.FileName = "";
                    _openfile.Filter = "Text Bakup (*.bak)|*.bak|All files (*.*)|*.*";
                    _openfile.RestoreDirectory = true;

                    if (_openfile.ShowDialog() == DialogResult.OK)
                    {
                        txtduongdan.Text = _openfile.FileName;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnsaoluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (saoluu == true)
            {
                if (txtduongdan.Text == "")
                {
                    MessageBox.Show("Chưa chọn đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtduongdan.Focus();
                }
                else
                {
                    lblerr.Caption = "Đang sao lưu dữ liệu...";
                    lblerr.Appearance.ForeColor = Color.Red;
                    Application.DoEvents();
                    if (File.Exists(txtduongdan.Text))
                    {
                        File.Delete(txtduongdan.Text);
                    }
                    string err = "";
                    try
                    {

                        if (bd.saoluu(ref err, txtduongdan.Text))
                        {
                            lblerr.Caption = "Đã sao lưu thành công";
                            lblerr.Appearance.ForeColor = Color.White;
                        }
                        else
                        {
                            lblerr.Caption = "Sao lưu không thành công" + err;
                            lblerr.Appearance.ForeColor = Color.White;
                        }
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        lblerr.Caption = "Sao lưu không thành công" + err;
                        lblerr.Appearance.ForeColor = Color.Yellow;
                        throw;
                    }
                }
            }
            else
            {
                if (txtduongdan.Text == "")
                {
                    MessageBox.Show("Chưa chọn đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtduongdan.Focus();
                }
                else
                {
                    lblerr.Caption = "Đang phục hồi dữ liệu...";
                    lblerr.Appearance.ForeColor = Color.Red;
                    Application.DoEvents();
                    string err = "";
                    try
                    {
                        string sql = string.Format("USE Master \n ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " RESTORE DATABASE {1} FROM DISK = N'{2}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" + " ALTER DATABASE {3} SET MULTI_USER", cls_Main.database, cls_Main.database, txtduongdan.Text, cls_Main.database);
                        if (bd.phuchoi(sql, ref err))
                        {
                            lblerr.Caption = "Đã phục hồi thành công";
                            lblerr.Appearance.ForeColor = Color.White;
                        }
                        else
                        {
                            lblerr.Caption = "Phục hồi không thành công" + err;
                            lblerr.Appearance.ForeColor = Color.White;
                        }
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        lblerr.Caption = "Sao lưu không thành công" + err;
                        lblerr.Appearance.ForeColor = Color.Yellow;
                        throw;
                    }
                }
            }
        }
    }
}
