using System;

namespace WaterTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]  array = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int sum = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.WriteLine("Number = " + array[i]);
                Console.WriteLine("Right max = " + RightMax(array, i));
                Console.WriteLine("Left max = " + LeftMax(array, i));
                sum += (Math.Min(RightMax(array, i), LeftMax(array, i)) - array[i]);
            }
            Console.WriteLine("Water amount = " + sum);
            Console.ReadLine();

        }

        public static int RightMax(int [] array, int i) {
            int rightmax = array[array.Length-1];
            int k = i;
            while (k < array.Length) {
                if (array[k] > rightmax)
                    rightmax = array[k];
                    k++;
             }
            return rightmax;
        }
        public static int LeftMax(int[] array, int i)
        {
            int leftMax = array[0];
            int k = i;
            while (k > 0)
            {
                if (array[k] > leftMax)
                    leftMax = array[k];
                k--;
            }
            return leftMax;
        }
    }
}
