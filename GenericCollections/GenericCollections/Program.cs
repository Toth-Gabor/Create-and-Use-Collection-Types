using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countryLookUp = new Dictionary<string, string>();
            countryLookUp["30"] = "Grecee";
            countryLookUp["36"] = "Hungary";
            countryLookUp["39"] = "Italy";
            countryLookUp["46"] = "Sweden";

            Console.WriteLine("The 46 country code for: {0}", countryLookUp["46"]);

            foreach (var item in countryLookUp)
            {
                string code = item.Key;
                string country = item.Value;
                Console.WriteLine("Country code: {0}, coutry name: {1}", code, country);
            }
            Console.Read();
        }
    }
}
