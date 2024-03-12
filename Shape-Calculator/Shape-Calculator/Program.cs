using Shape_Calculator;
using System;
//To-Do: Using the Shape class, we want to be able to make other shape subclasses and calculate their area with an area method


namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(3, 4, 5);
            Console.WriteLine(c1.area());
        }
    }
}
