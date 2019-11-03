using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw1
{
    public partial class Form1 : Form
    {
        abstract class Shape
        {
            protected int x1, y1;
            protected Color color;
            public Shape(Color color, int x, int y)
            {
                this.color = color;
                this.x1 = x;
                this.y1 = y;
            }
            public abstract void Draw(Graphics g);
        }
        class Dot : Shape
        {
            protected int rad;
            public Dot(Color color, int x, int y)
                : base(color, x, y) { }
            public Dot(Color color, int x, int y, int rad)
                : base(color, x, y) {
                this.rad = rad;
            }

            public override void Draw(Graphics g)
            {
                Brush brush = new SolidBrush(color);
                g.FillEllipse(brush, x1, y1, rad, rad);
            }
        }
        class Line : Dot
        {
            protected int x2;
            protected int y2;
            public Line(Color color, int x1, int y1, int x2)
                : base(color, x1, y1, x2) { }
            public Line(Color color, int x1, int y1, int x2, int y2)
                : base(color, x1, y1, x2)
            {
                this.x2 = x2;
                this.y2 = y2;
            }
            public override void Draw(Graphics g)
            {
                Pen randcolor = new Pen(color, 3);
                g.DrawLine(randcolor, x1, y1, x2, Math.Abs(y2));
            }
        }
        class Rectangle : Line
        {
            protected int width;
            protected int height;
            public Rectangle(Color color, int x, int y, int width, int height)
                : base(color, x, y, width)
            {
                this.width = width;
                this.height = height;
            }
            public override void Draw(Graphics g)
            {
                Pen randcolor = new Pen(color, 3);
                g.DrawRectangle(randcolor, x1, y1, width, height);

            }
        }
        class Circle : Dot
        {
            protected int radius;
            public Circle(Color color, int x, int y, int radius)
                : base(color, x, y, radius)
            {
                this.radius = radius;
            }
            public override void Draw(Graphics g)
            {
                Pen randcolor = new Pen(color, 3);
                g.DrawEllipse(randcolor, x1, y1, radius, radius);

            }
        }
        class Ellipse : Circle
        {
            protected int width;
            protected int height;
            public Ellipse(Color color, int x, int y, int width, int height)
                : base(color, x, y, width)
            {
                this.width = width;
                this.height = height;
            }
            public override void Draw(Graphics g)
            {
                Pen randcolor = new Pen(color, 3);
                g.DrawEllipse(randcolor, x1, y1, width, height);
            }
        }


        Bitmap canvas;
        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void ButtonPaint_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Shape[] array = new Shape[20];
            Random rand = new Random();
            



            for (int i = 0; i < 20; i++)
            {
                int menu = rand.Next(1, 5);
                switch (menu)
                {
                    case 1:
                        Dot dot = new Dot(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, 100));
                        dot.Draw(g);
                        break;
                    case 2:
                        Line line = new Line(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
                        line.Draw(g);
                        break;
                    case 3:
                        Rectangle rectangle = new Rectangle(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
                        rectangle.Draw(g);
                        break;
                    case 4:
                        Circle circle = new Circle(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width));
                        circle.Draw(g);
                        break;
                    case 5:
                        Ellipse ellipse = new Ellipse(Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height), rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
                        ellipse.Draw(g);
                        break;
                }
            }
        }
  

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Brush color = new SolidBrush(Color.White);
            RectangleF rect = new RectangleF(0, 0, pictureBox1.Width, pictureBox1.Height);
            g.FillRectangle(color, rect);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
