using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string DoWrap(string text, int limit)
        {
            if (string.IsNullOrEmpty(text) || limit == 0)
                return text;

            return BreakLine(text, limit);
        }

        private static string BreakLine(string text, int limit)
        {
            if (limit >= text.Length)
                return text;

            int space = SpaceIndex(text, limit);

            int wrapIndex = ChoiceWrapIndex(
                text,
                limit,
                space);

            return FrontString(text, wrapIndex) + "--" + BreakLine(RearString(text, wrapIndex).Trim(), limit);
        }

        private static string RearString(string text, int wrapIndex)
        {
            return text.Substring(wrapIndex);
        }

        private static string FrontString(string text, int wrapIndex)
        {
            return text.Substring(0, wrapIndex);
        }

        private static int SpaceIndex(string text, int limit)
        {
            return text.LastIndexOf(' ', limit);
        }

        private static int ChoiceWrapIndex(string text, int limit, int space)
        {
            if (limit >= WordLength(RearString(text, space + 1)))
                return space;
            return limit;
        }

        private static int WordLength(string text)
        {
            return text.Contains(" ") ? text.IndexOf(' ') + 1 : text.Length;
        }
    }
}