using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class TypyObiektowe
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tester był \"bardzo\" ucieszony z powodu notorycznego ignorowania raportów błędów przez developera");

            string name = "Michał";
            int age = 37;

            if (age < 18)
            {
                // bez string interpolation
                Console.WriteLine(name + ", ma " + age + " lat i jest niepełnoletni");
            } else
            {
                // z string interpolation
                Console.WriteLine($"{name}, ma {age} lat i jest pełnoletni");
            }

            string odwrocMnie = "Kamil Ślimak";
            char[] charArray = odwrocMnie.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
            
        }
    }
}
