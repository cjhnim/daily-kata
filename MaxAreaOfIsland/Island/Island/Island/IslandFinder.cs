using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Island
{
    public class IslandFinder
    {
        private const int GROUND = 1;
        private const int WATER = 0;

        private int[][] guestBook;

        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;
            
            guestBook = NewGuestBook(grid);

            int max = 0;
            for (int col = 0; col < grid.Length; col++)
                for (int row = 0; row < grid[col].Length; row++)
                    max = Math.Max(max, islandCheck(grid, col, row));

            return max;
        }

        private int[][] NewGuestBook(int[][] grid)
        {
            var guestBook = new int[grid.Length][];

            for (int i = 0; i < grid.Length; i++)
                guestBook[i] = new int[grid[i].Length];

            return guestBook;
        }

        private int islandCheck(int[][] grid, int col, int row)
        {

            if (outOfRange(grid, col, row) ||
                isWater(grid, col, row) ||
                alreadyCheck(col, row))
            {
                return 0;
            }

            check(col, row);

            int size = 1;
            size += islandCheck(grid, col + 1, row);
            size += islandCheck(grid, col - 1, row);
            size += islandCheck(grid, col, row - 1);
            size += islandCheck(grid, col, row + 1);

            return size;
        }

        private static bool outOfRange(int[][] grid, int col, int row)
        {
            return col < 0 || row < 0 || col >= grid.Length || row >= grid[col].Length;
        }

        private void check(int col, int row)
        {
            guestBook[col][row] = 1;
        }

        private bool alreadyCheck(int col, int row)
        {
            return guestBook[col][row] == 1;
        }

        private bool isWater(int[][] grid, int i, int j)
        {
            return grid[i][j] == WATER;
        }
    }
}
