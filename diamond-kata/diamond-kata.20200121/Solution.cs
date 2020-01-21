using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond_kata._20200121
{
    public class Solution
    {
        private char mid;

        public Solution(char mid)
        {
            this.mid = mid;
        }

        public string print()
        {
            string top = "";
            string bottom = "";

            for(char current = 'A'; current <=mid; current++)
            {
                string line = BuildLine(current);

                top += line;

                if (current != mid)
                    bottom = line + bottom;
            }

            return top + bottom;
        }

        private string BuildLine(char current)
        {
            return 
                Indent(current) + 
                current + 
                RestOfLine(current) + 
                "\n";
        }

        private static string RestOfLine(char current)
        {
            string line = "";
            if (current != 'A')
            {
                int count = Index(current) * 2 - 1;
                line += AddSpaces(count) + current;
            }

            return line;
        }

        private string Indent(char current)
        {
            string line = "";

            if (current != mid)
            {
                int count = mid - current;
                line += AddSpaces(count);
            }

            return line;
        }

        private static int Index(char current)
        {
            return (current - 'A');
        }

        private static string AddSpaces(int count)
        {
            return new string(' ', count);
        }
    }
}
