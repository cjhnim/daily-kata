using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sudoku
{
    public class Sudoku
    {
        private const int EMPTY = 0;

        public int[,] Puzzle
        {
            set;
            get;
        }

        public Sudoku()
        {
        }

        public int[,] Solve()
        {
            while (true)
            {
                bool solved = true;

                foreach (int y in Enumerable.Range(0, 9))
                {
                    foreach (int x in Enumerable.Range(0, 9))
                    {
                        if (Puzzle[x, y] == EMPTY)
                        {
                            List<int> result = SolveGivenPosition(x, y);

                            if (result.Count == 1)
                                Puzzle[x, y] = result[0];
                            else
                                solved = false;
                        }
                    }
                }

                if (solved)
                {
                    // 다풀었음
                    break;
                }
            }

            //// 빈 부분에 경우의 수를 넣어라
            //var hashTable = new Hashtable();

            //for (i = 0; i < 9; i++)
            //{
            //    if (question[0, i] == EMPTY)
            //    {
            //        Tuple<int, int> point = new Tuple<int, int>(0, i);
            //        hashTable.Add(point, candidates);
            //    }
            //}

            //// 경우의 수 중 해답을 찾아라
            //for (i = 0; i < 9; i++)
            //{
            //    if (question[0, i] == EMPTY)
            //    {
            //        var key = new Tuple<int, int>(0, i);
            //        var value = (List<int>)hashTable[key];
            //        question[0, i] = value[0];
            //    }
            //}

            return Puzzle;
        }

        private List<int> SolveGivenPosition(int xPos, int yPos)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 수직 조각 답찾기
            var vSlice = Enumerable.Range(0, 9)
                .Select(x => Puzzle[xPos, x])
                .ToList<int>();

            var candidatesX = numbers.Except(vSlice).ToList();

            // 수직 조각 답찾기
            var hSlice = Enumerable.Range(0, 9)
                .Select(x => Puzzle[x, yPos])
                .ToList<int>();

            var candidatesY = numbers.Except(hSlice).ToList();

            var result = candidatesX.Intersect(candidatesY).ToList();

            // 센터 조각 답찾기
            var cSlice = new List<int>();
            uint startX = ((uint) xPos / 3)*3;
            uint startY = ((uint) yPos / 3)*3;
            foreach (int x in Enumerable.Range((int)startX, 3))
                foreach (int y in Enumerable.Range((int)startY, 3))
                    cSlice.Add(Puzzle[x, y]);

            var candidatesCenter = numbers.Except(cSlice).ToList();

            result = result.Intersect(candidatesCenter).ToList();
            return result;
        }

        public bool validate(int[,] answer)
        {
            throw new NotImplementedException();
        }
    }
}