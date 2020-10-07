using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1to10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;



            for (int i = 0; i < array1to10.Length; i++)
            {
                sum += array1to10[i];
            }

            Console.WriteLine($"The sum of the array is {sum}");
        }
    }
}
