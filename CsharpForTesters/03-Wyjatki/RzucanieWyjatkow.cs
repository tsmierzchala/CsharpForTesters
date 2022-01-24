using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._03_Wyjatki
{
    public class RzucanieWyjatkow
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { };
            int[] arr2 = { 1, 11, 3, 4, 9 };

           
            Console.WriteLine(GetMax(arr1));
            Console.WriteLine(GetMax(arr2));
        }

        public static double GetMax(int[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
