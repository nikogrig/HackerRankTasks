using System;
using System.Linq;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }

        private static int jumpingOnClouds(int[] c)
        {
            throw new NotImplementedException();
        }
    }
}
