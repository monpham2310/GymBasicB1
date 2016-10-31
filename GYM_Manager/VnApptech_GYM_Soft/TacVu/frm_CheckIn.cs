using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VnApptech_GYM_Soft.DanhMuc;
using System.Media;
using System.IO;

namespace VnApptech_GYM_Soft.TacVu
{    
    public partial class frm_CheckIn : DevExpress.XtraEditors.XtraForm
    {
        private int timeToReset = 0;
        private IBLL_DanhMuc bllCate;
        private IBLL_TacVu bllTask;
        private string err = "";
        private DataTable dtDataOfMember;

        public frm_CheckIn()
        {
            InitializeComponent();
            bllCate = new BLL_DanhMuc(cls_Main.pathconnect);
            bllTask = new BLL_TacVu(cls_Main.pathconnect);
            dtDataOfMember = new DataTable();
        }

        private void LoadClubFromDB()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllCate.H_GetAllClubFromDB(ref err);
                cbClub.DataSource = dt;
                cbClub.DisplayMember = "TenPhongTap";
                cbClub.ValueMember = "MaPhongTap";
                cbClub.SelectedValue = cls_Main._ClubId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadClubFromDB: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadHistoryInOut()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllTask.H_GetHistoryInOutFromDB(ref err, cls_Main._ClubId);
                dgvHistoryInOut.DataSource = dt;
                lblNumberTurn.Text = string.Concat("Số lượt trong ngày: ", dt.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadHistoryInOut: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_CheckIn_Load(object sender, EventArgs e)
        {
            timer_Datetime.Start();
            LoadClubFromDB();
            LoadHistoryInOut();
        }

        private void timer_Datetime_Tick(object sender, EventArgs e)
        {
            timer_Datetime.Interval = 1000;            
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();            
        }

        private void timer_Reset_Tick(object sender, EventArgs e)
        {
            timer_Reset.Interval = 1000;
            timeToReset++;
            if (timeToReset == 15)
            {
                resetControls();
                timeToReset = 0;
                timer_Reset.Stop();
            }
        }

        private void resetControls()
        {
            txtBarcode.Clear();
            txtBirthday.Text = "";
            txtExprireDate.Text = "";
            txtFullname.Text = "";
            txtPackageName.Text = "";
            txtPractice.Text = "";
            txtRemainDay.Text = "";
            txtRemainTurn.Text = "";
            lblNotice.Text = "";
            pbAvatar.Image = null;
        }

        private bool checkExistsBarcoce(string barcode)
        {
            bool result = false;
            result = bllTask.HSP_CheckExistsBarcodeInDB(ref err, barcode);
            return result;
        }

        private void showInformOfMember()
        {
            txtFullname.Text = dtDataOfMember.Rows[0]["TenHoiVien"].ToString();
            txtBirthday.Text = dtDataOfMember.Rows[0]["NamSinh"].ToString();
            txtPractice.Text = dtDataOfMember.Rows[0]["TenMonTap"].ToString();
            txtPackageName.Text = dtDataOfMember.Rows[0]["TenGoiTap"].ToString();
            txtExprireDate.Text = dtDataOfMember.Rows[0]["NgayHetHan"].ToString();
            txtRemainDay.Text = dtDataOfMember.Rows[0]["songayconlai"].ToString();
            txtRemainTurn.Text = dtDataOfMember.Rows[0]["SoLanTapConLai"].ToString();
            if (!string.IsNullOrEmpty(dtDataOfMember.Rows[0]["HinhAnh"].ToString()))
            {
                byte[] imagedata = (byte[])dtDataOfMember.Rows[0]["HinhAnh"];
                MemoryStream ms = new MemoryStream(imagedata);
                pbAvatar.Image = Image.FromStream(ms);
            }
            timer_Reset.Start();
        }

        private void insertNumberOfTurnInRoom(bool isPracticeFollowTurn)
        {
            try
            {                
                bllTask.HSP_InsertNumberOfTurnInRoom(ref err, cls_Main.maCaLamViec, dtDataOfMember.Rows[0]["MaHD"].ToString(), isPracticeFollowTurn);                
                bllTask.HSP_CheckCardIsFirstTimeUse(ref err, dtDataOfMember.Rows[0]["MaHD"].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error at insertNumberOfTurnOfRoom !!!\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkNumberOfTurnInRoomOfMember()
        {
            SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\RINGIN.WAV");
            int roomId = !string.IsNullOrEmpty(dtDataOfMember.Rows[0]["MaPhongTap"].ToString()) ? int.Parse(dtDataOfMember.Rows[0]["MaPhongTap"].ToString()) : 0;
            string billId = dtDataOfMember.Rows[0]["MaHD"].ToString();
            bool isReserve = !string.IsNullOrEmpty(dtDataOfMember.Rows[0]["TinhTrangBaoLuu"].ToString()) ? Convert.ToBoolean(dtDataOfMember.Rows[0]["TinhTrangBaoLuu"]) : false;
            if (roomId == cls_Main._ClubId)
            {
                DateTime dateExpire = Convert.ToDateTime(dtDataOfMember.Rows[0]["NgayHetHan"]);
                if (DateTime.Compare(dateExpire, DateTime.Now) > 0 && !isReserve)
                {
                    if (DateTime.Now.Subtract(Convert.ToDateTime(dtDataOfMember.Rows[0]["GioBD"].ToString())).Seconds >= 0 && DateTime.Now.Subtract(Convert.ToDateTime(dtDataOfMember.Rows[0]["GioKT"].ToString())).Seconds <= 0)
                    {
                        bool isPracticeFollowTurn = Convert.ToBoolean(dtDataOfMember.Rows[0]["TinhTrangTapLan"]);
                        if (!isPracticeFollowTurn) // tập thường
                        {
                            lblNotice.ForeColor = Color.Green;
                            lblNotice.Text = "Xin Chào!\nChúc Quý khách khỏe đẹp";
                            insertNumberOfTurnInRoom(false);
                            //hiển thị thông tin
                            showInformOfMember();
                            LoadHistoryInOut();
                        }
                        else // tập lần
                        {
                            bool isOutOfTurn = bllTask.HSP_CheckRemainNumberOfTurnOfMember(ref err, billId);
                            if (!isOutOfTurn)
                            {
                                insertNumberOfTurnInRoom(true);
                                //hiển thị thông tin
                                showInformOfMember();
                                LoadHistoryInOut();
                            }
                            else
                            {
                                showInformOfMember();                                
                                lblNotice.ForeColor = Color.Red;
                                lblNotice.Text = "Thẻ hội viên đã hết lần tập \nXin hãy gia hạn thêm!";
                                txtBarcode.SelectAll();
                            }
                        }
                    }
                    else
                    {
                        lblNotice.ForeColor = Color.Red;
                        lblNotice.Text = "Quý khác đã tập sai giờ tập! \nHẹn gặp lại vào buổi tập lúc " + dtDataOfMember.Rows[0]["GioBD"].ToString() + "- " + dtDataOfMember.Rows[0]["GioKT"].ToString();
                        showInformOfMember();                        
                        sound.Play();
                    }
                }
                else if (DateTime.Compare(dateExpire, DateTime.Now) > 0 && isReserve)
                {
                    showInformOfMember();
                    lblNotice.ForeColor = Color.Red;
                    lblNotice.Text = "Thẻ hội viên đang trong tình trạng bảo lưu \nVui lòng liên hệ phục hồi thẻ để tập để tiếp tục tập!";
                    sound.Play();
                }
                else
                {
                    showInformOfMember();
                    lblNotice.ForeColor = Color.Red;
                    lblNotice.Text = "Thẻ hội viên đã hết hạn tập \nVui lòng liên hệ đăng ký để tiếp tục tập!!";                    
                    sound.Play();
                }
            }
            else
            {
                showInformOfMember();
                lblNotice.ForeColor = Color.Red;
                lblNotice.Text = "Hội viên Không tập đúng phòng tập!Phòng tập của học viên này là:\n" + dtDataOfMember.Rows[0]["TenPhongTap"].ToString();                
                sound.Play();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text.Length == cls_Main.LengthOfNumber)
                {
                    //kiem tra ton tai ma vach
                    if (checkExistsBarcoce(txtBarcode.Text))
                    {                        
                        txtBarcode.SelectAll();                        
                        dtDataOfMember = bllTask.HSP_GetDataDataFollowBarcodeOfMember(ref err, txtBarcode.Text);
                        if (string.IsNullOrEmpty(dtDataOfMember.Rows[0]["MaHD"].ToString()))
                        {                            
                            checkNumberOfTurnInRoomOfMember();
                            txtBarcode.Clear();
                        }
                        else
                        {
                            lblNotice.ForeColor = Color.Red;
                            lblNotice.Text = "Hội viên chưa đăng ký tập!\n  Xin vui lòng liên hệ đăng ký!";
                            showInformOfMember();
                            txtBarcode.SelectAll();
                        }
                    }
                    else
                    {
                        lblNotice.ForeColor = Color.Red;
                        lblNotice.Text = "Mã thẻ không có trong hệ thống, Xin kiểm tra lại!";
                        lblNotice.Focus();                        
                        resetControls();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at txtBarcode_TextChanged!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
