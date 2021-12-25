using System;

namespace tema_recursivitate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Array is empty !!");
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("Negative value not allowed !!");
                return;
            }
            int[] array = new int[n];

            Console.WriteLine("Please fill in the array.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element of {i} = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            FindMinOfArray(array, 0, n, int.MaxValue);
        }

        public static void FindMinOfArray(int[] array, int start, int end, int min)
        {
            if (start >= end)
            {
                return;
            }
            if(array[start] < min)
            {
                min = array[start];
            }

            Console.WriteLine($"MIN = {min}");
            FindMinOfArray(array, start + 1, end, min);
        }
    }
}