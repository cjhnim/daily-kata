using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace balanced_binary_tree.tests
{

    [TestClass]
    public class SolutionTests
    {
        private Solution sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void nullItem_Should_BeBalanced()
        {
            Assert.IsTrue(sol.IsBalanced(null));
        }

        [TestMethod]
        public void oneItem_Should_BeBalanced()
        {
            var root = new TreeNode(1);

            Assert.IsTrue(sol.IsBalanced(root));
        }

        [TestMethod]
        public void twoItem1_Sould_BeBalanced()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(1);

            Assert.IsTrue(sol.IsBalanced(root));
        }

        [TestMethod]
        public void twoItem2_Sould_BeBalanced()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(1);

            Assert.IsTrue(sol.IsBalanced(root));
        }

        [TestMethod]
        public void fourItemOfLeft()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(1);
            root.left.left = new TreeNode(1);

            Assert.IsFalse(sol.IsBalanced(root));
        }

        [TestMethod]
        public void fourItemOfRight()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(1);
            root.right.right = new TreeNode(1);

            Assert.IsFalse(sol.IsBalanced(root));
        }

        [TestMethod]
        public void leetcode()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            Assert.IsTrue(sol.IsBalanced(root));
        }

        [TestMethod]
        public void leetcode2()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.right.right = new TreeNode(3);
            root.left.left.left = new TreeNode(4);
            root.right.right.right = new TreeNode(4);

            Assert.IsFalse(sol.IsBalanced(root));
        }

        [TestMethod]
        public void leetcode3()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(3);
            root.left.left.left = new TreeNode(4);
            root.left.left.right = new TreeNode(4);

            Assert.IsFalse(sol.IsBalanced(root));
        }

        [TestMethod]
        public void leetcode4()
        {
            var root = new TreeNode(1);

            root.left = new TreeNode(2);
            root.right = new TreeNode(2);

            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(3);

            root.left.left.left = new TreeNode(4);
            root.left.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(4);
            root.left.right.right = new TreeNode(4);
            root.right.left.left = new TreeNode(4);
            root.right.left.right = new TreeNode(4);

            root.left.left.left.left = new TreeNode(5);
            root.left.left.left.right = new TreeNode(5);

            Assert.IsTrue(sol.IsBalanced(root));
        }
    }
}
