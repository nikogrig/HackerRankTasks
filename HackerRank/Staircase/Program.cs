using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            staircase(n);
        }

        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
    }
}
