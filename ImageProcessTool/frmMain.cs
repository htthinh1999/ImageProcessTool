using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap bmpGray = new Bitmap(picOriginal1.Image);
            picResult1.Image = imageProcess.ToGray(bmpGray);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            Bitmap bmpBinary = new Bitmap(picOriginal2.Image);
            //picResult.Image = imageProcess.ToBinary(bmpBinary, 128);
            picResult2.Image = imageProcess.ToBinaryLocBits(bmpBinary, Convert.ToByte(txtBand.Text));
        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnMoveLeftHis_Click(object sender, EventArgs e)
        {
            Bitmap grayResult = new Bitmap(picOriginal3.Image);
            picResult3.Image = imageProcess.HistogramStep(grayResult, -50);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnMoveRightHis_Click(object sender, EventArgs e)
        {
            Bitmap grayResult = new Bitmap(picOriginal3.Image);
            picResult3.Image = imageProcess.HistogramStep(grayResult, 50);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnStretchHistogram_Click(object sender, EventArgs e)
        {
            picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
            Bitmap grayResult = new Bitmap(picResult3.Image);
            picResult3.Image = imageProcess.HisToGramStretch(grayResult, float.Parse(txtStretch.Text));
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnFixHistogram_Click(object sender, EventArgs e)
        {
            picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
            Bitmap grayResult = new Bitmap(picResult3.Image);
            picResult3.Image = imageProcess.HistogramEdit(grayResult);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnEqualizeHistogram_Click(object sender, EventArgs e)
        {
            picResult3.Image = imageProcess.ToGray(new Bitmap(picOriginal3.Image));
            Bitmap grayResult = new Bitmap(picResult3.Image);
            picResult3.Image = imageProcess.HistogramEqualization(grayResult);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult3.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnAND_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(picAnd1.Image);
            Bitmap bmp2 = new Bitmap(picAnd1.Image);
            resultOf2ImageForm.SetPicResult(imageProcess.And2Image(bmp1, bmp2));
            resultOf2ImageForm.Show();
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(picOr1.Image);
            Bitmap bmp2 = new Bitmap(picOr2.Image);
            resultOf2ImageForm.SetPicResult(imageProcess.Or2Image(bmp1, bmp2));
            resultOf2ImageForm.Show();
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(picXor1.Image);
            Bitmap bmp2 = new Bitmap(picXor2.Image);
            resultOf2ImageForm.SetPicResult(imageProcess.Xor2Image(bmp1, bmp2));
            resultOf2ImageForm.Show();
        }
    }
}
