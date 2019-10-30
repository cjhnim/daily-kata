using System;
using System.Collections.Generic;

namespace merge_intervals
{
    public class IntervalMerger
    {
        private const string FRONT = "A";
        private const string BACK = "B";

        private class PairStack : Stack<Tuple<int, string>>
        {
            public bool IsEmpty(PairStack stack)
            {
                return stack.Count == 0;
            }
        }
        public int[][] Merge(int[][] input)
        {
            return MergeFromList(MakeSortedList(input)).ToArray();
        }

        private List<int[]> MergeFromList(List<Tuple<int, string>> list)
        {
            var result = new List<int[]>();
            var stack = new PairStack();

            for (int i = 0; i < list.Count; i++)
            {
                if (0 == list[i].Item2.CompareTo(FRONT))
                    stack.Push(list[i]);
                else
                {
                    Tuple<int, string> lastF = stack.Pop();

                    if (stack.IsEmpty(stack))
                        result.Add(MakeElement(Front: lastF, Back: list[i]));
                }
            }

            return result;
        }

        private List<Tuple<int, string>> MakeSortedList(int[][] input)
        {
            var list = new List<Tuple<int, string>>();

            for (int element = 0; element < input.Length; element++)
                for (int pos = 0; pos < input[element].Length; pos++)
                    list.Add(MakePair(input, element, pos));

            list.Sort();
            return list;
        }

        private int[] MakeElement(Tuple<int, string> Front, Tuple<int, string> Back)
        {
            return new int[] { Front.Item1, Back.Item1 };
        }

        private Tuple<int, string> MakePair(int[][] input, int element, int pos)
        {
            return new Tuple<int, string>(input[element][pos], GetPosition(pos));
        }

        private string GetPosition(int pos)
        {
            return pos == 0 ? FRONT : BACK;
        }

        private void ListPrint(List<Tuple<int, string>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine(list[i].Item1 + ": " + list[i].Item2);
            }
        }
    }
}
