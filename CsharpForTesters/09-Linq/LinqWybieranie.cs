using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpForTesters._09_Linq
{
    public class LinqWybieranie
    {
        public static void Main(string[] args)
        {
            List<string> beers = new List<string>() { "Lwówek", "Lech", "EB", "Perła", "Jasne pełne", "Redd's", "Piast", "Leżajsk", "Piwo jasne", "Piwo zimne" };
            // dobre piwa to takie które zaczynają się na literę P
            // IEnumerable<string> dobrePiwa = ...

            // niedobre piwa to takie które zaczynają się na literę L



            List<int> numbers = new List<int>()
            {
                15,11,12,9,24,21,32,44,333,49,45,50,120,100,43,31,97
            };

            // znajdź liczby podzielne przez 5
            // List<int> fiveMultiplies = ...
            var podzielnePrzez5 = numbers.Where(e => e%5==0).ToList();

            foreach (int n in podzielnePrzez5)
            {
                Console.WriteLine(n);
            }
        }
    }
}
