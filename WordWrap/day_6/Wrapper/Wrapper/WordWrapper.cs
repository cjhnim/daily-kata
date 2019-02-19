using System;

namespace Wrapper
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string Do(string input, int limit)
        {
           

            return BreakDown(input, limit);
        }

        private static string BreakDown(string input, int limit)
        {
            if (string.IsNullOrEmpty(input) || limit == 0)
                return input;

            int index = input.IndexOf(' ');
            if (index == -1)
                return input;
            //return input.Substring(0, index).Trim() + "--" + input.Substring(index, input.Length - index).Trim();
            return input.Substring(0, index).Trim() + "--" + BreakDown(input.Substring(index, input.Length - index), index);
        }
    }
}