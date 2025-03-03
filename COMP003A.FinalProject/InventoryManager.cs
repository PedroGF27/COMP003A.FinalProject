using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    public class InventoryManager
    {
        //private List<Inventory> inventories = new List<Inventory>();
        private List<Inventory> inventory = new List<Inventory>();

  
        /// <summary>
        /// Adds new inventory to list
        /// </summary>
        /// <param name="inventoryName"></param>
        /// <param name="inventoryAmount"></param>
        /// <param name="cost"></param>
        public void AddInventory(string inventoryName, int inventoryAmount, double cost)
        {
            inventory.Add(new Inventory(inventoryName, inventoryAmount, cost));
        }

        /// <summary>
        /// Displays all items in list.
        /// </summary>
        /// <param name="inventory"></param>
        public static void ShowAllItems(List<Inventory> inventory)
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item name: {item.InventoryName} - Inventory Amount: {item.InventoryAmount} - Cost: ${item.Cost}\n");
            }
        }

        public void EditInventory()
        {
            //Console.Write("Enter Name of Item you want to Edit: ");
            //string edit = Console.ReadLine();

            //int itemEdit = inventory.FindIndex(items => items.InventoryName == edit);

            //if (itemEdit != -1)
            //{
            //    Console.Write($"Enter new quantity for {edit}: ");
            //    int amountUpdate = int.Parse(Console.ReadLine());

            //    Console.Write($"Enter new cost for {edit}: ");
            //    double newValue = double.Parse(Console.ReadLine());

            //    inventory[itemEdit].InventoryAmount = amountUpdate;
            //    inventory[itemEdit].Cost = newValue;
                 
            //    Console.WriteLine("Edit Complete.");
            //}
            //else
            //{
            //    Console.WriteLine("Please Try Again.");
            //}
        }

        //public void ItemRemoval()
        //{
        //    Console.Write("Enter Name of Item you want Removed: ");
        //    string removeInventory = Console.ReadLine();

        //    Inventory removeItem = inventory.FindIndex(name => name == removeInventory);
        //}

        //public void DisplayFullInventory()
        //{
        //    foreach (var item in inventories)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
    }
}
