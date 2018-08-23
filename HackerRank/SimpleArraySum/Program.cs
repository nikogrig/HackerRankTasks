using System;
using System.IO;
using System.Linq;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = int.Parse(Console.ReadLine());

            int[] ar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = simpleArraySum(ar);

            Console.WriteLine(result);
        }

        static int simpleArraySum(int[] ar)
        {
            var result = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }

            return result;
        }
    }
}
