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

        public void InventoryDescription(string inventoryName, int inventoryAmount)
        {
            Console.WriteLine($"Item Name: {inventoryName}, Inventory Amount: {inventoryAmount}");
        }

        public void InventoryDescription(string inventoryName, int inventoryAmount, double cost)
        {
            Console.WriteLine($"Item Name: {inventoryName}, Inventory Amount: {inventoryAmount}, Inventory Cost: {cost}");
        }
    }
}
