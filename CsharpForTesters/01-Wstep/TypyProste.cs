using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class TypyProste
    {
        public static void Main(string[] args)
        {

            int a = 1;
            char b = 'b';
            double c = 1.2;
            long d = 123423423;
            bool e = true;

            a += 2147483647;
            Console.WriteLine(a.ToString());

            double y = 0.1;
            double z = 0.2;
            bool warunek = y + z == 0.3;
            Console.WriteLine(warunek);
        }
        
    }
}
