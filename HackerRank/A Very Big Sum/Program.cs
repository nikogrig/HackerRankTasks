using System;
using System.Linq;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = int.Parse(Console.ReadLine());

            long[] ar = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long result = aVeryBigSum(ar);

            Console.WriteLine(result);

        }

        static long aVeryBigSum(long[] ar)
        {
            long result = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }

            return result;

        }
    }
}
