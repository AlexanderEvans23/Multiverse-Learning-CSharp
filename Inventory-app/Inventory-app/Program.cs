using Inventory_app;
using System;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args) { 
            Inventory I1 = new Inventory();
            Console.WriteLine(I1);
            Item grapes = new Item("Grapes", "Delicious, Juicy Snacks", 5, 5.05D);
            Item apples = new Item("Apples", "Delicious, Juicy Snacks", 8, 7.05D);
            Console.WriteLine(grapes);
            Console.WriteLine(apples);
            I1.items.Add(grapes);
            I1.items.Add(apples);
            //Console.WriteLine(string.Join(",", I1.items));
            foreach(Item item in I1.items)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}