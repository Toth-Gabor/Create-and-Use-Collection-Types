using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable lookUp = new Hashtable();
            lookUp.Add("0", "Zero");
            lookUp.Add("1", "One");
            lookUp.Add("2", "Two");
            lookUp.Add("3", "Three");
            lookUp.Add("4", "Four");
            lookUp.Add("5", "Five");
            lookUp.Add("6", "Six");
            lookUp.Add("7", "Seven");
            lookUp.Add("8", "Eight");
            lookUp.Add("9", "Nine");

            String myNumber = "124556632";
            foreach (char c in myNumber)
            {
                string digit = c.ToString();
                if (lookUp.ContainsKey(digit))
	            {
                    Console.WriteLine(lookUp[digit]);
                }
            }
            Console.ReadLine();
        }
    }
}
