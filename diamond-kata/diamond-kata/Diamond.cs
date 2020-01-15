using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond_kata
{
    public class Diamond
    {
        private char mid;

        public Diamond(char character)
        {
            this.mid = character;
        }

        public string Print()
        {
            string result = "";
            string top = "";
            string bottom = "";

            for (char c = 'A'; c <= mid; c++)
            {
                string line = BuildLine(result, c);

                top += line;

                if (mid == c)
                    continue;

                bottom = line + bottom;
            }

            return top + bottom;
        }

        private string BuildLine(string result, char c)
        {
            return AddIndent(result, c) + c + AddRest(result, c) + "\n";
        }

        private string AddIndent(string result, char c)
        {
            if (c != mid)
                result += AddSpace(mid - c);
            return result;
        }

        private string AddSpace(int count)
        {
            return new string(' ', count);
        }

        private string AddRest(string result, char current)
        {
            if (current != 'A')
                result += AddSpace(SpaceCount(current)) + current;

            return result;
        }

        private int SpaceCount(char current)
        {
            int index = current - 'A';
            int count = index * 2 - 1;
            return count;
        }
    }
}
