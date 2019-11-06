using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLIb;

namespace OOPDraw1
{
    public partial class Form1 : Form
    {
        Bitmap canvas;
        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void ButtonPaint_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(canvas);
            Shape[] array = new Shape[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int menu = rand.Next(1, 5);
                switch (menu)
                {
                    case 1:
                        array[i] = new Dot(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Height), rand.Next(0, 100));
                        array[i].Draw(g);
                        break;
                    case 2:
                        array[i] = new Line(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
                        array[i].Draw(g);
                        break;
                    case 3:
                        array[i] = new ShapesLIb.Rectangle(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
                        array[i].Draw(g);
                        break;
                    case 4:
                        array[i] = new Circle(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width));
                        array[i].Draw(g);
                        break;
                    case 5:
                        array[i] = new Ellipse(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
                        array[i].Draw(g);
                        break;
                }
            }
            pictureBox1.Image = canvas;

        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(canvas);
            Brush color = new SolidBrush(Color.White);
            RectangleF rect = new RectangleF(0, 0, pictureBox1.Width, pictureBox1.Height);
            g.FillRectangle(color, rect);
            pictureBox1.Image = canvas;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ButtonPaint_Paint(object sender, PaintEventArgs e)
        {
           

        }
    }
}
