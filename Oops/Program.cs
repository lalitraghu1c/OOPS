using Oops.InventoryManagement;
using Opps.InventoryDataManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {

        static string jsonFilePath = @"D:\Projects-Bridgelabz\OOPS\OOPS\InventoryManagement\Inventory.json";
        static string InventoryDataPath = @"D:\Projects-Bridgelabz\OOPS\OOPS\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            InventoryDataManage manage = new InventoryDataManage();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the OOPS Programs");
                Console.WriteLine(" 1. Inventory Details Management\n 2. Inventory Data Management\n 3. Add Inventory\n 4. Display");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryDetailsManagement inventory = new InventoryDetailsManagement();
                        inventory.ReadJsonFile(jsonFilePath);
                        break;
                    case 2:
                        manage.ReadJSONFile(InventoryDataPath);
                        manage.Display();
                        break;
                    case 3:
                        manage.ReadJSONFile(InventoryDataPath);
                        Console.Write("Enter Inventory Name to add(Rice, Wheat, Pulse) : ");
                        string addName = Console.ReadLine();
                        manage.ReadJSONFile(InventoryDataPath);
                        manage.AddInventoryData(addName);
                        break;
                    case 4:
                        manage.Display();
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Try with right input");
                        break;
                }

            }
        }
    }
}