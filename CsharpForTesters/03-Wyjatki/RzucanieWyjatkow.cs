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

            try
            {
                var max1 = GetMax(arr1);
                Console.WriteLine(max1);
            } 
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Rzucono wyjątkiem: {ex.Message}");
            }
            
            Console.WriteLine(GetMax(arr2));
        }

        public static double GetMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta");
            }

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
