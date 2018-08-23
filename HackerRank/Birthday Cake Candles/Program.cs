using System;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = int.Parse(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = birthdayCakeCandles(ar);

            Console.WriteLine(result);
        }

        static int birthdayCakeCandles(int[] ar)
        {
            int result = 0;

            var maxHeight = int.MinValue;

            var cnt = 1;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == maxHeight)
                {
                    cnt++;

                    continue;
                }

                if (ar[i] > maxHeight)
                {
                    maxHeight = ar[i];

                    cnt = 1;
                }
            }

            result = cnt;

            return result;
        }
    }
}
