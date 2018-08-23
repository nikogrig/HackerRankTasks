using System;
using System.Linq;

namespace Birthday_Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] s = new int[n];

            s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] dm = Console.ReadLine().Split(' ');

            int d = int.Parse(dm[0]);

            int m = int.Parse(dm[1]);

            int result = solve(s, d, m);

            Console.WriteLine(result);
        }

        static int solve(int[] s, int d, int m)
        {
            var cnt = 0;

            if (s.Length >= m)
            {
                var partSumOfelements = 0;

                for (int i = 0; i < m; i++)
                {
                    partSumOfelements += s[i];
                }

                if (partSumOfelements == d)
                {
                    cnt++;
                }

                for (int i = 0; i < s.Length - m; i++)
                {
                    partSumOfelements = partSumOfelements - s[i] + s[i + m];

                    if (partSumOfelements == d)
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }
    }
}
