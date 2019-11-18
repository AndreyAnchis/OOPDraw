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

namespace ISMPaint
{
    public partial class Form1 : Form
    {
        protected List<Shape> Shapes;
        protected Mode Mode;
        protected int MouseX, MouseY, MouseX2, MouseY2;
        protected void AddShape(Shape shape)
        {
            Shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBoxMain.Refresh();
        }
        public void DeleteShape(int number)
        {
            Shapes.RemoveAt(number);
            listBoxShapes.Items.RemoveAt(number);
            pictureBoxMain.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Black;
            Shapes = new List<Shape>();
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            AddShape(new Dot(buttonColor.BackColor, 40, 50));
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxShapes.Items.Count; i++)
            {
                if (listBoxShapes.GetSelected(i))
                {
                    DeleteShape(i);
                    i--;
                }
            }
            if(listBoxShapes.Items.Count > 0)
            {
                listBoxShapes.SetSelected(0, true);
            }
        }

        private void PictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Draw(e.Graphics);
            }
        }



        private void ButtonDot_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawDot;

        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawRectangle;
        }

        private void PictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode) {
                case Mode.DrawDot:
                    Dot dot = new Dot(buttonColor.BackColor,
                                      e.X, 
                                      e.Y);
                    AddShape(dot);
                    break;
                case Mode.DrawLine:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawCircle:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawEllipse:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawRectangle:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
            }          
            pictureBoxMain.Refresh();
        }

        private void PictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = pictureBoxMain.CreateGraphics();
            switch (Mode)
            {
                
                case Mode.DrawLine:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBoxMain.Refresh();
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        //AddShape(new Line(buttonColor.BackColor, MouseX, MouseY, e.X, e.Y));
                        graphics.DrawLine(new Pen(buttonColor.BackColor, 1), MouseX, MouseY, e.X, e.Y);
                    }
                    break;
                case Mode.DrawCircle:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBoxMain.Refresh();
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        int radius = Math.Abs(MouseX - MouseX2) + Math.Abs(MouseY - MouseY2);
                        graphics.DrawEllipse(new Pen(Color.Black, 1), MouseX - radius / 2, MouseY - radius / 2, radius, radius);
                    }
                    break;
                case Mode.DrawEllipse:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBoxMain.Refresh();
                        MouseX2 = e.X;
                        MouseY2 = e.Y;                      
                        graphics.DrawEllipse(new Pen(buttonColor.BackColor, 1), MouseX, MouseY, MouseX2 - MouseX, MouseY2 - MouseY);
                    }
                    break;
                case Mode.DrawRectangle:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBoxMain.Refresh();
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        if (MouseX > MouseX2 && MouseY > MouseY2)
                        {
                         graphics.DrawRectangle(new Pen(buttonColor.BackColor, 1), MouseX2, MouseY2, MouseX - MouseX2, MouseY - MouseY2);
                        }
                        else if (MouseX < MouseX2 && MouseY < MouseY2)
                        {
                                graphics.DrawRectangle(new Pen(buttonColor.BackColor, 1), MouseX, MouseY, MouseX2 - MouseX, MouseY2 - MouseY);
                        }
                        else if (MouseX < MouseX2 && MouseY > MouseY2)
                        {
                            graphics.DrawRectangle(new Pen(buttonColor.BackColor, 1), MouseX, MouseY2, Math.Abs(MouseX2 - MouseX), Math.Abs(MouseY2 - MouseY));  
                        }
                        else if (MouseX > MouseX2 && MouseY < MouseY2)
                        {
                            graphics.DrawRectangle(new Pen(buttonColor.BackColor, 1), MouseX2, MouseY, Math.Abs(MouseX2 - MouseX), Math.Abs(MouseY2 - MouseY));
                        }
                        
                           
                    }
                    break;
            }
        }

        private void PictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode) {
                case Mode.DrawLine:
                    Shape shape1 = new Line(buttonColor.BackColor, MouseX, MouseY, e.X, e.Y);
                    AddShape(shape1);
                    break;
                case Mode.DrawCircle:
                    Shape shape2 = new Circle(buttonColor.BackColor, MouseX, MouseY, Math.Abs(MouseX - MouseX2) + Math.Abs(MouseY - MouseY2));
                    AddShape(shape2);
                    break;
                case Mode.DrawEllipse:
                    Shape shape3 = new Ellipse(buttonColor.BackColor, MouseX, MouseY, MouseX - MouseX2, MouseY - MouseY2);
                    AddShape(shape3);
                    break;
                case Mode.DrawRectangle:
                    if (MouseX > MouseX2 && MouseY > MouseY2)
                    {
                        Shape shape4 = new ShapesLIb.Rectangle(buttonColor.BackColor, MouseX2, MouseY2, MouseX - MouseX2, MouseY - MouseY2);
                        AddShape(shape4);
                    }
                    else if(MouseX < MouseX2 && MouseY < MouseY2)
                    {
                        Shape shape4 = new ShapesLIb.Rectangle(buttonColor.BackColor, MouseX, MouseY, MouseX2 - MouseX, MouseY2 - MouseY);
                        AddShape(shape4);
                    }
                    else if (MouseX < MouseX2 && MouseY > MouseY2)
                    {
                        Shape shape4 = new ShapesLIb.Rectangle(buttonColor.BackColor, MouseX, MouseY2, Math.Abs(MouseX2 - MouseX), Math.Abs(MouseY2 - MouseY));
                        AddShape(shape4);
                    }
                    else if (MouseX > MouseX2 && MouseY < MouseY2)
                    {
                        Shape shape4 = new ShapesLIb.Rectangle(buttonColor.BackColor, MouseX2, MouseY, Math.Abs(MouseX2 - MouseX), Math.Abs(MouseY2 - MouseY));
                        AddShape(shape4);
                        
                    } 
                    break;
            }

        }
    }
}
