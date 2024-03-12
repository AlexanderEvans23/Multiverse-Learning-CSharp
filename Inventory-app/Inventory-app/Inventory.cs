using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_app
{
    //class to keep track of inventory as a whole
    internal class Inventory
    {
        //array to keep track of stock
        List<Item> items = new List<Item>();

        public Inventory() 
        { 
        }

        //method that allows user to add new item to inventory
        public List<Item> addItem(Item item)
        {
            items.Add(item);
            return items;
        }

        //method that allows user to delete item from inventory
        public void removeItem(Item item)
        {
            items.Remove(item);
            GC.Collect();
        }

        //method that allows user update item in inventory
        public void updateItem(Item item, Item newItem)
        {
            
        }
    }
}
