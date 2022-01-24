using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._02_Debugowanie
{
    public class DebugujMnie
    {
        public static void Main(string[] args)
        {
            int x = 5 * 3 - 32 + 12 * 2;
            string text = "Ala ma " + x + " kotów";
            KlasaPomocnicza.Niespodzianka();

            var chars = new[]
            {
                'j',
                '\u006A',
                '\x006A',
                (char)106,
            };

            Console.WriteLine(string.Join(" ", chars));  // output: j j j j
        }
    }
}
