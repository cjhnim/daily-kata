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

        public IslandFinderDFS()
        {
        }

        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null)
                return 0;

            int maxLandSize = 0;
            int[][] seen = CreateTwoDimArray(grid);

            for (int col = 0; col < grid.Length; col++)
            {
                for (int row = 0; row < grid[col].Length; row++)
                {
                    int curLandSize = 0;

                    var stack = new Stack<int>();

                    PushToStack(stack, col, row);

                    while (stack.Count > 0)
                    {
                        int nearRow, nearCol;
                        PopFromStack(stack, out nearCol, out nearRow);

                        if (HaveYouSeen(seen, nearCol, nearRow) && IsLand(grid, nearCol, nearRow))
                        {
                            ++curLandSize;
                            Check(seen, nearCol, nearRow);
                            if (IsIsland(grid, stack, nearCol, nearRow + 1))
                                PushToStack(stack, nearCol, nearRow + 1);

                            if (IsIsland(grid, stack, nearCol, nearRow - 1))
                                PushToStack(stack, nearCol, nearRow - 1);

                            if (IsIsland(grid, stack, nearCol + 1, nearRow))
                                PushToStack(stack, nearCol + 1, nearRow);

                            if (IsIsland(grid, stack, nearCol - 1, nearRow))
                                PushToStack(stack, nearCol - 1, nearRow);
                        }
                    }

                    maxLandSize = Math.Max(curLandSize, maxLandSize);
                }
            }

            return maxLandSize;
        }

        private int[][] CreateTwoDimArray(int[][] grid)
        {
            var array = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
                array[i] = new int[grid[i].Length];
            return array;
        }

        private void PopFromStack(Stack<int> stack, out int nearCol, out int nearRow)
        {
            nearRow = stack.Pop();
            nearCol = stack.Pop();
        }

        private void PushToStack(Stack<int> stack, int col, int row)
        {
            stack.Push(col);
            stack.Push(row);
        }

        private void Check(int[][] memo, int col, int row)
        {
            memo[col][row] = VISITED;
        }

        private bool HaveYouSeen(int[][] memo, int col, int row)
        {
            return memo[col][row] == NOT_VISITED;
        }

        private bool IsLand(int[][] grid, int col, int row)
        {
            return grid[col][row] == LAND;
        }

        private bool IsIsland(int[][] grid, Stack<int> stack, int col, int row)
        {
            return OutOfBound(grid, col, row) && IsLand(grid, col, row);
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