using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("AF", "Afghanistan");
            country.Add("AL", "Albania");
            country.Add("AS", "American Samoa");
            country.Add("AD", "Andorra");
            country.Add("AM", "Armenia");
            country.Add("AW", "Aruba");
            country.Add("AU", "Australia");
            country.Add("AT", "Austria");
            country.Add("AZ", "Azerbaijan");
            foreach (var item in country)
            {
                Console.WriteLine("{0,2} = {1}", item.Key, item.Value);
            }
            Console.WriteLine("Count of items = {0}", country.Count);
            Console.WriteLine("\n** Direct access to value by key **");
            country["AU"] = "AUSTRALIA";
            Console.WriteLine("AU = " + country["AU"]);

            Console.WriteLine("\n** Remove by key **");
            country.Remove("AU");
            foreach (var item in country)
            {
                Console.WriteLine("{0,2} = {1}", item.Key, item.Value);
            }
            Console.WriteLine("Count of items = {0}", country.Count);
            Console.ReadLine();
        }
    }
}
