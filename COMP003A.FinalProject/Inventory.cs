using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    public class Inventory
    {
        // cost will be optional
        private string _inventoryName;
        private int _inventoryAmount;
        private double _cost;


        public string InventoryName
        {
            get { return _inventoryName; }
            set
            {
                _inventoryName = value;
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter an Item");
                }
            }
        }

        public int InventoryAmount
        {
            get { return _inventoryAmount; }
            set { _inventoryAmount = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        /// <summary>
        /// Constructor for inventoryName - inventoryAmount - cost
        /// </summary>
        /// <param name="inventoryName"></param>
        /// <param name="inventoryAmount"></param>
        /// <param name="cost"></param>
        public Inventory(string inventoryName, int inventoryAmount, double cost)
        {
            _inventoryAmount = inventoryAmount;
            _inventoryName = inventoryName; 
            _inventoryAmount = inventoryAmount; 
        }

        public override string ToString()
        {
            return $"Item name: {InventoryName} - Inventory Amount: {InventoryAmount} - Cost: {Cost}\n";
        }

        //public void ShowFullInventory()
        //{
        //    foreach (var inventory in )


        //    //Console.WriteLine($"Item name: {InventoryName} - Inventory Amount: {InventoryAmount} - Cost: {Cost}\n");


        //}
    }
}
