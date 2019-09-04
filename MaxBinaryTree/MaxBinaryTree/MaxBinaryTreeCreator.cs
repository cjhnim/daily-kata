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
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaxBinTreeInRange(nums, 0, nums.Length);
        }

        private TreeNode ConstructMaxBinTreeInRange(int[] nums, int offset, int length)
        {
            if (offset == length)
                return null;

            int max_index = MaxIndexInRange(nums, offset, length);

            var top = new TreeNode(nums[max_index]);

            top.left = ConstructMaxBinTreeInRange(nums, offset, max_index);
            top.right = ConstructMaxBinTreeInRange(nums, max_index + 1, length);

            return top;
        }


        private static int MaxIndexInRange(int[] nums, int start, int end)
        {
            int max_index = start;
            for (int i = start; i < end; i++)
            {
                if (nums[max_index] < nums[i])
                    max_index = i;
            }
            return max_index;
        }
    }
}
