using System;
using System.Linq;

namespace Divisible_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = int.Parse(nk[0]);

            int k = int.Parse(nk[1]);

            int[] ar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }

        private static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int cnt = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k  == 0)
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }
    }
   
}
