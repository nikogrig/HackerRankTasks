using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = int.Parse(x1V1X2V2[0]);

            int v1 = int.Parse(x1V1X2V2[1]);

            int x2 = int.Parse(x1V1X2V2[2]);

            int v2 = int.Parse(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }

        static string kangaroo(int start, int distA, int end, int distB)
        {
            string result = string.Empty;

            if (start < end && distA < distB)
            {
                result = "NO";
            }

            else if (start > end && distA > distB)
            {
                result = "NO";
            }

            else if (start > end)
            {
                var numberOfJumps = ((double)(start - end)) / (distB - distA);

                result = numberOfJumps % 1 == 0 ? "YES" : "NO";
            }

            else
            {
                var numberOfJumps = ((double)(end - start)) / (distA - distB);

                result = numberOfJumps % 1 == 0 ? "YES" : "NO";
            }

            return result;
        }
    }
}
