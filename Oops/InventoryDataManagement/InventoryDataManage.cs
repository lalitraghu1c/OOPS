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

        public void WriteJsonFile(string file)
        {
            var json = JsonConvert.SerializeObject(inventories);
            File.WriteAllText(file, json);
        }
    }
}