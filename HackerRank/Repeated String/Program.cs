using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repeated_String
{
    class Program
    {

        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = int.Parse(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }

        private static long repeatedString(string s, long n)
        {
            long count = 0L;

            foreach (var letter in s)
            {
                if (letter == 'a')
                {
                    count++;
                }
            }

            long possibleStringRepeatitions = n / s.Length;

            count *= possibleStringRepeatitions;

            long offsetStringLength = n % s.Length;

            for (int i = 0; i < offsetStringLength; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
