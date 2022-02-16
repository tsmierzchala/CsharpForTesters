using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{
    public class Listy
    {
        public static void Main(string[] args)
        {
            List<string> starWars = new List<string>();

            starWars.Add("Han Solo");
            starWars.Add("Luke Skywalker");
            starWars.Add("Darth Vader");
            starWars.Add("C-3PO");
            starWars.Add("Leia Organa");
            starWars.Add("Obi-Wan Kenobi");

            Console.WriteLine($"Last element on list {starWars[^1]}");   
            
            starWars.Reverse();
            Console.WriteLine("\nReverse:");
            foreach (string s in starWars) { Console.WriteLine(s); }

            Console.WriteLine("\nSortowanie:");
            starWars.Sort();

            foreach (string s in starWars) { Console.WriteLine(s); }

            Console.WriteLine($"\nPierwszy element: {starWars[0]}");

        }
    }
}
