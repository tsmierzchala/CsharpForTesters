using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CsharpForTesters._07_RegEx
{
    class Test
    {
        public static void Main()
        {
            string path = @"C:\Users\LaptopSzkoleniowy\Documents\kod\CsharpForTesters\text1.txt";

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);

                Regex re = new Regex(@"\d+(,\d{0,2})?(zł|\$|€)");
                MatchCollection result = re.Matches(s);
                foreach (Match r in result)
                {
                    Console.WriteLine($"* Kwoty: {r.Value}");
                }

                Regex re2 = new Regex(@"(?<=[w]\s)([^ -.]*)");
                MatchCollection result2 = re2.Matches(s);
                foreach (Match r in result2)
                {
                    Console.WriteLine($"* Kraje: {r.Value}");
                }

                Regex re3 = new Regex(@"^\p{L}+");
                MatchCollection result3 = re3.Matches(s);
                foreach (Match r in result3)
                {
                    Console.WriteLine($"* Przedmiot: {r.Value}");
                }

            }



        }
    }
}