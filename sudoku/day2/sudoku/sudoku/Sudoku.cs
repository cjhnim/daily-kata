using System;
using System.Collections.Generic;

namespace sudoku
{
    public class Sudoku
    {
        public int[] Puzzle
        {
            set;
            get;
        }

        private Dictionary<int, string> possibleValues;

        public Sudoku()
        {
            possibleValues = new Dictionary<int, string>();
        }

        public int Size()
        {
            return Puzzle.Length;
        }

        public string Solve()
        {
            MakePossibleValues();

            for (int i = 0; i < Puzzle.Length; i++)
            {
                if (Puzzle[i] != 0)
                    Assign(i, Puzzle[i].ToString());
            }

            return DisplayPuzzle();
        }

        private void MakePossibleValues()
        {
            for (int i = 0; i < Puzzle.Length; i++)
            {
                possibleValues.Add(i, "123456789");
            }
        }

        private void Assign(int index, string value)
        {
            possibleValues[index] = value;

            if (index == 0 && value.Equals("3"))
            {
                //possibleValues[0] = possibleValues[0].Replace("3", "");
                possibleValues[1] = possibleValues[1].Replace("3", "");
                possibleValues[2] = possibleValues[2].Replace("3", "");
                possibleValues[3] = possibleValues[3].Replace("3", "");
                possibleValues[4] = possibleValues[4].Replace("3", "");
                possibleValues[5] = possibleValues[5].Replace("3", "");
                possibleValues[6] = possibleValues[6].Replace("3", "");
                possibleValues[7] = possibleValues[7].Replace("3", "");
                possibleValues[8] = possibleValues[8].Replace("3", "");
                //possibleValues[9*0] = possibleValues[9*0].Replace("3", "");
                possibleValues[9 * 1] = possibleValues[9 * 1].Replace("3", "");
                possibleValues[9 * 2] = possibleValues[9 * 2].Replace("3", "");
                possibleValues[9 * 3] = possibleValues[9 * 3].Replace("3", "");
                possibleValues[9 * 4] = possibleValues[9 * 4].Replace("3", "");
                possibleValues[9 * 5] = possibleValues[9 * 5].Replace("3", "");
                possibleValues[9 * 6] = possibleValues[9 * 6].Replace("3", "");
                possibleValues[9 * 7] = possibleValues[9 * 7].Replace("3", "");
                possibleValues[9 * 8] = possibleValues[9 * 8].Replace("3", "");

                //possibleValues[9 * 0 + 0] = possibleValues[9 * 0 + 0].Replace("3", "");
                possibleValues[9 * 0 + 1] = possibleValues[9 * 0 + 1].Replace("3", "");
                possibleValues[9 * 0 + 2] = possibleValues[9 * 0 + 2].Replace("3", "");
                possibleValues[9 * 1 + 0] = possibleValues[9 * 1 + 0].Replace("3", "");
                possibleValues[9 * 1 + 1] = possibleValues[9 * 1 + 1].Replace("3", "");
                possibleValues[9 * 1 + 2] = possibleValues[9 * 1 + 2].Replace("3", "");
                possibleValues[9 * 2 + 0] = possibleValues[9 * 2 + 0].Replace("3", "");
                possibleValues[9 * 2 + 1] = possibleValues[9 * 2 + 1].Replace("3", "");
                possibleValues[9 * 2 + 2] = possibleValues[9 * 2 + 2].Replace("3", "");
            }
        }

        private string DisplayPuzzle()
        {
            string output = "";

            for (int i = 0; i < possibleValues.Count; i++)
            {
                output += string.Format("{0,-9}", possibleValues[i].ToString());

                if ((i + 1) % 9 == 0)
                    output += "\n";
                else
                    output += " ";
            }

            return output;
        }
    }
}