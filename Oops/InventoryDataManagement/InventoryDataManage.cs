using Newtonsoft.Json;
using Oops.InventoryDataMnagement;
using Oops.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryDataManagement
{
    public class InventoryDataManage
    {
        public void ReadJsonFile(string file)
        {
            var Jsondata = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(Jsondata);
            List<Inventory> RiceList = inventories.Rice;
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
            Display(WheatList);
            List<Inventory> PulsesList = inventories.Pulses;
            Display(PulsesList);
        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)

            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\n");
            }
        }
    }
}
