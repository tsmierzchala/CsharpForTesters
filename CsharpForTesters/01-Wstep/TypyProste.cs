using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class TypyProste
    {
        public static void Main(string[] args)
        {
            int a = 5;
            char b = 'x';
            double c = 33.33;
            long d = 1523236;
            bool e = true;

            Console.WriteLine(a + 2147483647);

            double y = 0.1;
            double z = 0.2;
            bool warunek = y + z == 0.3;
            Console.WriteLine(warunek);
        }
        
    }
}
