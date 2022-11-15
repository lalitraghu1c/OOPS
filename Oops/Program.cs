using Oops.InventoryManagement;
using Oops.InventoryDataManagement;
using System;
namespace Oops
{
    public class Program
    {
        public static string inventoryFilePath = @"D:\Projects-Bridgelabz\Oops\Oops\InventoryManagement\Inventory.json";
        public static string inventoryDataFilePath = @"D:\Projects-Bridgelabz\Oops\Oops\InventoryDataManagement\InventoryData.json";

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oops JsonFile");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("\nWhat do you want to do?\n1. InventoryDetails\n" +
                                  "2. InventoryData\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                        inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
                        break;
                    case 2:
                        InventoryDataManage manage = new InventoryDataManage();
                        manage.ReadJsonFile(inventoryDataFilePath);
                        break;
                    default:
                        condition = false;
                        break;
                }
            }
        }
    }
}
