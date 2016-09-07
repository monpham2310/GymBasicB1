using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.TacVu
{
    /// <summary>
    /// Form này sử dụng chung cho các thiết bị
    /// 1. Mã vạch
    /// 2. Mã rfid 125
    /// ==>>Đặc điểm đầu đọc nhận dữ liệu tại vị trí con trỏ
    /// 3. Thiết bị RFID 135
    /// 4. thiết bị vân tay 4500
    /// 5. Thiết bị máy chấm công
    /// </summary>
    public partial class frm_CheckIn : Form
    {
        public frm_CheckIn()
        {
            InitializeComponent();
        }
    }
}
