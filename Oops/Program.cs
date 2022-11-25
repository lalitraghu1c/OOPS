using Oops.InventoryManagement;
using Oops.StockManagment;
using Opps.InventoryDataManagement;
using System;
using System.Security.AccessControl;

namespace Oops
{
    class Program
    {

        static string jsonFilePath = @"D:\Projects-Bridgelabz\OOPS\OOPS\InventoryManagement\Inventory.json";
        static string inventoryDataPath = @"D:\Projects-Bridgelabz\OOPS\OOPS\InventoryDataManagement\InventoryData.json";
        static string StockDataPath = @"D:\Projects-Bridgelabz\OOPS\OOPS\StockAccountManagement\StockList.json";
        static string CustomerAccountPath = @"D:\Projects-Bridgelabz\OOPS\OOPS\CustomerAccountManagement\CustomerAccount.json";
        public static void Main(string[] args)
        {
            InventoryDataManage manage = new InventoryDataManage();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Oops Problem Statement");
                Console.WriteLine("Select any one\n1. Inventory Data\n2. Stock Data");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to the Inventory Data Programs");
                        Console.WriteLine(" 1. Inventory Details Management\n 2. Inventory Data Management\n 3. Add Inventory\n 4. Edit Inventory\n 5. Delete Whole Inventory\n 6. Delete Selected Data\n 7. Display\n 8. Exit");
                        int option1 = Convert.ToInt32(Console.ReadLine());
                        switch (option1)
                        {
                            case 1:
                                InventoryDetailsManagement inventory = new InventoryDetailsManagement();
                                inventory.ReadJsonFile(jsonFilePath);
                                break;
                            case 2:
                                manage.ReadJSONFile(inventoryDataPath);
                                manage.Display();
                                break;
                            case 3:
                                manage.ReadJSONFile(inventoryDataPath);
                                Console.Write("Enter Inventory's Name to Add (Rice, Wheat, Pulses) : ");
                                string addName = Console.ReadLine();
                                manage.ReadJSONFile(inventoryDataPath);
                                manage.AddInventoryData(addName);
                                break;
                            case 4:
                                manage.ReadJSONFile(inventoryDataPath);
                                Console.Write("Enter Inventory's Name to Edit (Rice, Wheat, Pulses) : ");
                                string editName = Console.ReadLine();
                                manage.ReadJSONFile(inventoryDataPath);
                                manage.EditInventoryData(editName);
                                break;
                            case 5:
                                manage.ReadJSONFile(inventoryDataPath);
                                Console.Write("Enter Inventory's Name to Delete (Rice, Wheat, Pulses) : ");
                                string delAll = Console.ReadLine();
                                manage.ReadJSONFile(inventoryDataPath);
                                manage.AllDelteInventoryData(delAll);
                                break;
                            case 6:
                                manage.ReadJSONFile(inventoryDataPath);
                                Console.Write("Enter Inventory's Name to Delete (Rice, Wheat, Pulses) : ");
                                string delName = Console.ReadLine();
                                manage.ReadJSONFile(inventoryDataPath);
                                manage.DeleteInventoryData(delName);
                                Console.WriteLine("Successfully Deleted");
                                break;
                            case 7:
                                manage.Display();
                                break;
                            default:
                                flag = false;
                                Console.WriteLine("Try with right input");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Welcome to the Stock Data Programs");
                        Console.WriteLine(" 1. Stock Data Management\n 2. Exit");
                        int option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                StockMangment stockMangment = new StockMangment();
                                stockMangment.Display(CustomerAccountPath, StockDataPath);
                                break;
                            case 2:
                                flag = false;
                                Console.WriteLine("Try Again");
                            break;
                        }
                        break;
                }
            }
        }
    }
}