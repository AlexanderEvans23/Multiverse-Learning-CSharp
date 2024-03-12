using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_app
{
    //class to be the base for creating items
    internal class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        public int Id { 
            get { return quantity; }
            set { id = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            { 
                if (value > 100) {
                    Console.WriteLine("Can only have a max of 100");
                    quantity = 100;
                } else
                {
                    quantity = value;
                }
                }
        }

    }
}
