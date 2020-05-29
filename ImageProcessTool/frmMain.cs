using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessTool
{
    public partial class frmMain : Form
    {
        HistographicForm histographicForm = new HistographicForm();
        ResultOf2ImageForm resultOf2ImageForm = new ResultOf2ImageForm();
        ImageProcess imageProcess = new ImageProcess();

        public frmMain()
        {
            InitializeComponent();
            histographicForm.Hide();
        }

        #region Change Tabs

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void titleBtnGray_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(0);
        }

        private void titleBtnBinary_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(1);
        }

        private void titleBtnHistogram_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(2);
        }

        private void titleBtnAnd_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(3);
        }

        private void titleBtnOr_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(4);
        }

        private void titleBtnXor_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(5);
        }

        private void titleBtnTutorial_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(6);
        }

        private void titleBtnAbout_Click(object sender, EventArgs e)
        {
            pages.setPageByIndex(7);
        }

        #endregion

        void OpenPicture(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                Title = "Chọn ảnh gốc",
                Filter = "Image file|*.jpg;*.jpeg;*.bmp|jpg files|*.jpg|jpeg files|*.jpeg|bmp files|*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                PictureBox pic = sender as PictureBox;
                pic.Image = new Bitmap(fileName);
                pic.BackgroundImage = null;
            }
        }

        void SavePicture(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Lưu ảnh kết quả",
                    Filter = "jpeg files|*.jpeg",
                    FileName = "result"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    pic.Image.Save(fileName, ImageFormat.Jpeg);
                    MessageBox.Show("Lưu ảnh thành công!", "Lưu ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void AllowSave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Image != null)
            {
                pic.Cursor = Cursors.Hand;
            }
            else
            {
                pic.Cursor = Cursors.Default;
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (picOriginal1.Image != null)
            {
                Bitmap bmpGray = new Bitmap(picOriginal1.Image);
                picResult1.Image = imageProcess.ToGray(bmpGray);
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal1, new EventArgs());
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if(picOriginal2.Image != null)
            {
                Bitmap bmpBinary = new Bitmap(picOriginal2.Image);
                //picResult.Image = imageProcess.ToBinary(bmpBinary, 128);
                byte band;
                bool bandIsNum = byte.TryParse(txtBand.Text, out band);
                if(!txtBand.Text.Equals("") && bandIsNum)
                {
                    picResult2.Image = imageProcess.ToBinaryLocBits(bmpBinary, band);
                }
                else
                {
                    MessageBox.Show("Chưa nhập ngưỡng hoặc nhập sai!\nBạn cần phải nhập ngưỡng trước khi chuyển đổi và ngưỡng phải là kiểu số nằm trong đoạn [0, 255]!", "Lỗi nhập ngưỡng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBand.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal2, new EventArgs());
            }
        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            if (picOriginal3.Image != null)
            {
                picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
                Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
                histographicForm.SetImage(bmpHistographic);
                histographicForm.Show();
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal3, new EventArgs());
            }
        }

        private void btnMoveLeftHis_Click(object sender, EventArgs e)
        {
            if (picOriginal3.Image != null)
            {
                Bitmap grayResult = new Bitmap((picResult3.Image == null) ? picOriginal3.Image : picResult3.Image);
                picResult3.Image = imageProcess.HistogramStep(grayResult, -5);
                Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
                histographicForm.SetImage(bmpHistographic);
                histographicForm.Show();
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal3, new EventArgs());
            }
        }

        private void btnMoveRightHis_Click(object sender, EventArgs e)
        {
            if(picOriginal3.Image != null)
            {
                Bitmap grayResult = new Bitmap((picResult3.Image == null) ? picOriginal3.Image : picResult3.Image);
                picResult3.Image = imageProcess.HistogramStep(grayResult, 5);
                Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
                histographicForm.SetImage(bmpHistographic);
                histographicForm.Show();
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal3, new EventArgs());
            }
        }

        private void btnStretchHistogram_Click(object sender, EventArgs e)
        {
            if(picOriginal3.Image != null)
            {
                float stretch;
                if (float.TryParse(txtStretch.Text, out stretch))
                {
                    picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
                    Bitmap grayResult = new Bitmap(picResult3.Image);
                    picResult3.Image = imageProcess.HisToGramStretch(grayResult, stretch);
                    Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
                    histographicForm.SetImage(bmpHistographic);
                    histographicForm.Show();
                }
                else
                {
                    MessageBox.Show("Chưa nhập hệ số co dãn hoặc nhập sai!\nBạn cần phải nhập hệ số co dãn trước khi chuyển đổi và hệ số co dãn phải là kiểu số", "Lỗi nhập hệ số co dãn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStretch.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal3, new EventArgs());
            }
        }

        private void btnFixHistogram_Click(object sender, EventArgs e)
        {
            if(picOriginal3.Image != null)
            {
                picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
                Bitmap grayResult = new Bitmap(picResult3.Image);
                picResult3.Image = imageProcess.HistogramEdit(grayResult);
                Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
                histographicForm.SetImage(bmpHistographic);
                histographicForm.Show();
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal3, new EventArgs());
            }
        }

        private void btnEqualizeHistogram_Click(object sender, EventArgs e)
        {
            if(picOriginal3.Image != null)
            {
                picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
                Bitmap grayResult = new Bitmap(picResult3.Image);
                picResult3.Image = imageProcess.HistogramEqualization(grayResult);
                Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
                histographicForm.SetImage(bmpHistographic);
                histographicForm.Show();
            }
            else
            {
                MessageBox.Show("Chưa có ảnh gốc! Bạn cần phải mở ảnh!", "Lỗi chưa có ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOriginal3, new EventArgs());
            }
        }

        private void btnAND_Click(object sender, EventArgs e)
        {
            if (picAnd1.Image != null)
            {
                Bitmap bmp1 = new Bitmap(picAnd1.Image);
                if(picAnd2.Image != null)
                {
                    Bitmap bmp2 = new Bitmap(picAnd2.Image);
                    resultOf2ImageForm.SetPicResult(imageProcess.And2Image(bmp1, bmp2));
                    resultOf2ImageForm.Show();
                }
                else
                {
                    MessageBox.Show("Chưa có ảnh 2! Bạn cần phải mở ảnh 2!", "Lỗi chưa có ảnh 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenPicture(picAnd2, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Chưa có ảnh 1! Bạn cần phải mở ảnh 1!", "Lỗi chưa có ảnh 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picAnd1, new EventArgs());
            }
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            if (picOr1.Image != null)
            {
                Bitmap bmp1 = new Bitmap(picOr1.Image);
                if (picOr2.Image != null)
                {
                    Bitmap bmp2 = new Bitmap(picOr2.Image);
                    resultOf2ImageForm.SetPicResult(imageProcess.Or2Image(bmp1, bmp2));
                    resultOf2ImageForm.Show();
                }
                else
                {
                    MessageBox.Show("Chưa có ảnh 2! Bạn cần phải mở ảnh 2!", "Lỗi chưa có ảnh 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenPicture(picOr2, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Chưa có ảnh 1! Bạn cần phải mở ảnh 1!", "Lỗi chưa có ảnh 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picOr1, new EventArgs());
            }
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            if (picXor1.Image != null)
            {
                Bitmap bmp1 = new Bitmap(picXor1.Image);
                if (picXor2.Image != null)
                {
                    Bitmap bmp2 = new Bitmap(picXor2.Image);
                    resultOf2ImageForm.SetPicResult(imageProcess.Xor2Image(bmp1, bmp2));
                    resultOf2ImageForm.Show();
                }
                else
                {
                    MessageBox.Show("Chưa có ảnh 2! Bạn cần phải mở ảnh 2!", "Lỗi chưa có ảnh 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenPicture(picXor2, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Chưa có ảnh 1! Bạn cần phải mở ảnh 1!", "Lỗi chưa có ảnh 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPicture(picXor1, new EventArgs());
            }
        }
    }
}
