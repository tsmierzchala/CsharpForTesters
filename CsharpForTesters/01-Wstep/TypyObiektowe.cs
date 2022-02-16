using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class TypyObiektowe
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tester był \"bardzo\" ucieszony z powodu notorycznego ignorowania raportów błędów przez developera");

            //zadanie 4
            string name = "Adam";
            int age = 5;

            if (age < 18)
            {
                Console.WriteLine($"{name}, ma {age} lat i jest niepełnoletni");
            } else { Console.WriteLine($"{name}, ma {age} lat i jest pełnoletni"); }

            //zadanie 6
            string napis = "Kamil Ślimak";

            char[] cArray = napis.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);

            //zadanie 7
            int value = 7;
            if (!(Enumerable.Range(1, 100).Contains(value)))
            {
                Console.WriteLine("To nie jest akceptowalna wartość zmiennej value");
            }
            else
            {
                Console.WriteLine($"Pomiar wynosi {value}");
            }

            //zadanie 8

        }
    }
}
