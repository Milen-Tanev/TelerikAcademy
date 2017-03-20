﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class Square : Shape
    {
        public Square(double side) : base (side, side)
        {
        }

        public override double CalculateSurface()
        {
            double surface = (this.Height * this.Width);
            return surface;
        }
    }
}
