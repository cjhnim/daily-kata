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
            int wrapOffset;

            if (Text.Length <= Limit)
                return Text;

            if (Text[Limit - 1] != ' ')
            {
                wrapOffset = Text.LastIndexOf(" ", Limit-1);
                if (wrapOffset == -1)
                    wrapOffset = Limit;
                else if (Text.Substring(wrapOffset, Text.IndexOf(" ", Limit-1)).Length > Limit)
                    wrapOffset = Limit;
            }
            else
                wrapOffset = Limit;
            //return Text.Substring(0, wrapOffset).Trim() + "--" + Text.Substring(wrapOffset).Trim();
            return Text.Substring(0, wrapOffset).Trim() + "--" + BreakDown(Text.Substring(wrapOffset).Trim(), Limit);
        }
    }
}