using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static String DoWrap(String text, int limit)
        {
            if (text.Length <= limit)
                return text;
            int breakPoint = text.LastIndexOf(" ", limit);
            if (breakPoint == -1 || firstWordLength(text.Substring(breakPoint + 1)) > limit)
                breakPoint = limit;
            return text.Substring(0, breakPoint) + "--" + DoWrap(text.Substring(breakPoint).Trim(), limit);
        }

        private static int firstWordLength(String text)
        {
            return text.Contains(" ") ? text.IndexOf(" ") : text.Length;
        }
    }
}