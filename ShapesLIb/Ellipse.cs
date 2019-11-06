using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesLIb
{
    public class Ellipse : Circle
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
            g.DrawEllipse(randcolor, x, y, width, height);
        }
    }
}
