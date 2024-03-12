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
        public int height;

        

        public Shape(int shapeLength, int shapeWidth, int shapeHeight)
        {
            length = shapeLength;
            width = shapeWidth;
            height = shapeHeight;
        }

        public virtual int area()
        {
            return length * width;
        }
    }
}
