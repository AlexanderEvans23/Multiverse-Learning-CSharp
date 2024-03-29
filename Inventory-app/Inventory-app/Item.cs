﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Complete!
namespace Inventory_app
{
    //class to be the base for creating items
    public class Item
    {
        private int quantity;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

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
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}\n{Description}\n{Quantity}\n{Price}";
        }
    }
}
