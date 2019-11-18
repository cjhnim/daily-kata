using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_Of_Binary_Tree
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = 1 + MaxDepth(root.left);
            int right = 1 + MaxDepth(root.right);

            return left > right ? left : right;
        }
    }
}
