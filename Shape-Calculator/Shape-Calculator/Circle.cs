using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(int shapeLength, int shapeWidth,int shapeHeight,  double radius) : base(shapeLength, shapeWidth, shapeHeight)
        {
            this.radius = radius;
        }
        

        

        public override int area()
        {
            return (int)(3.14 * (radius * radius));
        }
    }

    
}
