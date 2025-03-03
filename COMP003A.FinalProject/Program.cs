// Pedro Garcia
// COMP003A
// Johnathan Cruz
// Inventory Tracking System
namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryUtility inventoryUtility = new InventoryUtility();
            InventoryManager inventoryManager = new InventoryManager();
            List<Inventory> Inventories = new List<Inventory>();
            bool exit = false;
            while (!exit)
            {
                //Choices for user
                Console.WriteLine("- - - Inventory Tracker - - -");
                Console.WriteLine("1. Add an Item");
                Console.WriteLine("2. Remove an Item");
                Console.WriteLine("3. Edit an Item");
                Console.WriteLine("4. View full Inventory");
                Console.WriteLine("5. Exit");
                Console.Write("(1-5): ");
                int choice;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine()); // converst to an integer
                }
                catch
                {
                    Console.WriteLine("Invalid input. Choose a number 1-5");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        {
                            //InventoryUtility ItemDescription = new InventoryUtility();
                            Console.WriteLine("Item/Inventory name: ");
                            string inventoryName = Console.ReadLine();

                            Console.WriteLine("\nItem/Inventory Amount: ");
                            int inventoryAmount = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nCost of item/inventory: ");
                            double cost = Convert.ToDouble(Console.ReadLine());

                            // create new inventory item and adds it to list
                            Inventory inventory = new Inventory(inventoryName, inventoryAmount, cost);
                            Inventories.Add(inventory);
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Console.Write("Enter Name of Item you want Removed: ");
                                string removeInventory = Console.ReadLine();

                                // Finds index of the item user chooses, checks if item is found, and if found it removes the item
                                int itemRemoval = Inventories.FindIndex(inventory => inventory.InventoryName == removeInventory);
                                if (itemRemoval != -1)
                                {
                                    Inventories.RemoveAt(itemRemoval);
                                    Console.WriteLine("Inventory Removed.");
                                }

                            }
                            catch
                            {
                                Console.WriteLine("Unsuccessful - Try Again.");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("\nEnter Name of Item you want to Edit: ");
                            string edit = Console.ReadLine();

                            // Find index of item, edit quantity and cost.
                            int itemEdit = Inventories.FindIndex(items => items.InventoryName == edit);

                            if (itemEdit != -1)
                            {
                                Console.Write($"Enter new quantity for {edit}: ");
                                int amountUpdate = int.Parse(Console.ReadLine());

                                Console.Write($"Enter new cost for {edit}: ");
                                double newValue = double.Parse(Console.ReadLine());

                                // updates item cost and amount
                                Inventories[itemEdit].InventoryAmount = amountUpdate;
                                Inventories[itemEdit].Cost = newValue;

                                Console.WriteLine("\n - - - Edit Complete - - -\n");
                            }
                            else
                            {
                                Console.WriteLine("Please Try Again.");
                            }
                            //Console.Write("Enter Name of Item you want to Edit: ");
                            //string edit = Console.ReadLine();

                            //int itemEdit = Inventories.FindIndex(items => items.InventoryName == edit);

                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Showing Full Inventory...");
                            //InventoryUtility ShowInventory = new InventoryUtility();
                            InventoryManager.ShowAllItems(Inventories); // shows all item in the inventory
                            break;
                        }
                    case 5:
                        {
                            exit = true;
                            Console.WriteLine("Ending Program....");
                            break;
                        }
                    default:
                        Console.WriteLine("Try Again.");
                        break;

                }


            }
        }
    }
}
