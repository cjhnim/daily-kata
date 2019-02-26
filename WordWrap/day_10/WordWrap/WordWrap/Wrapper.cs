using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string DoWrap(string Text, int Limit)
        {
            return BreakDown(Text, Limit);
        }

        private static string BreakDown(string Text, int Limit)
        {
            if (Limit >= Text.Length)
                return Text;

            int space = Text.LastIndexOf(" ", Limit);

            if (WordLength(Text.Substring(space+1)) > Limit)
                space = Limit;

            return Text.Substring(0, space) + "--" + BreakDown(Text.Substring(space).Trim(), Limit);
        }

        private static int WordLength(string Text)
        {
            return Text.Contains(" ") ? Text.IndexOf(" ") + 1 : Text.Length;
        }
    }
}