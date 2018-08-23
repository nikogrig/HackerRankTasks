using System;

namespace Castle_on_the_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();

                grid[i] = gridItem;
            }

            string[] startXStartY = Console.ReadLine().Split(' ');

            int startX = int.Parse(startXStartY[0]);

            int startY = int.Parse(startXStartY[1]);

            int goalX = int.Parse(startXStartY[2]);

            int goalY = int.Parse(startXStartY[3]);

            int result = minimumMoves(grid, startX, startY, goalX, goalY);

            Console.WriteLine(result);
        }

        private static int minimumMoves(string[] grid, int startX, int startY, int goalX, int goalY)
        {
            throw new NotImplementedException();
        }
    }
}
