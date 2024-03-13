using Inventory_app;
using System;

namespace Inventory_app
{
    class Program
    {
        static void Main(string[] args) {
            Inventory T1 = new Inventory(); 
            Start.runApp(T1);
            Console.ReadKey();
        }
    }
}