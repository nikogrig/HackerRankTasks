using System;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            var sumOfElements = 0L;

            var minNum = long.MaxValue;

            var maxNum = 0L;

            for (int i = 0; i < arr.Length; i++)
            {
                sumOfElements += arr[i];

                if (arr[i] < minNum)
                {
                    minNum = arr[i];
                }

                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                }
            }

            Console.WriteLine($"{sumOfElements - maxNum} {sumOfElements - minNum}");
        }
    }
}
