using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface = (this.Height * Width) / 2;
            return surface;
        }
    }
}
