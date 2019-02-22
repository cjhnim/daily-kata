using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string DoWrap(string Text, int Limit)
        {
            if (Limit <= 0)
                return Text;

            return BreakLine(Text, Limit);
        }

        private static string BreakLine(string Text, int Limit)
        {
            if (Text.Length <= Limit)
                return Text;

            int wrapOffset = Limit; 
            int space = Text.LastIndexOf(" ", Limit-1);
            if(space != -1 && space != (Limit-1))
            {
                if (Text.Substring(space).Trim().Length <= Limit)
                    wrapOffset = space;
            }
            return Text.Substring(0, wrapOffset).Trim() + "--" + BreakLine(Text.Substring(wrapOffset).Trim(), Limit);
        }
    }
}