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
    public partial class HistographicForm : Form
    {
        public HistographicForm()
        {
            InitializeComponent();
        }

        public void SetImage(Bitmap bmp)
        {
            ptxHistographic.Image = bmp;
        }

        private void HistographicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
