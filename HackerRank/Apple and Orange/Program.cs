using System;
using System.Linq;

namespace Apple_and_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = int.Parse(st[0]);

            int t = int.Parse(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = int.Parse(ab[0]);

            int b = int.Parse(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = int.Parse(mn[0]);

            int n = int.Parse(mn[1]);

            int[] apples = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] oranges = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCnt = 0;

            int orangeCnt = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                int appleFalls = a + apples[i];

                if (appleFalls >= s && appleFalls <= t)
                {
                    appleCnt++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                int orangeFalls = b + oranges[i];

                if (orangeFalls >= s && orangeFalls <= t)
                {
                    orangeCnt++;
                }
            }

            Console.WriteLine(appleCnt + Environment.NewLine + orangeCnt);
        }
    }
}
