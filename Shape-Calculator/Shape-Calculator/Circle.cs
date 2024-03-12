using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    public class Circle : Shape
    {
        public Circle(int shapeLength, int shapeWidth) : base(shapeLength, shapeWidth)
        {
           
        }

        int waistline;

        public Circle(int circleRadius)
        {
             waistline = circleRadius;
        }

        public int radius()
        {
            return 
        }
    }
}
