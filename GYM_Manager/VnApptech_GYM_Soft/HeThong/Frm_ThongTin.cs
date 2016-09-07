using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VnApptech_GYM_Soft.HeThong
{
    public partial class Frm_ThongTin : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ThongTin()
        {
            InitializeComponent();
        }
        public Frm_Main frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
      
        private void Frm_ThongTin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Background.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
           
        }
    }
}
