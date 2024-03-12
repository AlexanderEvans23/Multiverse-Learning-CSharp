using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    public class Shape
    {
        int length;
        int width;

        public Shape(int shapeLength, int shapeWidth)
        {
            length = shapeLength;
            width = shapeWidth;
        }

        public virtual int area()
        {
            return length * width;
        }
    }
}
