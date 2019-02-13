using System;

namespace WordWrap
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string DoWrap(string line, int col)
        {
            string[] token = line.Split(' ');

            if (token.Length == 1)
            {
                int previousWordLength = 0;
                if (token[0].Length <= col - previousWordLength)
                    return line;
                else
                    throw new NotImplementedException();
            }
            else if (token.Length == 2)
            {
                int previousWordLength = token[0].Length;
                if (token[1].Length <= col - previousWordLength)
                    return token[0] + '\n' + token[1];
                else
                    throw new NotImplementedException();
            }
            else
                throw new NotImplementedException();
        }
    }
}