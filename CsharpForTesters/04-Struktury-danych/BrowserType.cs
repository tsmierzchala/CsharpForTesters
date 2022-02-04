using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{
    public enum BrowserType
    {
        Chrome,
        Edge,
        Firefox,
        Opera
    }

    public class DriverFactory
    {
        static string driver = null;

        public static void Main(string[] args)
        {
            driver = GetDriver(BrowserType.Edge); 
            Console.WriteLine(driver);

            driver = GetDriver(BrowserType.Chrome);
            Console.WriteLine(driver);
        }

        public static string GetDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return "Chrome";
                    break;
                case BrowserType.Edge:
                    return "Edge";
                    break;
                case BrowserType.Firefox:
                    return "Firefox";
                    break;
                case BrowserType.Opera:
                    return "Opera";
                    break;
                default:
                    return "Błędna przeglądarka";
            }
        }
    }
}