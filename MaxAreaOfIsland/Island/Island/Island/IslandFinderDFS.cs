using System;
using System.Collections.Generic;

namespace Island
{
    public class IslandFinderDFS
    {
        private const int LAND = 1;
        private const int WATER = 0;
        private const int VISITED = 1;
        private const int NOT_VISITED = 0;

        private class CordinateStack : Stack<int>
        {
            public void Push(int col, int row)
            {
                Push(col);
                Push(row);
            }

            public void Pop(out int col, out int row)
            {
                row = Pop();
                col = Pop();
            }
        }
        public IslandFinderDFS()
        {
        }

        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null)
                return 0;

            int max = 0;
            int[][] seen = CreateTwoDimArray(grid);

            for (int col = 0; col < grid.Length; col++)
            {
                for (int row = 0; row < grid[col].Length; row++)
                {
                    int size = 0;

                    var stack = new CordinateStack();

                    stack.Push(col, row);

                    while (stack.Count > 0)
                    {
                        int r, c;
                        stack.Pop(out c, out r);

                        if (!HaveYouSeen(seen, c, r) &&
                            IsThisLand(grid, c, r))
                        {
                            ++size;
                            Check(seen, c, r);
                            if (IsThisLand(grid, c, r + 1))
                                stack.Push(c, r + 1);

                            if (IsThisLand(grid, c, r - 1))
                                stack.Push(c, r - 1);

                            if (IsThisLand(grid, c + 1, r))
                                stack.Push(c + 1, r);

                            if (IsThisLand(grid, c - 1, r))
                                stack.Push(c - 1, r);
                        }
                    }
                    max = Math.Max(size, max);
                }
            }
            return max;
        }

        private int[][] CreateTwoDimArray(int[][] grid)
        {
            var array = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
                array[i] = new int[grid[i].Length];
            return array;
        }
     
        private void Check(int[][] memo, int col, int row)
        {
            memo[col][row] = VISITED;
        }

        private bool HaveYouSeen(int[][] seen, int col, int row)
        {
            return seen[col][row] == VISITED;
        }

        private bool IsThisLand(int[][] grid, int col, int row)
        {
            return OutOfBound(grid, col, row) && grid[col][row] == LAND;
        }

        private bool OutOfBound(int[][] grid, int col, int row)
        {
            return col < grid.Length &&
                            col >= 0 &&
                            row < grid[col].Length &&
                            row >= 0;
        }
    }
}