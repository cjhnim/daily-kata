using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond_kata
{
    public class Solution
    {
        private const char SPACE = ' ';
        private const char ENTER = '\n';
        private bool edge = false;

        public string DrawDiamond(char input)
        {
            string diamond = "";

            if (!char.IsLetter(input))
                return diamond;

            int letterIndex = getLetterIndex(input);

            int count = getLineCount(letterIndex);
            int spaceOfFirst = letterIndex;
            int spaceOfSecond = 0;
            int charIndex = 0;

            for (int i = 0; i < count; i++)
            {
                if (spaceOfFirst >= 1)
                {
                    diamond = insertSpace(diamond, spaceOfFirst);
                }

                diamond += getLetterOfIndex(charIndex);

                if (spaceOfSecond >= 1)
                {
                    diamond = insertSpace(diamond, spaceOfSecond);
                    diamond += getLetterOfIndex(charIndex);
                }

                diamond += ENTER;

                if (afterEdgeOfDiamond(spaceOfFirst))
                {
                    ++spaceOfFirst;
                    --charIndex;
                }
                else
                {
                    --spaceOfFirst;
                    ++charIndex;
                }

                spaceOfSecond = charIndex * 2 - 1;
            }

            return diamond;
        }

        private string insertSpace(string diamond, int spaceOfFirst)
        {
            for (int j = 0; j < spaceOfFirst; j++)
                diamond += SPACE;
            return diamond;
        }

        private bool afterEdgeOfDiamond(int spaceOfFirst)
        {
            if(spaceOfFirst == 0)
                edge = true;

            return edge;
        }

        private char getLetterOfIndex(int charIndex)
        {
            return (char)('A' + charIndex);
        }

        private int getLineCount(int index)
        {
            return 2 * index + 1;
        }

        private int getLetterIndex(char input)
        {
            return input - 'A';
        }
    }
}
