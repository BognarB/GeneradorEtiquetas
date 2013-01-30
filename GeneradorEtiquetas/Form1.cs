using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeneradorEtiquetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneradorEtiquetas.Barcode.BarcodeGenerator code = new Barcode.BarcodeGenerator();
            System.Drawing.Graphics graphic = Graphics.FromImage(new Bitmap(1, 1));
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            graphic = Graphics.FromImage(bmp);

            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/bc.png";

            code.DrawCode128(graphic, textBox1.Text, 0, 0).Save(path, System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.ImageLocation = path;

            label1.Text = textBox1.Text;
        }
    }
}
