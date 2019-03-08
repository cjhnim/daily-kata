using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string DoWrap(string Text, int Limit)
        {
            if (string.IsNullOrEmpty(Text))
                return "";

            return BreakLine(Text, Limit);
        }

        private static string BreakLine(string text, int limit)
        {
            if (DontNeedBreak(text, limit))
                return text;

            int wrapIndex = GetWrapIndex(text, limit);

            return FrontPart(text, wrapIndex) + "--" + BreakLine(RearPart(text, wrapIndex), limit);
        }

        private static int GetWrapIndex(string text, int limit)
        {
            int space = GetSpaceLastIndex(text, limit);

            if (WordLength(RearPart(text, space + 1)) > limit)
                return limit;

            return space;
        }

        private static bool DontNeedBreak(string text, int limit)
        {
            return text.Length <= limit;
        }

        private static string FrontPart(string text, int wrapIndex)
        {
            return text.Substring(0, wrapIndex);
        }

        private static string RearPart(string text, int wrapIndex)
        {
            return text.Substring(wrapIndex).Trim();
        }

        private static int WordLength(string text)
        {
            int index = GetSpaceIndex(text);
            return index == -1 ? text.Length : index + 1;
        }

        private static int GetSpaceLastIndex(string text, int limit)
        {
            return text.LastIndexOf(" ", limit);
        }

        private static int GetSpaceIndex(string text)
        {
            return text.IndexOf(" ");
        }
    }
}