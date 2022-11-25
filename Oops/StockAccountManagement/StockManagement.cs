using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.StockManagment
{
    public class StockMangment
    {
        CustomerAccountList customerAccountList;
        List<CustomerAccount> Lalit_List;
        List<CustomerAccount> Sidd_List;

        public void ReadJsonFileAccount(string file)
        {
            var jsonData = File.ReadAllText(file);
            customerAccountList = JsonConvert.DeserializeObject<CustomerAccountList>(jsonData);
            Lalit_List = customerAccountList.Lalit;
            Sidd_List = customerAccountList.Sidd;
        }
        public void ReadJSonFile(string file)
        {
            var JsonData = File.ReadAllText(file);
            List<CustomerAccount> inventories = JsonConvert.DeserializeObject<List<CustomerAccount>>(JsonData);
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + "  " + data.NoOfShares + "  " + data.SharePerPrice);
            }
        }

        public void Display(string file, string file1)
        {
            ReadJsonFileAccount(file);
            Read(Lalit_List);
            Read(Sidd_List);
            Console.WriteLine();
            ReadJSonFile(file1);
        }

        public void Read(List<CustomerAccount> customer)
        {
            foreach (var data in customer)
            {
                Console.WriteLine(data.Name + " " + data.NoOfShares + " " + data.SharePerPrice);
            }
        }
    }
}