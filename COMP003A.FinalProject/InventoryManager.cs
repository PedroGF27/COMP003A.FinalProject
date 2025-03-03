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
  

        public void AddInventory(string inventoryName, int inventoryAmount, double cost)
        {
            inventory.Add(new Inventory(inventoryName, inventoryAmount, cost));
        }

        public static void ShowAllItems(List<Inventory> inventory)
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item name: {item.InventoryName} - Inventory Amount: {item.InventoryAmount} - Cost: {item.Cost}\n");
            }
        }

        //public void DisplayFullInventory()
        //{
        //    foreach (var item in inventories)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
    }
}
