using System;
using System.Collections;
using System.Collections.Generic;

namespace rex_matcher
{
    public class RegexMatcher
    {
        private Dictionary<Tuple<string, string>, bool> dictionary;

        public RegexMatcher()
        {
            dictionary = new Dictionary<Tuple<string, string>, bool>();
        }

        public bool IsMatch(string Text, string Pattern)
        {
            return IsMatchRecursively(Text, Pattern);
        }

        private bool IsMatchRecursively(string Text, string Pattern)
        {
            if (string.IsNullOrEmpty(Pattern))
                return string.IsNullOrEmpty(Text);

            var key = new Tuple<string, string>(Text, Pattern);
            if (AlreadyExistResult(key))
                return GetResult(key);

            bool result;

            if (HasStarPattern(Pattern))
            {
                result = IsMatchRecursively(Text, Pattern.Substring(2)) ||
                    (HasAnyOrSinglePattern(Text, Pattern) && IsMatchRecursively(Text.Substring(1), Pattern));
            }
            else
            {
                result = HasAnyOrSinglePattern(Text, Pattern) && IsMatchRecursively(Text.Substring(1), Pattern.Substring(1));

            }

            AddResult(key, result);
            return result;

        }

        private bool GetResult(Tuple<string, string> t)
        {
            return dictionary[t];
        }

        private bool AlreadyExistResult(Tuple<string, string> t)
        {
            return dictionary.ContainsKey(t);
        }

        private void AddResult(Tuple<string, string> t, bool result)
        {
            dictionary.Add(t, result);
        }

        private bool HasStarPattern(string Pattern)
        {
            return Pattern.Length > 1 && Pattern[1] == '*';
        }

        private bool HasAnyOrSinglePattern(string Text, string Pattern)
        {
            return !string.IsNullOrEmpty(Text) && (Pattern[0] == '.' || Pattern[0] == Text[0]);
        }
    }
}