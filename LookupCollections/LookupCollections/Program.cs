using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary list = new ListDictionary();
            list.Add("Estados Unidos", "United States");
            list.Add("Canadá", "Canada");
            list.Add("España", "Spain");
            Console.WriteLine(list["España"]);
            Console.WriteLine(list["Canadá"]);
            Console.ReadLine();
        }
    }
}
