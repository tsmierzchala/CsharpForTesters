using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class Metody
    {
        public static void Main(string[] args)
        {
            var price = CalculatePrice(100, 0.2);
            Console.WriteLine(price);

            var maxNum = MaxFrom(3, 234, 22);
            Console.WriteLine(maxNum);

            var isSumOk = ValidateSumWithDiscount(13, 13.2, 0.09, 156.16);
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

        public static double CalculatePrice(int price, double discount)
        {
            return price - (discount * price);
        }

        public static double MaxFrom(double a, double b, double c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public static string BookName(string title, string author, string publisher)
        {
            return $"{title}, autorstwa {author} wydany przez {publisher}";
        }

        public static bool ValidateSumWithDiscount(int pcs, double price, double discount, double expectedSum)
        {
            double actualSum = pcs * (price - (price * discount));
            return Math.Round(actualSum, 2) == expectedSum;
        }

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

