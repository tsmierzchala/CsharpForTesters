using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._03_Wyjatki
{
    public class Wyjatki
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 0;

            try
            {
                var c = a / b;
                Console.WriteLine(c);
            } catch (Exception e)
            {
                Console.WriteLine($"Rzucono wyjątkiem: {e.Message}");
            }

            Console.WriteLine("A to się powinno wydrukować niezależnie od wszystkiego");
        }
    }
}
