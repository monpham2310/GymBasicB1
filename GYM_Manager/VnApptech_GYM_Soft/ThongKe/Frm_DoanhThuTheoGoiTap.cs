﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.ThongKe
{
    public partial class Frm_DoanhThuTheoGoiTap : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DoanhThuTheoGoiTap()
        {
            InitializeComponent();
        }
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private void Frm_DoanhThuTheoGoiTap_Load(object sender, EventArgs e)
        {

        }
    }
}
