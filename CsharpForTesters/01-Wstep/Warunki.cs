using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class Warunki
    {
        public static void Main(string[] args)
        {
            int value = 42;

            if (0<=value || value>=100)
            {
                Console.WriteLine($"Pomiar wynosi {value}");
            } 
            else
            {
                Console.WriteLine($"To nie jest akceptowalna wartość zmiennej value");
            }


            double input = 5.5;
            string jakiePiwo = (input>=4) ? "mocne" : "słabe";
            Console.WriteLine(jakiePiwo);

            int dzienTygodnia = 1;
            switch (dzienTygodnia)
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
                    Console.WriteLine("Błędny dzień tygodnia");
                    break;
            }
        }
    }
}
