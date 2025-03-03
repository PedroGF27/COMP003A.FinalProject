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
            List<Inventory> Inventories = new List<Inventory>();
            bool exit = false;
            while (!exit)
            {
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
                    choice = Convert.ToInt32(Console.ReadLine());
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

                            Console.WriteLine("Item/Inventory Amount: ");
                            int inventoryAmount = int.Parse(Console.ReadLine());

                            Console.WriteLine("Cost of item/inventory: ");
                            double cost = Convert.ToDouble(Console.ReadLine());

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

                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Showing Full Inventory...");
                            //InventoryUtility ShowInventory = new InventoryUtility();
                            InventoryManager.ShowAllItems(Inventories);
                            break;
                        }
                    case 5:
                        {
                            exit = true;
                            Console.WriteLine("Ending Program....");
                            break;
                        }

                }


            }
        }
    }
}
