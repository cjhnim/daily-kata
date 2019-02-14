using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkProblem
{
    public class MathMachine
    {
        public string numOfCombination(int[] nums, int sum)
        {
            string output = "";

            if (nums.Length == 0)
                return AppendArray(null);

            else if (nums.Length == 1)
            {
                if (nums[0] == sum)
                    output = AppendArray(output, nums[0]);

                if (nums[0] + nums[0] == sum)
                {
                    if (!string.IsNullOrEmpty(output))
                        output += ", ";
                    output = AppendArray(output, nums[0], nums[0]);
                }
            }
            else if (nums.Length == 2)
            {
                if (nums[0] == sum)
                    output = AppendArray(output, nums[0]);

                if (nums[0] + nums[0] == sum)
                {
                    if (!string.IsNullOrEmpty(output))
                        output += ", ";
                    output = AppendArray(output, nums[0], nums[0]);
                }

                if (nums[1] == sum)
                    output = AppendArray(output, nums[1]);

                if (nums[0] + nums[1] == sum)
                {
                    if (!string.IsNullOrEmpty(output))
                        output += ", ";

                    output = AppendArray(output, nums[0], nums[1]);
                }

                if (nums[1] + nums[1] == sum)
                {
                    if (!string.IsNullOrEmpty(output))
                        output += ", ";
                    output = AppendArray(output, nums[1], nums[1]);
                }
            }
            else
            {
                throw new NotImplementedException();
            }

            if (string.IsNullOrEmpty(output))
                return arrayToString(null);
            else
                return output;
        }

        private string AppendArray(string output, params int[] nums)
        {
            return AddString(output, arrayToString(nums));
        }

        string AddString(string dest, string added)
        {
            if (!string.IsNullOrEmpty(dest))
                if(dest.Contains(added))
                    return dest;
            return dest + added;
        }
        string arrayToString(params int[] nums)
        {
            string output = "";

            output += "{";
            if (nums != null)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    output += nums[i];
                    if (i < nums.Length - 1)
                        output += ",";
                }
            }
            output += "}";

            return output;
        }
    }
}
