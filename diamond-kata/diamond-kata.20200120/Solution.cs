using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond_kata._20200120
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

            for(char current = 'A'; current <= mid; current++)
            {
                string line = 
                    InsertIndent(current) + 
                    current +
                    InsertRestOfLine(current) + 
                    "\n";

                top += line;

                if(mid != 'A' && current != mid)
                    bottom = line + bottom;
            }

            return top + bottom;
        }

        private string InsertRestOfLine(char cur)
        {
            if (cur != 'A')
                return new string(' ', (cur - 'A') * 2 - 1) + cur;
            else
                return "";
        }

        private string InsertIndent(char cur)
        {
            return new string(' ', mid - cur);
        }
    }
}
