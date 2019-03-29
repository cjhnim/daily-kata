using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string wrap(string Text, int Limit)
        {
            if (Text.Length <= Limit)
                return Text;

            int space = Text.LastIndexOf(' ', Limit);
            int wrapIndex = space;

            int wordLength = GetWordLength(Text.Substring(space + 1));
            if (space == -1 || wordLength >= Limit)
                wrapIndex = Limit;

            return Text.Substring(0, wrapIndex) + "--" + wrap(Text.Substring(wrapIndex).Trim(), Limit);
        }

        private static int GetWordLength(string Text)
        {
            return Text.Contains(" ") ? Text.IndexOf(" ") : Text.Length;
        }
    }
}