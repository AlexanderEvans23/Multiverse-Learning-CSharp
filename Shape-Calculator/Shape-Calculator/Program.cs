using Shape_Calculator;
using System;
//To-Do: Using the Shape class, we want to be able to make other shape subclasses and calculate their area with an area method


namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape(5, 2);
            Console.WriteLine(shape1.area());
        }
    }
}
