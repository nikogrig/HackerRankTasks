using System;
using System.Linq;

namespace Cavity_Map
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

            string[] result = cavityMap(grid);

            Console.WriteLine(string.Join("\n", result));
        }

        private static string[] cavityMap(string[] grid)
        {
            for (var i = 1; i < grid.Length - 1; i++)
            {
                for (var j = 1; j < grid.Length - 1; j++)
                {
                    if (grid[i][j] > grid[i - 1][j]
                        && grid[i][j] > grid[i + 1][j]
                        && grid[i][j] > grid[i][j - 1]
                        && grid[i][j] > grid[i][j + 1])
                    {
                        var removeCavity = grid[i].Remove(j, 1).Insert(j, "X");

                        grid[i] = removeCavity;
                    }
                }
            }

            return grid;
        }
    }
}
