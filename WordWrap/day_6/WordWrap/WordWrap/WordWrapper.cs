using System;

namespace WordWrap
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string DoWrap(string input, int col)
        {
            if (string.IsNullOrEmpty(input) || col == 0)
                return "";

            if (input.Length > col)
                return input.Substring(0, col).Trim() + "--" + input.Substring(col, input.Length- col).Trim();
            else
                return input;
        }
    }
}