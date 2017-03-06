using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_Lab2
{
    public partial class Form1 : Form
    {
        private Bitmap originalImageBitmap;

        private bool isOpenImage = false;

        private bool isChooseOldColor = false;
        private bool isChooseNewColor = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "All files (*.*)|*.*";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);

                Bitmap tmpBitmap = new Bitmap(image);
                originalImageBitmap = new Bitmap(tmpBitmap, pbOriginalImage.Width, pbOriginalImage.Height);

                pbOriginalImage.Image = originalImageBitmap;

                pbOriginalImage.Cursor = System.Windows.Forms.Cursors.Hand;
                isOpenImage = true;
                //processingBtn.Enabled = true;
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (isOpenImage)
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                Bitmap layerOrig = (Bitmap)pbOriginalImage.Image;
                Bitmap layerNew = new Bitmap(layerOrig.Width, layerOrig.Height);
                processButton.Enabled = false;
                chooseColorButton.Enabled = false;

                progressBar1.Maximum = layerOrig.Height - 1;

                TransformationRGBtoLUV oldLUV = getLUVbyColor(pbOldColor.BackColor);
                TransformationRGBtoLUV newLUV = getLUVbyColor(pbNewColor.BackColor);
                TransformationRGBtoLUV defLUV = getDef(oldLUV, newLUV);

                for (int y = 0; y < layerOrig.Height; y++)
                {
                    for (int x = 0; x < layerOrig.Width; x++)
                    {
                        Color pixel = layerOrig.GetPixel(x, y);

                        TransformationRGBtoLUV pixelLUV = getLUVbyColor(pixel);

                        if (isChangedPixel(pixelLUV, oldLUV, sensetiveTrackBar.Value))
                        {
                            layerNew.SetPixel(x, y, findNewPixel(pixelLUV, defLUV));
                        }
                        else
                        {
                            layerNew.SetPixel(x, y, pixel);
                        }

                        pbNewImage.Image = layerNew;
                    }
                    progressBar1.Value = y;
                }

                this.Cursor = System.Windows.Forms.Cursors.Default;
                processButton.Enabled = true;
                chooseColorButton.Enabled = true;
            }
        }

        private TransformationRGBtoLUV getLUVbyColor(Color color)
        {
            TransformationRGBtoLUV trans = new TransformationRGBtoLUV(Convert.ToString(color.R),
                Convert.ToString(color.G), Convert.ToString(color.B));
            return trans;
        }

        private TransformationRGBtoLUV getDef(TransformationRGBtoLUV oldColor, TransformationRGBtoLUV newColor)
        {
            TransformationRGBtoLUV def = new TransformationRGBtoLUV("0", "0", "0");
            def.setL(oldColor.getL() - newColor.getL());
            def.setU(oldColor.getU() - newColor.getU());
            def.setV(oldColor.getV() - newColor.getV());
            return def;
        }

        private bool isChangedPixel(TransformationRGBtoLUV pixel, TransformationRGBtoLUV newLUV, int senset)
        {
            double def1 = Math.Pow((pixel.getL() - newLUV.getL()), 2);
            double def2 = Math.Pow(pixel.getU() - newLUV.getU(), 2);
            double def3 = Math.Pow(pixel.getV() - newLUV.getV(), 2);

            double def = Math.Pow(def1 + def2 + def3, 0.5);

            if (def < senset)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Color findNewPixel(TransformationRGBtoLUV pixelLUV, TransformationRGBtoLUV def)
        {
            TransformationRGBtoLUV newPixel = new TransformationRGBtoLUV("0", "0", "0");

            newPixel.setL(pixelLUV.getL() - def.getL());
            newPixel.setU(pixelLUV.getU() - def.getU());
            newPixel.setV(pixelLUV.getV() - def.getV());

            TransformationLUVtoRGB newPixelRGB = new TransformationLUVtoRGB(Convert.ToString(newPixel.getL()),
                Convert.ToString(newPixel.getU()), Convert.ToString(newPixel.getV()));
            
            int red = newPixelRGB.getRed();
            int green = newPixelRGB.getGreen();
            int blue = newPixelRGB.getBlue();
            if (red < 0)
                red = 0;
            else if (red > 255)
                red = 255;
            if (blue < 0)
                blue = 0;
            else if (blue > 255)
                blue = 255;
            if (green < 0)
                green = 0;
            else if (green > 255)
                green = 255;
            Color pix = Color.FromArgb(255, red, green , blue);
            return pix;
        }

        private void chooseColor(object sender, MouseEventArgs e)
        {
            if (isOpenImage)
            {
                Bitmap bmp = (Bitmap)pbOriginalImage.Image;
                pbOldColor.BackColor = Color.FromArgb(bmp.GetPixel(e.X, e.Y).ToArgb());
                isChooseOldColor = true;
                if (isChooseNewColor && isChooseOldColor)
                {
                    processButton.Enabled = true;
                }
            }
        }

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbNewColor.BackColor = colorDialog1.Color;
                isChooseNewColor = true;
                if (isChooseNewColor && isChooseOldColor)
                {
                    processButton.Enabled = true;
                }
            }
        }
    }
}
