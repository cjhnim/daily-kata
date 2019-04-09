using System;
using System.Collections;
using System.Collections.Generic;

namespace sudoku
{
    public class Sudoku
    {
        private const int EMPTY = 0;

        public Sudoku()
        {
        }

        public int[,] solve(int[,] question)
        {
            var candidates = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i;

            // 수평 방향 경우의 수를 찾아라
            for (i = 0; i < 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (question[0, i] == j)
                        candidates.Remove(j);
                }
            }

            // 빈 부분에 경우의 수를 넣어라
            var hashTable = new Hashtable();

            for (i = 0; i < 9; i++)
            {
                if (question[0, i] == EMPTY)
                {
                    Tuple<int, int> point = new Tuple<int, int>(0, i);
                    hashTable.Add(point, candidates);
                }
            }

            // 경우의 수 중 해답을 찾아라
            for (i = 0; i < 9; i++)
            {
                if (question[0, i] == EMPTY)
                {
                    var key = new Tuple<int, int>(0, i);
                    var value = (List<int>) hashTable[key];
                    question[0, i] = value[0];
                }
            }

            return question;
        }

        public bool validate(int[,] answer)
        {
            throw new NotImplementedException();
        }
    }
}