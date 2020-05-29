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
    public partial class ResultOf2ImageForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ResultOf2ImageForm()
        {
            InitializeComponent();
        }

        private void ResultOf2ImageForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void SetPicResult(Bitmap bmp)
        {
            picResultOf2Image.Image = bmp;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picResultOf2Image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Lưu ảnh kết quả",
                Filter = "jpeg files|*.jpeg",
                FileName = "result"
            };
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picResultOf2Image.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
