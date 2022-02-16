using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{
    public class Slowniki
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> browserSettings = new Dictionary<string, string>();
            browserSettings.Add("browser", "chrome");
            browserSettings.Add("headless", "false");
            browserSettings.Add("res_width", "1920");
            browserSettings.Add("res_height", "1080");

            try
            {
                Console.WriteLine("For key = \"browser\", value = {0}.", browserSettings["browser"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"browser\" is not found.");
            }

            try
            {
                Console.WriteLine("For key = \"headless\", value = {0}.", browserSettings["headless"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"headless\" is not found.");
            }

            try
            {
                browserSettings.Remove("headless");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("For key = \"headless\", value = {0}.", browserSettings["headless"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"headless\" is not found.");
            }

        }
    }
}
