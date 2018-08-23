using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);
        }

        static int diagonalDifference(int[][] arr)
        {
            int result = 0;

            int leftDiag = 0;

            int secondDiag = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    leftDiag += arr[i][j];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - i - 1; j >= arr.Length - i - 1; j--)
                {
                    secondDiag += arr[i][j];
                }
            }

            result = Math.Abs(leftDiag - secondDiag);

            return result;
        }
    }
}
