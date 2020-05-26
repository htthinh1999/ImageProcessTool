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
    public partial class ResultOf2ImageForm : Form
    {
        public ResultOf2ImageForm()
        {
            InitializeComponent();
        }

        private void ResultOf2ImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void SetPicResult(Bitmap bmp)
        {
            picResultOf2Image.Image = bmp;
        }
    }
}
