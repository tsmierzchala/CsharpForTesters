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

            var isSumOk = validateSumWithDiscount(13, 13.2, 0.09, 156.16);
            Console.WriteLine(isSumOk);

            var firstQ = GetQuadrant(24, 42);
            Console.WriteLine(firstQ);

            var secondQ = GetQuadrant(24, -42);
            Console.WriteLine(secondQ);

            var thirdQ = GetQuadrant(-24, -42);
            Console.WriteLine(thirdQ);

            var fourthQ = GetQuadrant(-24, 42);
            Console.WriteLine(fourthQ);

            var fifthQ = GetQuadrant(0, 0);
            Console.WriteLine(fifthQ);

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

        //zadanie 13
        public static bool validateSumWithDiscount(int pcs, double price, double discount, double expectedSum)
        {
            return Math.Round(pcs * price - discount, 2) == expectedSum;
        }

        //zadanie 14
        public static int GetQuadrant(double x, double y)
        {
            int result = x switch
            {
                _ when x > 0 && y > 0 => 1,
                _ when x > 0 && y < 0 => 2,
                _ when x < 0 && y < 0 => 3,
                _ when x < 0 && y > 0 => 4,
                _ => 0
            };

            return result;
        }

    }
}
