﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBinaryTree
{
    [Serializable]
    public class TreeNode
    {

        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode()
        {
        }

        public TreeNode(int x) { val = x; }


    }
}
