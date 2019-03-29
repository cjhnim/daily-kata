using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string Wrap(string Text, int Limit)
        {
            if (string.IsNullOrEmpty(Text) || Limit == 0)
                return "";

            if (Text.Length <= Limit)
                return Text;

            int space = Text.LastIndexOf(" ", Limit);
            int wrapLimit = space;

            if (GetWordLength(Text.Substring(space + 1)) > Limit)
                wrapLimit = Limit;

            return Text.Substring(0, wrapLimit) + "--" + Wrap(Text.Substring(wrapLimit).Trim(), Limit);
        }

        private static int GetWordLength(string Text)
        {
            return Text.Contains(" ") ? Text.IndexOf(" ") : Text.Length;
        }
    }
}