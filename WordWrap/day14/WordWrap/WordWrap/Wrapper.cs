using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string Wrap(string Text, int Limit)
        {
            if (string.IsNullOrEmpty(Text) || Text.Length <= Limit)
                return Text;

            int space = Text.LastIndexOf(" ", Limit);
            int wrapLimit = space;

            if (!IsExistSpace(space) || GetWordLength(RearString(Text, wrapLimit)) > Limit)
                wrapLimit = Limit;

            return FrontString(Text, wrapLimit) + "--" + Wrap(RearString(Text, wrapLimit).Trim(), Limit);
        }

        private static string FrontString(string Text, int wrapLimit)
        {
            return Text.Substring(0, wrapLimit);
        }

        private static string RearString(string Text, int wrapLimit)
        {
            return Text.Substring(wrapLimit);
        }

        private static bool IsExistSpace(int space)
        {
            return space != -1;
        }

        private static int GetWordLength(string Text)
        {
            return Text.Trim().Contains(" ") ? Text.IndexOf(" ") : Text.Length;
        }
    }
}