using System;

namespace WorWrap
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string DoWrap(string Line, int WrapCount)
        {
            if (string.IsNullOrEmpty(Line) || WrapCount == 0)
                return Line;

            return Wraping(Line, WrapCount);
        }

        private static string Wraping(string Line, int WrapCount)
        {
            if (Line.Length <= WrapCount)
            {
                return Line;
            }
            else
            {
                return Line.Substring(0, WrapCount).Trim() + '\n' + Wraping(Line.Substring(WrapCount).Trim(), WrapCount);
            }
        }
    }
}