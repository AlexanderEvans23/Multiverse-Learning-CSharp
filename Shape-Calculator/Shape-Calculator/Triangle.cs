using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{


    internal class Triangle : Shape
    {
        int bottom;

        public Triangle(int shapeLength, int shapeWidth, int shapeHeight, int bottom) : base(shapeLength, shapeWidth, shapeHeight)
        {
            this.bottom = bottom;
        }

        public override int area()
        {
            return (int)(0.5 * (bottom * height));
        }
    }
}
