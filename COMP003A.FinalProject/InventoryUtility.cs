using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    public class InventoryUtility 
    {
        

        /// <summary>
        /// Capture user Input of item name, amount, and cost.
        /// </summary>
        /// <param name="inventoryName"></param>
        /// <param name="inventoryAmount"></param>
        /// <param name="cost"></param>
        public void InventoryDescription (string inventoryName)
        {
            Console.WriteLine($"Item Name: {inventoryName}");
        }

        /// <summary>
        /// Gets item name, amount, and displays it
        /// </summary>
        /// <param name="inventoryName">Name of item</param>
        /// <param name="inventoryAmount">Amount of item</param>
        public void InventoryDescription(string inventoryName, int inventoryAmount)
        {
            Console.WriteLine($"Item Name: {inventoryName}, Inventory Amount: {inventoryAmount}");
        }

        /// <summary>
        /// Gets user imput of amount, cost, and name to display them
        /// </summary>
        /// <param name="inventoryName"></param>
        /// <param name="inventoryAmount"></param>
        /// <param name="cost"></param>
        public void InventoryDescription(string inventoryName, int inventoryAmount, double cost)
        {
            Console.WriteLine($"Item Name: {inventoryName}, Inventory Amount: {inventoryAmount}, Inventory Cost: {cost}");
        }

        //private List<Inventory> inventories = new List<Inventory>();

        //public void AddInventory()
        //{

        //}

        //public void ShowFullInventory(Inventory inventory)
        //{ 
        //    Console.WriteLine($"Item name: {inventory.InventoryName} - Inventory Amount: {inventory.InventoryAmount} - Cost: {inventory.Cost}\n");
               
                    
        //}
    }
}
