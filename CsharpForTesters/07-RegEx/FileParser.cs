using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CsharpForTesters._07_RegEx
{
    public class FileParser
    {
        public static void Main(string[] args)
        {
            string cennik = File.ReadAllText("cennik.txt");
            
            // znajdź ceny
            Regex cena = new Regex(@"\d+(,\d{1,2})?(zł|\$|€)");
            MatchCollection ceny = cena.Matches(cennik);
            foreach (Match c in ceny)
            {
                Console.WriteLine(c.Value);
            }


            // znajdź kraje
            Regex panstwo = new Regex(@"w [A-Z]\w+");
            MatchCollection panstwa = panstwo.Matches(cennik);

            foreach (Match p in panstwa)
            {
                Console.WriteLine(p.Value);
            }

            // znajdź przedmioty
            Regex przedmiot = new Regex(@"^\p{L}+", RegexOptions.Multiline);
            MatchCollection przedmioty = przedmiot.Matches(cennik);

            foreach (Match prz in przedmioty)
            {
                Console.WriteLine(prz.Value);
            }
        }
    }
}
