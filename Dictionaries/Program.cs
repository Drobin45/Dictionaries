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

            //Create a dictionary for a thearter coat check with 10 elements
            //Key will be a number, and the value will be the coat style. Then print all elements to console
            //Complete

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            //{
            //    {1, "red coat" }, {2,"blue coat" }, {3,"green coat" } ,{4, "black coat"}, {5, "Leather jacket" },
            //    { 6,"wind breaker" }, {7, "heavy sweater"}, {8, "Cardigan" }, {9, "Spiked, leather jacket" }, {10, "Hoody"},
            //};

            //foreach (KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat);
            //}

            //car valet with 10 cars. The key will be a customers last name and the value will be the car make. Print all elements
            //Complete!

            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Robinson" , "Honda"}, {"Seel" , "Honda" }, {"Myatt" , "Ford"}, {"Jouhnson" , "Kia" },
            //    { "Sartre", "Toyota"}, {"Nietzsche" , "Ford" }, {"Kierkegaard" , "Toyota" },
            //    {"Smalls" , "Ford" }, {"Trotsky" , "Chevrolet"}, {"Faukner" , "Bugate"}
            //};

            //foreach (KeyValuePair<string, string> car in carValet)
            //{
            //    Console.WriteLine(car);
            //}

            //Create a dictionoary of 10 zoo animals the key will be the animal type, the value will be the number of animals. 
            //Print the animal with the highest quality to the console.
            //Remove the zoo animal with the lowest count 

            Dictionary<string, int> zooCount = new Dictionary<string, int>()
            {
                {"Ocelots", 90 }, {"Falcons", 3 }, {"Lion fish", 987 }, {"Hedgehogs", 1 },
                {"Axolotls", 30 }, {"Octopi", 12 }, {"snakes", 40 }, {"turtles", 80 },
                {"rabbits", 1 }, {"Oxen", 60 },
            };

            var last = zooCount.Values.Max();
            Console.WriteLine(last);
            //So far, I can print out the value of the highest value object, but I can't print out the Key to that value!

           
            
            
            
        }
    }
}
