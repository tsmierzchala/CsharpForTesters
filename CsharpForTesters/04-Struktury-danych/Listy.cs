using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{
    public class Listy
    {
        public static void Main(string[] args)
        {
            var starWarsHeroes = new List<string>()
            {
                "Han Solo",
                "Luke Skywalker",
                "Darth Vader",
                "C-3PO",
                "Leia Organa",
                "Obi-Wan Kenobi"
            };

            // liczymy od końca [^1]
            Console.WriteLine($"Ostatni element listy: {starWarsHeroes[^1]}");

            // odwracamy listę
            starWarsHeroes.Reverse();

            // drukujemy listę źle (lista jest obiektem)
            Console.WriteLine(starWarsHeroes);

            // drukujemy listę poprawnie, pętlą
            foreach (string s in starWarsHeroes)
            {
                Console.WriteLine(s);
            }

            // sortujemy listę
            starWarsHeroes.Sort();
            // liczymy od końca [^1]
            Console.WriteLine($"Po posortowaniu pierwszy element to: {starWarsHeroes[0]}");

        }
    }
}
