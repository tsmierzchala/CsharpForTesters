using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{

// tu utwórz Enum
    public enum BrowserType
    {
        Chrome,
        Edge,
        Firefox,
        Opera
    }

    public class DriverFactory
    {
        string driver = null;

        public static void Main(string[] args)
        {
            Console.WriteLine(GetDriver(BrowserType.Edge));
        }

        public static string GetDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return "Chrome";
                case BrowserType.Edge:
                    return "Edge";
                case BrowserType.Opera:
                    return "Opera";
                case BrowserType.Firefox:
                    return "Firefox";

                default:
                    return "Błędna przeglądarka";
            }
        }
    }
}