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
            if (string.IsNullOrEmpty(input) || limit == 0)
                return input;

            string output = BreakDown(input, limit);
            return output;
        }

        private static string BreakDown(string input, int limit)
        {
            string[] words = input.Split(' ');
            string output = null;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > limit)
                    //output += words[i].Substring(0, limit) + "--" + words[i].Substring(limit);
                    output += words[i].Substring(0, limit) + "--" + BreakDown(input.Substring(limit), limit);
                else
                    output += words[i];

                if (i < words.Length - 1)
                    output += "--";
            }

            return output;
        }
    }

  
}