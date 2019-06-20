using System;

namespace rex_matcher
{
    public class RegexMatcher
    {
        public static bool IsMatch(string Pattern, string Text)
        {
            return IsMatchRecursively(Pattern, Text);
        }

        private static bool IsMatchRecursively(string Pattern, string Text)
        {
            if (string.IsNullOrEmpty(Pattern))
                return string.IsNullOrEmpty(Text) ? true : false;

            if (IsStarPattern(Pattern))
            {
                return IsMatchRecursively(Pattern.Substring(2), Text) ||
                    (IsAnyOrSinglePattern(Pattern, Text) ? IsMatchRecursively(Pattern, Text.Substring(1)) : false);
            }
            else if (IsAnyOrSinglePattern(Pattern, Text))
            {
                return IsLastString(Pattern, Text) || IsMatchRecursively(Pattern.Substring(1), Text.Substring(1));
            }
            else
                return false;
        }

        private static bool IsLastString(string Pattern, string Text)
        {
            return Pattern.Length == 1 && Text.Length == 1;
        }

        private static bool IsStarPattern(string Pattern)
        {
            return Pattern.Length > 1 && Pattern[1] == '*';
        }

        private static bool IsAnyOrSinglePattern(string Pattern, string Text)
        {
            return !string.IsNullOrEmpty(Text) && (Pattern[0] == '.' || Pattern[0] == Text[0]);
        }
    }
}