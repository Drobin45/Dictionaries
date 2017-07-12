using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax for dictionary

                ////Dictionary is a class. <string1, string2>- string1 is the key(which will be a string) and string2 will be the value(another string)
                ////Requires ; after last } of Dictionary.

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix"}, {"A2", "Twizzler"}, {"A3", "Reeses"}, {"A4", "Sour Patch Kids"}
            //};

            ////Printing out a full dictionary

            //foreach (KeyValuePair<string, string> item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew Code Red");

                ////Counting how many items are in your dictionary.
            //Console.WriteLine(drinkMachine.Count);

                ////Returns all keys
                ////Returns all values
            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}          
            

        }
    }
}
