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

            //var value2 = (0 < value < 100) ? "To nie jest akceptowalna wartość zmiennej value" : value;

            //zadanie 8
            double input = 5.5;
            string jakiePiwo = (input >= 4) ? "mocne" : "słabe";
            Console.WriteLine(jakiePiwo);

            //zadanie 9
            int dayOfTheWeek = 1;

            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Błędny dzień");
                    break;
            }

        }
    }
}
