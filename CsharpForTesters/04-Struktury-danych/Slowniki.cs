using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{
    public class Slowniki
    {
        public static void Main(string[] args)
        {
            var settings = new Dictionary<string, string>();
            settings.Add("browser", "chrome");
            settings.Add("headless", "false");
            settings.Add("res_width", "1920");
            settings.Add("res_heigth", "1280");

            if (settings.ContainsKey("browser"))
            {
                var browser = settings["browser"];
                Console.WriteLine($"Running: {browser}");
            } 
            else
            {
                Console.WriteLine("Key 'browser' does not exists");
            }


            string headlessMode;
            settings.TryGetValue("headless", out headlessMode);

            Console.WriteLine($"Headless mode jest: {headlessMode}");

            settings.Remove("headless");
            settings.TryGetValue("headless", out headlessMode);

            Console.WriteLine($"Headless mode jest: {headlessMode}");
            

            // co by się stało gdybyśmy pobierali dane za pomocą settings["headless"] ?
        }
    }
}
