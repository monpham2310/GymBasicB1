using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VnApptech_GYM_Soft.DanhMuc;

namespace VnApptech_GYM_Soft.TacVu
{    
    public partial class frm_CheckIn : DevExpress.XtraEditors.XtraForm
    {
        private int timeToReset = 0;
        private IBLL_DanhMuc bllCate;
        private IBLL_TacVu bllTask;
        private string err = "";

        public frm_CheckIn()
        {
            InitializeComponent();
            bllCate = new BLL_DanhMuc(cls_Main.pathconnect);
            bllTask = new BLL_TacVu(cls_Main.pathconnect);
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
            pbAvatar.Image = null;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
