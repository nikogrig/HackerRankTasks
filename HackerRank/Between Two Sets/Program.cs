using System;
using System.Collections.Generic;
using System.Linq;

namespace Between_Two_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = int.Parse(nm[0]);

            int m = int.Parse(nm[1]);

            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int total = getTotalX(a, b);

            Console.WriteLine(total);
        }

        static int getTotalX(int[] a, int[] b)
        {
            var totalNums = 0;

            var maxA = a.Max(); 
            var minB = b.Min(); 

            var counter = 1;

            var multipleOfMaxA = maxA;

            while (multipleOfMaxA <= minB)
            {
                var conditionOfAll = true;

                foreach (var item in a) 
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        conditionOfAll = false;

                        break;
                    }
                }

                if (conditionOfAll)
                {
                    foreach (var item in b) 
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            conditionOfAll = false;

                            break;
                        }
                    }
                }

                if (conditionOfAll)
                {
                    totalNums++;
                }

                counter++;

                multipleOfMaxA = maxA * counter;
            }
            return totalNums;
        }
    }
}
