using System;
using System.Linq;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            plusMinus(arr);
        }

        static void plusMinus(int[] arr)
        {
            var poscnt = 0;
            var negcnt = 0;
            var zerct = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    poscnt++;
                }
                else if (arr[i] < 0)
                {
                    negcnt++;
                }
                else
                {
                    zerct++;
                }
            }

            Console.WriteLine($"{(double)poscnt / arr.Length :f6}");
            Console.WriteLine($"{(double)negcnt / arr.Length:f6}");
            Console.WriteLine($"{(double)zerct / arr.Length:f6}");
        }
    }
}
