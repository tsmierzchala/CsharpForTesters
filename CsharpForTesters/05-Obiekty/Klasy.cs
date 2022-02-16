using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._05_Obiekty
{
    public class Klasy
    {
        public static void Main(string[] args)
        {
            IPriceable picasso = new Paint(50, 1);   
            Console.WriteLine(picasso.GetPrice());
        }
    }
}
