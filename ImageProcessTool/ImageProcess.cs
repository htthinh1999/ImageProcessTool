using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessTool
{
    class ImageProcess
    {
        public Bitmap ToGray(Bitmap original)
        {
            Bitmap bitmap = new Bitmap(original);
            int x = 0;
            int y = 0;
            Color c = default(Color);
            byte gray = 0;
            for (y = 0; y <= original.Height - 1; y++)
            {
                for (x = 0; x <= original.Width - 1; x++)
                {
                    c = original.GetPixel(x, y);
                    gray = Convert.ToByte(c.R * 0.287 + c.G * 0.599 + c.B * 0.114);
                    bitmap.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return bitmap;

        }

        public Bitmap ToBinary(Bitmap bm, byte band)
        {
            Bitmap bitmap = new Bitmap(bm);
            int x = 0;
            int y = 0;
            Color c = default(Color);
            for (y = 0; y <= bm.Height - 1; y++)
            {
                for (x = 0; x <= bm.Width - 1; x++)
                {
                    c = bm.GetPixel(x, y);
                    if (c.R < band)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            return bitmap;
        }

        public Bitmap ToBinaryLocBits(Bitmap bm, byte band)
        {
            Bitmap bitmap = new Bitmap(bm);
            Rectangle rec = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            System.Drawing.Imaging.BitmapData bmpData = bitmap.LockBits(rec, System.Drawing.Imaging.ImageLockMode.ReadWrite, bitmap.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = bmpData.Stride * bitmap.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            byte color = 0;
            for (int counter = 0; counter <= rgbValues.Length - 1; counter += 4)
            {
                color = rgbValues[counter];
                if (color < band)
                {
                    rgbValues[counter + 0] = 0;
                    rgbValues[counter + 1] = 0;
                    rgbValues[counter + 2] = 0;
                }
                else
                {
                    rgbValues[counter + 0] = 255;
                    rgbValues[counter + 1] = 255;
                    rgbValues[counter + 2] = 255;
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bitmap.UnlockBits(bmpData);
            return bitmap;
        }

        public Bitmap HistogramGray(Bitmap bm)
        {
            int[] h = new int[256];
            //Tinh H(x)
            int x = 0;
            int y = 0;
            for (y = 0; y <= bm.Height - 1; y++)
            {
                for (x = 0; x <= bm.Width - 1; x++)
                {
                    h[bm.GetPixel(x, y).R] += 1;
                }
            }
            //Phân bố lại khích với pictureBox
            int max = h[0];
            for (int j = 1; j <= 255; j++)
            {
                if (max < h[j])
                {
                    max = h[j];
                }
            }
            //Vẽ
            int Height = 100;
            Bitmap bmHistogram = new Bitmap(256, 100);
            Graphics gp = Graphics.FromImage(bmHistogram);
            gp.FillRectangle(new Pen(Color.Black).Brush, new Rectangle(0, 0, bmHistogram.Width, bmHistogram.Height));
            int n = 0;
            for (int i = 0; i <= 255; i++)
            {
                n = (h[i] * Height) / max;
                gp.DrawLine(new Pen(Color.Gray), i, 100, i, 100 - n);
            }
            return bmHistogram;
        }

        public Bitmap HistogramStep(Bitmap bm, int n)
        {
            Bitmap bipmap = new Bitmap(bm);
            int x = 0;
            int y = 0;
            Color c = default(Color);
            for (y = 0; y <= bipmap.Height - 1; y++)
            {
                for (x = 0; x <= bipmap.Width - 1; x++)
                {
                    c = bipmap.GetPixel(x, y);
                    if ((c.R + n) <= 255 & (c.R + n) >= 0)
                    {
                        bipmap.SetPixel(x, y, Color.FromArgb(c.R + n, c.R + n, c.R + n));
                    }
                    else if ((c.R + n) > 255)
                    {
                        bipmap.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else if ((c.R + n) < 0)
                    {
                        bipmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            return bipmap;
        }

        public Bitmap HisToGramStretch(Bitmap bm, float n)
        {
            if (n <= 0)
            {
                return null;
            }
            Bitmap bipmap = new Bitmap(bm);
            int x = 0;
            int y = 0;
            Color c = default(Color);
            for (y = 0; y <= bipmap.Height - 1; y++)
            {
                for (x = 0; x <= bipmap.Width - 1; x++)
                {
                    c = bipmap.GetPixel(x, y);
                    if ((c.R * n) <= 255 & (c.R * n) >= 0)
                    {
                        bipmap.SetPixel(x, y, Color.FromArgb(Convert.ToByte(c.R * n), Convert.ToByte(c.R * n), Convert.ToByte(c.R * n)));
                    }
                    else if ((c.R * n) > 255)
                    {
                        bipmap.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else if ((c.R * n) < 0)
                    {
                        bipmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            return bipmap;
        }


        public void GetH(Bitmap bm, int[] toH)
        {
            int x = 0;
            int y = 0;
            for (y = 0; y <= bm.Height - 1; y++)
            {
                for (x = 0; x <= bm.Width - 1; x++)
                {
                    toH[bm.GetPixel(x, y).R] += 1;
                }
            }
        }

        public byte HistogramLeft(int[] h)
        {
            for (int i = 0; i <= h.Length - 1; i++)
            {
                if (h[i] != 0)
                {
                    return Convert.ToByte(i);
                }
            }
            return 0;
        }
        public byte HistogramRight(int[] h)
        {
            for (int i = h.Length - 1; i >= 0; i += -1)
            {
                if (h[i] != 0)
                {
                    return Convert.ToByte(i);
                }
            }
            return 0;
        }


        public Bitmap HistogramEdit(Bitmap bm)
        {
            Bitmap bipmap = new Bitmap(bm);
            //Tinh  h(x)
            int[] hL = new int[256];
            int[] hR = new int[256];
            GetH(bipmap, hL);
            //Tim Trai & truot trai
            int left = HistogramLeft(hL);
            bipmap = new Bitmap(HistogramStep(bm, -left));
            //Tinh tien ve 0 va copy hL qua hR
            Array.Copy(hL, left, hR, 0, hL.Length - left);
            int x = 0;
            int y = 0;
            byte c = 0;
            byte max = HistogramRight(hR);
            for (y = 0; y <= bipmap.Height - 1; y++)
            {
                for (x = 0; x <= bipmap.Width - 1; x++)
                {
                    c = bipmap.GetPixel(x, y).R;
                    c = Convert.ToByte(c * 255 / max);
                    bipmap.SetPixel(x, y, Color.FromArgb(c, c, c));
                }
            }
            return bipmap;
        }

        public Bitmap HistogramEqualization(Bitmap bm)
        {
            Bitmap bitmap = new Bitmap(bm);
            int w = bitmap.Width * bitmap.Height;
            //Tinh to chuc do
            int[] h = new int[256];
            float[] hN = new float[256];
            GetH(bm, h);

            //Chuan hoa to chuc do
            for (int i = 0; i <= 255; i++)
            {
                hN[i] = (float)h[i] / w;
            }

            //Tinh ham mat do xac Suat
            float[] Z = new float[256];
            Z[0] = hN[0];
            for (int i = 1; i <= 255; i++)
            {
                Z[i] = Z[i - 1] + hN[i];
            }

            int x = 0;
            int y = 0;
            byte c = 0;

            for (y = 0; y <= bitmap.Height - 1; y++)
            {
                for (x = 0; x <= bitmap.Width - 1; x++)
                {
                    c = bitmap.GetPixel(x, y).R;
                    c = Convert.ToByte(Math.Round(Z[c] * 255));
                    bitmap.SetPixel(x, y, Color.FromArgb(c, c, c));
                }

            }

            return bitmap;
        }

        public Bitmap And2Image(Bitmap bm1, Bitmap bm2)
        {
            Bitmap bitmap = new Bitmap(Math.Max(bm1.Width, bm2.Width), Math.Max(bm1.Height, bm2.Height));
            for(int y=0; y<bitmap.Height; y++)
            {
                for(int x=0; x<bitmap.Width; x++)
                {
                    byte r, g, b;
                    int y1 = Math.Min(y, bm1.Height - 1);
                    int x1 = Math.Min(x, bm1.Width - 1);
                    int y2 = Math.Min(y, bm2.Height - 1);
                    int x2 = Math.Min(x, bm2.Width - 1);

                    r = Convert.ToByte(bm1.GetPixel(x1, y1).R & bm2.GetPixel(x2, y2).R);
                    g = Convert.ToByte(bm1.GetPixel(x1, y1).G & bm2.GetPixel(x2, y2).G);
                    b = Convert.ToByte(bm1.GetPixel(x1, y1).B & bm2.GetPixel(x2, y2).B);
                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            return bitmap;
        }

        public Bitmap Or2Image(Bitmap bm1, Bitmap bm2)
        {
            Bitmap bitmap = new Bitmap(Math.Max(bm1.Width, bm2.Width), Math.Max(bm1.Height, bm2.Height));
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    byte r, g, b;
                    int y1 = Math.Min(y, bm1.Height - 1);
                    int x1 = Math.Min(x, bm1.Width - 1);
                    int y2 = Math.Min(y, bm2.Height- 1);
                    int x2 = Math.Min(x, bm2.Width - 1);

                    r = Convert.ToByte(bm1.GetPixel(x1, y1).R | bm2.GetPixel(x2, y2).R);
                    g = Convert.ToByte(bm1.GetPixel(x1, y1).G | bm2.GetPixel(x2, y2).G);
                    b = Convert.ToByte(bm1.GetPixel(x1, y1).B | bm2.GetPixel(x2, y2).B);
                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            return bitmap;
        }

        public Bitmap Xor2Image(Bitmap bm1, Bitmap bm2)
        {
            Bitmap bitmap = new Bitmap(Math.Max(bm1.Width, bm2.Width), Math.Max(bm1.Height, bm2.Height));
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    byte r, g, b;
                    int y1 = Math.Min(y, bm1.Height - 1);
                    int x1 = Math.Min(x, bm1.Width - 1);
                    int y2 = Math.Min(y, bm2.Height- 1);
                    int x2 = Math.Min(x, bm2.Width - 1);
                    
                    r = Convert.ToByte(bm1.GetPixel(x1, y1).R ^ bm2.GetPixel(x2, y2).R);
                    g = Convert.ToByte(bm1.GetPixel(x1, y1).G ^ bm2.GetPixel(x2, y2).G);
                    b = Convert.ToByte(bm1.GetPixel(x1, y1).B ^ bm2.GetPixel(x2, y2).B);
                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            return bitmap;
        }

    }
}
