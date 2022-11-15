using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryManagement
{
    public class InventoryDetailsManagement
    {
        public void ReadJsonFile(string file)
        {
            var JsonData = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(JsonData);
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\n");
            }
        }
    }
}