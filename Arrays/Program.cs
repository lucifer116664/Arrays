using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 8, 16, 11, 4, 3, 9, 7, 11, 5 };

            //minimal
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Minimal element = {min}");

            //maximal
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Maximal element = {max}");

            //sum
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"The sum of the elements = {sum}");


        }
    }
}
