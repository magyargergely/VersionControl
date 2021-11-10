using FactoryPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Entities
{
    class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color color, Color ribbonColor)
        {
            BoxColor = new SolidBrush(color);
            RibbonColor = new SolidBrush(ribbonColor);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 0, (float)(Height / 2.5), Width, Height/5);
            g.FillRectangle(RibbonColor, (float)(Width / 2.5), 0, Width/5, Height);
        }
    }
}
