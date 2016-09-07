using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyLibrarySoft;
using System.Net.Mail;
using System.Net;

namespace VnApptech_GYM_Soft
{
    public partial class frm_capnhatbanquyen :  DevExpress.XtraEditors.XtraForm
    {
        public frm_capnhatbanquyen()
        {
            InitializeComponent();
        }
        private void frm_capnhatbanquyen_Load(object sender, EventArgs e)
        {

        }
        #region các biến trong gửi mail
        string smtpAddress = "smtp.gmail.com";
        int portNumber = 587;
        bool enableSSL = true;
        string err = "";
        string emailFrom = "nmphuclhu@gmail.com";
        string password = "infor210385";
        string emailTo = "phuc@lhu.edu.vn";
        string subject = "Active";
        #endregion
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (cls_GetIDMachine.laycauhinh(ref err) == txtkey.Text)
                {
                    cls_GetIDMachine.active = true;
                    cls_GetIDMachine.ngayHetHan = Convert.ToDateTime("01/01/2999");

                    cls_GetIDMachine.writeRegistry(cls_GetIDMachine.laycauhinh(ref err), cls_GetIDMachine.ngayHetHan);

                }
                else
                {
                    MessageBox.Show("Key không đúng! \nHãy nhập key khác hay liên hệ để được hỗ trợ");
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnguimail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlgui.Visible = true;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            pnlgui.Visible = false;
            txtdiachi.Text = "";
            txthoten.Text = "";
            txtsodienthoai.Text = "";
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txthoten.Text))
                {
                    if (!String.IsNullOrEmpty(txtsodienthoai.Text))
                    {
                        string body = "";
                        body += txthoten.Text + "\n" + txtdiachi.Text + "\n" + txtsodienthoai.Text + "\n";
                        body += cls_GetIDMachine.laycauhinh(ref err);

                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress(emailFrom);
                            mail.To.Add(emailTo);
                            mail.Subject = subject;
                            mail.Body = body;
                            mail.IsBodyHtml = true;


                            using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                            {
                                smtp.Credentials = new NetworkCredential(emailFrom, password);
                                smtp.EnableSsl = enableSSL;
                                smtp.Send(mail);
                            }
                            pnlgui.Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Xin nhập số điện thoại liên lạc", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtsodienthoai.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Xin nhập Họ và tên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txthoten.Focus();
                }
                MessageBox.Show("Thông tin của bạn đã được gửi đến Công ty chúng tôi! Chúng tôi sẽ phản hồi lại với bạn trong vòng 24 giờ nữa\nXin cảm ơn Quý Khách đã sử dụng chương trình của chúng tôi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Không có kết nối Internet! \nĐể có thể Active được chương trình xin vui lòng kết nối Internet", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
