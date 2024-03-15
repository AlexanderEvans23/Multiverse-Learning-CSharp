using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Inventory_app
{

    public class Start
    {
    
        //method to check the availability of items
        public void availability(Item item)
        {
            if (item.Quantity <= 0) {
                Console.WriteLine($"{item.Name} is Out of Stock");
            } else
            {
                Console.WriteLine($"{item.Name} is in stock and we currently have a total of {item.Quantity}");
            }
            //check the item quantity and if it is zero then it does not have the item
        }

        public string itemTotal (Item item) {
            double multiplicative = item.Quantity * item.Price;
            return $"The amount of {item.Name} has a total value of {multiplicative} in stock currently.";
        }

        public string inventoryTotal(List<Item> inventory)
        {
            double totalQuantity = 0;
            double totalPrice = 0;
            double finalTotal = 0;
            //grab the amount of all inventory item quantities and all of the totals and multiply the two totals together.
            for (int i = 0; i < inventory.Count; i++)
            {
                totalQuantity += inventory[i].Quantity;
                totalPrice += inventory[i].Price;
            }

            finalTotal = totalQuantity * totalPrice;
            return $"The total inventory cost is ${finalTotal}.";
        }

        public static void fullReport(List<Item> inventory)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"---------\n{inventory[i].Name}:\nDescription: {inventory[i].Description}\nAmount: {inventory[i].Quantity}\nPrice: ${inventory[i].Price}\n---------");
            }
        }

        public static void runApp(Inventory inventory)
        {
            int selection = 5;
            while (selection > 0)
            {
                Console.WriteLine("1: View Inventory\n2: Add Inventory\n3: Delete Inventory\n4: Update Inventory\n0: Quit");
                selection =  Convert.ToInt32(Console.ReadLine());
            
                switch (selection)
                {
                    case 1:
                        fullReport(inventory.items);
                        break;
                    case 2:
                        Console.WriteLine("What would you like to add?");
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Description: ");
                        string description = Console.ReadLine();

                        Console.WriteLine("Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Amount: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        inventory.items.Add(new Item(name, description, quantity, price));
                        Console.WriteLine("Item added");
                        break;
                    case 3:
                        Console.WriteLine("Which item would you like to delete: ");
                        string item = Console.ReadLine();

                        for (int i = 0; i < inventory.items.Count; i++)
                        {
                            if (inventory.items[i].Name == item)
                            {
                                inventory.items.RemoveAt(i);
                                Console.WriteLine($"{item} has been deleted");
                                break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("What would you like to update?");
                        item = Console.ReadLine();

                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();

                        Console.WriteLine("Description: ");
                        description = Console.ReadLine();

                        Console.WriteLine("Price: ");
                        price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Amount: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        Item newItem = new Item(name, description, quantity, price);

                        for (int i = 0; i < inventory.items.Count; i++)
                        {
                            if (inventory.items[i].Name.Equals(item))
                            {
                                inventory.updateItem(inventory.items[i], newItem);
                                Console.WriteLine("Item Updated");
                                break;
                            }
                        }
                        break;

                }
            }

        }
    }
}