using System;
using System.Linq;

namespace Breaking_the_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
        }

        static int[] breakingRecords(int[] scores)
        {
            int highestScore = int.MinValue;
            int lowestScore = int.MinValue;

            int cntHighest = 0;
            int cntLowest = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                int currentScore = scores[i];

                if (highestScore <= 0 && lowestScore <= 0 && i == 0)
                {
                    highestScore = currentScore;
                    lowestScore = currentScore;
                }

                if (currentScore > highestScore)
                {
                    highestScore = currentScore;
                    cntHighest++;
                }

                if (currentScore < lowestScore)
                {
                    lowestScore = currentScore;
                    cntLowest++;
                }
            }

            var result = new int[2];

            result[0] = cntHighest;
            result[1] = cntLowest;

            return result;
        }
    }
}
