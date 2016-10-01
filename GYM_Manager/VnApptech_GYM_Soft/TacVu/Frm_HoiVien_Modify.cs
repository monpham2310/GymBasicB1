using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Touchless.Vision.Camera;
using System.IO;

namespace VnApptech_GYM_Soft.TacVu
{
    public partial class Frm_HoiVien_Modify : DevExpress.XtraEditors.XtraForm
    {
        private DataRow drMemberItem = null;
        private bool isUpdate;
        private CameraFrameSource _frameSource; // Camera
        private static Bitmap _latestFrame; // camera
        byte[] imagedata = null;
        private IBLL_TacVu bll;
        private string err = "";

        public Frm_HoiVien_Modify()
        {
            InitializeComponent();
            isUpdate = false;
            bll = new BLL_TacVu(cls_Main.pathconnect);
        }

        public Frm_HoiVien_Modify(DataRow dr)
        {
            InitializeComponent();
            drMemberItem = dr;
            isUpdate = true;
            bll = new BLL_TacVu(cls_Main.pathconnect);
        }

        private void thrashOldCamera()
        {
            // Trash the old camera
            if (_frameSource != null)
            {
                _frameSource.NewFrame -= OnImageCaptured;
                _frameSource.Camera.Dispose();
                setFrameSource(null);
                ptbhinhhoivien.Paint -= new PaintEventHandler(drawLatestImage);
            }
        }

        private void drawLatestImage(object sender, PaintEventArgs e)
        {
            if (_latestFrame != null)
            {
                // Draw the latest image from the active camera
                e.Graphics.DrawImage(_latestFrame, 0, 0, _latestFrame.Width, _latestFrame.Height);
            }
        }

        public void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        {
            _latestFrame = frame.Image;
            ptbhinhhoivien.Invalidate();
        }

        private void setFrameSource(CameraFrameSource cameraFrameSource)
        {
            if (_frameSource == cameraFrameSource)
                return;

            _frameSource = cameraFrameSource;
        }

        private void startCapturing()
        {
            try
            {
                Camera c = (Camera)comboBoxCameras.SelectedItem;
                setFrameSource(new CameraFrameSource(c));
                _frameSource.Camera.CaptureWidth = 480;
                _frameSource.Camera.CaptureHeight = 360;
                _frameSource.Camera.Fps = 20;
                _frameSource.NewFrame += OnImageCaptured;

                ptbhinhhoivien.Paint += new PaintEventHandler(drawLatestImage);
                _frameSource.StartFrameCapture();
            }
            catch (Exception ex)
            {
                comboBoxCameras.Text = "Select A Camera";
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Hệ thồng đang xử lý\n" + ex.Message, "THÔNG BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
        }

        public byte[] ReadFile(string filePath)
        {

            byte[] buffer;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read
                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }
            finally
            {
                fileStream.Close();
            }
            return buffer;

        }

        private void InitializeCamera()
        {
            try
            {
                ///// load cổng camera////
                if (!DesignMode)
                {
                    // Refresh the list of available cameras
                    comboBoxCameras.Items.Clear();
                    foreach (Camera cam in CameraService.AvailableCameras)
                        comboBoxCameras.Items.Add(cam);

                    if (comboBoxCameras.Items.Count > 0)
                        comboBoxCameras.SelectedIndex = 0;

                    btTurnOnCam.Enabled = true;
                    btTakePhoto.Enabled = true;
                }
                //////////////////
            }
            catch (Exception)
            {
                MessageBox.Show("Không có thiết bị Webcam !!!");
                btTurnOnCam.Enabled = false;
                btTakePhoto.Enabled = false;
            }
        }

        private void resetControl()
        {
            txtMemberId.Clear();
            txtMemberName.Clear();
            txtBarcode.Clear();
            txtIDCard.Clear();
            dtpBirthday.Value = DateTime.Now;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void Frm_HoiVien_Modify_Load(object sender, EventArgs e)
        {
            InitializeCamera();
            dtpBirthday.Value = DateTime.Now;
            if (isUpdate)
            {
                if (drMemberItem != null)
                {
                    txtMemberId.Text = drMemberItem["MaHoiVien"].ToString();
                    txtMemberName.Text = string.Concat(drMemberItem["Ho"].ToString(), drMemberItem["Ten"].ToString());
                    txtBarcode.Text = drMemberItem["MaThe"].ToString();
                    if (Convert.ToBoolean(drMemberItem["Gioitinh"]))
                        rdFemale.Checked = true;
                    else
                        rdMale.Checked = true;
                    txtIDCard.Text = drMemberItem["CMND"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(drMemberItem["NamSinh"]);
                    txtPhone.Text = drMemberItem["DienThoai"].ToString();
                    txtEmail.Text = drMemberItem["Email"].ToString();
                    txtAddress.Text = drMemberItem["DiaChi"].ToString();
                    if (!string.IsNullOrEmpty(drMemberItem["HinhAnh"].ToString()))
                    {
                        imagedata = (byte[])drMemberItem["HinhAnh"];
                        MemoryStream ms = new MemoryStream(imagedata);
                        ptbhinhhoivien.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void btTurnOnCam_Click(object sender, EventArgs e)
        {
            // Early return if we've selected the current camera
            if (_frameSource != null && _frameSource.Camera == comboBoxCameras.SelectedItem)
                return;

            thrashOldCamera();
            startCapturing();
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hội viên.", "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {                
                string memberName = txtMemberName.Text;
                string barcode = txtBarcode.Text;
                bool gender = (rdFemale.Checked)? true : false;
                string idCard = txtIDCard.Text;
                DateTime birthday = dtpBirthday.Value;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                if (ptbhinhhoivien.Image == null)
                {                    
                    imagedata = null;
                }
                else
                {                    
                    MemoryStream ms = new MemoryStream();
                    ptbhinhhoivien.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagedata = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(imagedata, 0, imagedata.Length);
                }

                if (isUpdate)
                {
                    int memberId = int.Parse(txtMemberId.Text);
                    if(imagedata != null)
                        result = bll.UpdateMemberDataToDB(ref err, memberId, memberName, barcode, gender, idCard, birthday, phone, email, address, imagedata);
                    else
                        result = bll.UpdateMemberDataNoneImgToDB(ref err, memberId, memberName, barcode, gender, idCard, birthday, phone, email, address);
                    if(result)
                    {
                        MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    MessageBox.Show("Lưu thông tin thất bại!\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(imagedata != null)
                        result = bll.AddMemberDataToDB(ref err, memberName, barcode, gender, idCard, birthday, phone, email, address, imagedata);
                    else
                        result = bll.AddMemberDataNoneImgToDB(ref err, memberName, barcode, gender, idCard, birthday, phone, email, address);
                    if (result)
                    {
                        MessageBox.Show("Thêm hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControl();
                        return;
                    }
                    MessageBox.Show("Thêm hội viên thất bại!\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex){
                MessageBox.Show("Error at btnsave_ItemClick: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            ptbhinhhoivien.Image = (Bitmap)_latestFrame.Clone();
            thrashOldCamera();
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "image files (*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp|All files (*.*)|*.*";
                dialog.InitialDirectory = @"C:\";
                dialog.Title = "Please select an image file to encrypt.";
                // Display OpenFileDialog by calling ShowDialog method 
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ptbhinhhoivien.Image = Image.FromFile(dialog.FileName);
                }
                dialog.Dispose();
                imagedata = ReadFile(dialog.FileName);
            }
            catch (Exception) { }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Frm_HoiVien_Modify_FormClosing(object sender, FormClosingEventArgs e)
        {
            thrashOldCamera();
        }
                
    }
}
