using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace invert_binary_tree.tests._20191224
{
    [TestClass]
    public class UnitTest1
    {
        Solution sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void 널노드가_주어지면_널을_리턴한다()
        {
            Assert.IsNull(sol.InvertTree(null));
        }

        [TestMethod]
        public void Leaf_노드_이면_인버트_할_필요없다()
        {
            var root = new TreeNode(1);
            TreeNode actual = sol.InvertTree(root);
            Assert.AreEqual(1, actual.val);
        }

        [TestMethod]
        public void 꽉_찬_노드_하나이면_인버트_한다()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            TreeNode actual = sol.InvertTree(root);
            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(3, actual.left.val);
            Assert.AreEqual(2, actual.right.val);
        }

        [TestMethod]
        public void 높이가_3이상인_노드를_왼쪽_트래버스하여_인버트_한다()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(5);
            //root.right.left = new TreeNode(5);
            //root.right.right = new TreeNode(6);

            TreeNode actual = sol.InvertTree(root);
            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(5, actual.left.val);
            //Assert.AreEqual(6, actual.left.left.val);
            //Assert.AreEqual(5, actual.left.right.val);
            Assert.AreEqual(2, actual.right.val);
            Assert.AreEqual(4, actual.right.left.val);
            Assert.AreEqual(3, actual.right.right.val);
        }

        [TestMethod]
        public void 높이가_3이상인_노드를_오른쪽_트래버스하여_인버트_한다()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(5);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);

            TreeNode actual = sol.InvertTree(root);
            Assert.AreEqual(1, actual.val);
            Assert.AreEqual(5, actual.left.val);
            Assert.AreEqual(6, actual.left.left.val);
            Assert.AreEqual(5, actual.left.right.val);
            Assert.AreEqual(2, actual.right.val);
            Assert.AreEqual(4, actual.right.left.val);
            Assert.AreEqual(3, actual.right.right.val);
        }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (null == root)
                return root;

            InvertTree(root.left);
            InvertTree(root.right);
            InvertNode(root);

            return root;
        }

        private static void InvertNode(TreeNode root)
        {
            TreeNode tmp = root.left;
            root.left = root.right;
            root.right = tmp;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
