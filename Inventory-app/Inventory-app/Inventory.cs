using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Complete!
namespace Inventory_app
{
    //class to keep track of inventory as a whole
    public class Inventory
    {
        //array to keep track of stock
        public List<Item> items = new List<Item>();

        public Inventory() 
        { 
        }

        //method that allows user to add new item to inventory/not needed tdue to the add method in c#
        public void addItem(Item item)
        {
            items.Add(item);
        }

        //method that allows user to delete item from inventory
        public void removeItem(Item item)
        {
            items.Remove(item);
            GC.Collect();
        }

        //method that allows user update item in inventory
        public void updateItem(Item currentItem, Item newItem)
        {
            //create a loop that allows user to find the specific item and replace it with the next item entered
           
                if (items.Contains(currentItem))
                {
                    int previous = items.IndexOf(currentItem);
                    items.RemoveAt(previous);
                    items.Insert(previous, newItem);
                    //take the list of items, grab the specific item that matches and place the new item onto the older one
                    /*int previous = items.IndexOf(item);
                    items.RemoveAt(previous);
                    items.Insert(previous, newItem);*/
                
            };
        }

        public List<Item> getItems()
        {
            return items;
        }
    }
}
