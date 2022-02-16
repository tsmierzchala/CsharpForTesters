using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class Metody
    {
        public static void Main(string[] args) {
            double wynik = Math.Round((CalculatePrice(123, 0.23) * 100)/100);
            Console.WriteLine(wynik);

            var wynik2 = MaxFrom(1, 5, 3);
            Console.WriteLine(wynik2);

            Console.WriteLine(PrintText("Hobbit", "JR. Tolkien", "Wydawnictwo X"));
            
        }

        //zadanie 10
        public static double CalculatePrice(int price, double discount) {
            return price - (price * discount);
        }

        //zadanie 11
        public static double MaxFrom(double a, double b, double c)
        {
            var max =  Math.Max(a, b);
            max = Math.Max(c, max);
            return max;
        }

        //zadanie 12
        public static string PrintText(string title, string author, string publisher)
        {
            string tekst = $"{title}, autorstwa {author} wydany przez {publisher}";
            return tekst;
        }

    }
}
