using System;

namespace rex_matcher
{
    public class RegexMatcher
    {
        public static bool IsMatch(string Text, string Pattern)
        {
            return IsMatchRecursively(Text, Pattern);
        }

        private static bool IsMatchRecursively(string Text, string Pattern)
        {
            if (string.IsNullOrEmpty(Pattern))
                return string.IsNullOrEmpty(Text);

            if (HasStarPattern(Pattern))
            {
                return IsMatchRecursively(Text, Pattern.Substring(2)) ||
                    (HasAnyOrSinglePattern(Text, Pattern) && IsMatchRecursively(Text.Substring(1), Pattern));
            }
            else
            {
                return HasAnyOrSinglePattern(Text, Pattern) && IsMatchRecursively(Text.Substring(1), Pattern.Substring(1));
            }
        }

        private static bool HasStarPattern(string Pattern)
        {
            return Pattern.Length > 1 && Pattern[1] == '*';
        }

        private static bool HasAnyOrSinglePattern(string Text, string Pattern)
        {
            return !string.IsNullOrEmpty(Text) && (Pattern[0] == '.' || Pattern[0] == Text[0]);
        }
    }
}