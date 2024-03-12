using Inventory_app;
using System;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args) { 
            Inventory I1 = new Inventory();
            Item grapes = new Item("Grapes", "Delicious, Juicy Snacks", 5, 5.05D);
            I1.addItem(grapes);
            Console.WriteLine(string.Join(",", I1.items));
            Console.ReadKey();
        }
    }
}