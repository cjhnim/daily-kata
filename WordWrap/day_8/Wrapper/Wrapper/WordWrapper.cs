using System;

namespace Wrapper
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string Do(string Text, int Limit)
        {
            if (string.IsNullOrEmpty(Text) || Limit == 0)
                return "";

            return BreakDown(Text, Limit);
        }

        private static string BreakDown(string Text, int Limit)
        {
            int wrapOffset, nextOffset;

            if (Text.Length <= Limit)
                return Text;

            if (Text[Limit] != ' ')
            {
                wrapOffset = Text.LastIndexOf(" ", Limit);
                if (wrapOffset == -1)
                    wrapOffset = 0;

                nextOffset = Text.IndexOf(" ", Limit);
                if (nextOffset == -1)
                    nextOffset = Text.Length;

                if (ExtractWord(Text, wrapOffset, nextOffset).Length > Limit)
                {
                    wrapOffset = Limit;
                }
            }
            else
                wrapOffset = Limit;

            return Text.Substring(0, wrapOffset).Trim() + "--" + BreakDown(Text.Substring(wrapOffset).Trim(), Limit);
        }

        private static string ExtractWord(string Text, int wrapOffset, int nextOffset)
        {
            return Text.Substring(wrapOffset, nextOffset - wrapOffset).Trim();
        }

        private static bool IfLastWord(int wrapOffset)
        {
            return wrapOffset == -1;
        }
    }
}