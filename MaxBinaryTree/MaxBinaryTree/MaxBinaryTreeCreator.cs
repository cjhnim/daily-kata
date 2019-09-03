using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBinaryTree
{
    public class MaxBinaryTreeCreator
    {
        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if (nums.Length == 1)
            {
                return TreeNodeCreate(nums[0]);
            }

            int index = GetMaxNumberIndex(nums);

            var topNode = TreeNodeCreate(nums[index]);

            if(index + 1 != nums.Length)
                topNode.right = ConstructMaximumBinaryTree(nums.Skip(index + 1).ToArray());

            if(index != 0)
                topNode.left = ConstructMaximumBinaryTree(nums.Take(index).ToArray());

            return topNode;
        }

        private static int GetMaxNumberIndex(int[] nums)
        {
            int maxValue = nums.Max();
            return nums.ToList().IndexOf(maxValue);
        }

        public static TreeNode TreeNodeCreate(int nums)
        {
            return new TreeNode(nums);
        }
    }
}
