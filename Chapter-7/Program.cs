using System;
using System.Collections.Generic;

namespace Chapter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a list

            List<string> countries = MakeCountryList();

            PrintList(countries);

            countries.Sort();

            PrintList(countries);

            FindInList(countries, "Norway");
            FindInList(countries, "Finland");

            // Make a dictionary

            Dictionary<string, int> countriesPopulation = MakeCountryDictionary();

            PrintDictionary(countriesPopulation);

            FindKeyInDictionary(countriesPopulation, "England");
            FindKeyInDictionary(countriesPopulation, "Germany");
        }

        static List<string> MakeCountryList()
        {
            List<string> countries = new List<string>();

            countries.Add("Sweden");
            countries.Add("Norway");
            countries.Add("Denmark");

            return countries;
        }

        static void PrintList(List<string> list)
        {
            Console.WriteLine("Printing list\n");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\nFinished printing\n");
        }

        static void FindInList(List<string> list, string element)
        {
            int f = list.IndexOf(element);

            if (f != -1)
            {
                Console.WriteLine($"Found {list[f]}, it has the index position of {f}");
            }
            else
            {
                Console.WriteLine($"Sorry, {element} is not found!");
            }
        }

        static Dictionary<string, int>MakeCountryDictionary()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict["England"] = 60000000;
            dict["France"] = 80000000;
            dict["USA"] = 300000000;

            return dict;
        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            Console.WriteLine("Printing dictionary\n");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} has a population of {item.Value} million people.");
            }

            Console.WriteLine("\nFinished printing\n");
        }

        static void FindKeyInDictionary(Dictionary<string, int> dict, string key)
        {
            if (dict.ContainsKey(key))
            {
                Console.WriteLine($"Yes, the key {key} exists in the dictionary");
            }
            else
            {
                Console.WriteLine($"No, the key {key} does not exists in the dictionary");
            }
        }
    }
}
