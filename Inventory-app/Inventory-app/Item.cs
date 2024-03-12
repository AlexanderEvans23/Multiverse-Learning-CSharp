using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_app
{
    //class to be the base for creating items
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public int Id { 
            get { return quantity; }
            set { id = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            //Only want a max 100 items per item
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

        public Item(string name, string description, int quantity, double price)
        {
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
        }

    }
}
