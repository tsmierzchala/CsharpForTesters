using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._02_Debugowanie
{
    public class DebugowanieWarunkowe
    {
        public static void Main(string[] args)
        {
            var v = 0;

            for (int i = 1000; i >= 0; i--)
            {
                v = i < 9999 ? 10 / i : 10 * i;
            }

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //double result = GetAvgFromArray(nums);
            //Console.WriteLine(result); 
        }

        public static double GetAvgFromArray(int[] arr)
        {
            double result = 0;
            for (int i =0; i<=arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
    }
}
