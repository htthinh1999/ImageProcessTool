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
    public partial class MainForm : Form
    {
        HistographicForm histographicForm = new HistographicForm();
        ResultOf2ImageForm resultOf2ImageForm = new ResultOf2ImageForm();

        ImageProcess imageProcess;
        string fileName;

        public MainForm()
        {
            InitializeComponent();
            imageProcess = new ImageProcess();
            histographicForm.Hide();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                Title = "Chọn ảnh gốc",
                Filter = "Image file|*.jpg;*.jpeg;*.bmp|jpg files|*.jpg|jpeg files|*.jpeg|bmp files|*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                picOriginal.Image = new Bitmap(fileName);
            }
        }
        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap bmpGray = new Bitmap(picOriginal.Image);
            picResult.Image = imageProcess.ToGray(bmpGray);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            Bitmap bmpBinary = new Bitmap(picOriginal.Image);
            //picResult.Image = imageProcess.ToBinary(bmpBinary, 128);
            picResult.Image = imageProcess.ToBinaryLocBits(bmpBinary, Convert.ToByte(txtBand.Text));
        }

        private void btnHistogramGray_Click(object sender, EventArgs e)
        {
            picResult.Image = imageProcess.ToGray(new Bitmap(picOriginal.Image));
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bitmap grayResult = new Bitmap(picResult.Image);
            picResult.Image = imageProcess.HistogramStep(grayResult, 50);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Bitmap grayResult = new Bitmap(picResult.Image);
            picResult.Image = imageProcess.HistogramStep(grayResult, -50);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            picResult.Image = imageProcess.ToGray(new Bitmap(picOriginal.Image));
            Bitmap grayResult = new Bitmap(picResult.Image);
            picResult.Image = imageProcess.HisToGramStretch(grayResult, float.Parse(txtStretch.Text));
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            picResult.Image = imageProcess.ToGray(new Bitmap(picOriginal.Image));
            Bitmap grayResult = new Bitmap(picResult.Image);
            picResult.Image = imageProcess.HistogramEdit(grayResult);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnEqualization_Click(object sender, EventArgs e)
        {
            picResult.Image = imageProcess.ToGray(new Bitmap(picOriginal.Image));
            Bitmap grayResult = new Bitmap(picResult.Image);
            picResult.Image = imageProcess.HistogramEqualization(grayResult);
            Bitmap bmpHistographic = imageProcess.HistogramGray(new Bitmap(picResult.Image));
            histographicForm.SetImage(bmpHistographic);
            histographicForm.Show();
        }

        private void btnOpenPB1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                Title = "Chọn ảnh 1",
                Filter = "Image file|*.jpg;*.jpeg;*.bmp|jpg files|*.jpg|jpeg files|*.jpeg|bmp files|*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                pic1.Image = new Bitmap(fileName);
            }
        }

        private void btnOpenPB2_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                Title = "Chọn ảnh 2",
                Filter = "Image file|*.jpg;*.jpeg;*.bmp|jpg files|*.jpg|jpeg files|*.jpeg|bmp files|*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                pic2.Image = new Bitmap(fileName);
            }
        }

        private void btnAND_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pic1.Image);
            Bitmap bmp2 = new Bitmap(pic2.Image);
            resultOf2ImageForm.SetPicResult(imageProcess.And2Image(bmp1, bmp2));
            resultOf2ImageForm.Show();
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pic1.Image);
            Bitmap bmp2 = new Bitmap(pic2.Image);
            resultOf2ImageForm.SetPicResult(imageProcess.Or2Image(bmp1, bmp2));
            resultOf2ImageForm.Show();
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pic1.Image);
            Bitmap bmp2 = new Bitmap(pic2.Image);
            resultOf2ImageForm.SetPicResult(imageProcess.Xor2Image(bmp1, bmp2));
            resultOf2ImageForm.Show();
        }
    }
}
