using System;

namespace TrppingWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3,5,4,6,2 };
            int sum = 0;

            int[] leftMax = new int[array.Length];
            int[] rightMax = new int[array.Length];

            leftMax[0] = array[0];
            rightMax[array.Length - 1] = array[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                leftMax [i] = Math.Max(array[i], leftMax[i-1]);
            }
            for (int i = array.Length - 2; i > 0; i--)
            {
                rightMax[i] = Math.Max(array[i], rightMax[i + 1]);
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.WriteLine("Number = " + array[i]);
                sum += (Math.Min(leftMax[i], rightMax[i]) - array[i]);
            }

            Console.WriteLine("Water amount = " + sum);
            Console.ReadLine();
        }
    }
}
