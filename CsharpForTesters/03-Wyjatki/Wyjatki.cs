using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._03_Wyjatki
{
    internal class Wyjatki
    {
        public static void Main()
        {
            var a = 10;
            var b = 0;

            var c = a / b;
            
            Console.WriteLine(c);

            Console.WriteLine("A to się powinno wydrukować niezależnie od wszystkiego");
        }
    }
}
