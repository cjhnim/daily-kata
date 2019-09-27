using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaxBinaryTree
{
    public class MaxBinaryTreeCreator
    {
        public TreeNode ConstructMaximumBinaryTree(ref int[] nums)
        {
            return ConstructMaxBinTreeInRange(ref nums, 0, nums.Length);
        }

        private TreeNode ConstructMaxBinTreeInRange(ref int[] nums, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
                return null;

            int max_index = MaxIndexInRange(ref nums, startIndex, endIndex);

            var top = new TreeNode(nums[max_index]);

            top.left = ConstructMaxBinTreeInRange(ref nums, startIndex, max_index);
            top.right = ConstructMaxBinTreeInRange(ref nums, max_index + 1, endIndex);

            return top;
        }

        private static int MaxIndexInRange(ref int[] nums, int startIndex, int endIndex)
        {
            int max_index = startIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (nums[max_index] < nums[i])
                    max_index = i;
            }
            return max_index;
        }
    }
}
