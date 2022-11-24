using Newtonsoft.Json;
using Oops.InventoryDataMnagement;
using Oops.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps.InventoryDataManagement
{
    public class InventoryDataManage
    {
        List<Inventory> RiceList;
        List<Inventory> WheatList;
        List<Inventory> PulsesList;
        InventoryData inventories;
        public void ReadJSONFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            inventories = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            RiceList = inventories.Rice;
            WheatList = inventories.Wheat;
            PulsesList = inventories.Pulses;

        }
        public void Display()
        {
            Read(RiceList);
            Read(WheatList);
            Read(PulsesList);
        }
        public void Read(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.Price);
            }
            Console.WriteLine();
        }

        public void AddInventoryData(string inventoryName)
        {
            Inventory inventory = new Inventory();
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    RiceList.Add(inventory);
                    break;
                case "Wheat":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    WheatList.Add(inventory);
                    break;
                case "Pulses":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    PulsesList.Add(inventory);
                    break;
            }
        }
        public void EditInventoryData(string inventoryName)
        {
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("Enter name : ");
                    string nameRice = Console.ReadLine();
                    foreach (var rice in RiceList)
                    {
                        if (rice.Name.Equals(nameRice))
                        {
                            Console.Write("Enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("Enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            rice.Name = editName;
                            rice.Weight = editWeight;
                            rice.Price = editPrice;
                        }
                    }
                    break;
                case "Wheat":
                    Console.Write("Enter name : ");
                    string nameWheat = Console.ReadLine();
                    foreach (var wheat in WheatList)
                    {
                        if (wheat.Name.Equals(nameWheat))
                        {
                            Console.Write("Enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("Enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            wheat.Name = editName;
                            wheat.Weight = editWeight;
                            wheat.Price = editPrice;
                        }
                    }
                    break;
                case "Pulses":
                    Console.Write("Enter name : ");
                    string namePulse = Console.ReadLine();
                    foreach (var pulses in PulsesList)
                    {
                        if (pulses.Name.Equals(namePulse))
                        {
                            Console.Write("Enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("Enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            pulses.Name = editName;
                            pulses.Weight = editWeight;
                            pulses.Price = editPrice;
                        }
                    }
                    break;
                    void WriteJsonFile(string file)
                    {
                        var json = JsonConvert.SerializeObject(inventories);
                        File.WriteAllText(file, json);
                    }
            }

        }
    }
}