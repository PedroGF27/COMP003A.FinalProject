using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    public class InventoryManager
    {
        private List<Inventory> inventories = new List<Inventory>();

        public void AddInventory (Inventory inventory)
        {
            inventories.Add(inventory);
        }

        public void DisplayFullInventory()
        {
            foreach (var item in inventories)
            {
                Console.WriteLine(item);
            }

        }
    }
}
