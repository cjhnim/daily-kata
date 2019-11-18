using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maximum_Depth_Of_Binary_Tree.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Solution solution;

        [TestInitialize]
        public void SetUp()
        {
            solution = new Solution();
        }

        [TestMethod]
        public void depth_0()
        {
            int depth = solution.MaxDepth(null);

            Assert.AreEqual(0, depth);
        }

        [TestMethod]
        public void depth_1()
        {
            var root = new TreeNode(1);
            int depth = solution.MaxDepth(root);

            Assert.AreEqual(1, depth);
        }

        [TestMethod]
        public void depth_2()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(1);

            int depth = solution.MaxDepth(root);

            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void depth_2_right()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(1);

            int depth = solution.MaxDepth(root);

            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void depth_3()
        {
            var root = new TreeNode(1);
            var level2 = new TreeNode(1);
            var level3 = new TreeNode(1);
            root.left = level2;
            level2.left = level3;

            int depth = solution.MaxDepth(root);

            Assert.AreEqual(3, depth);
        }

        [TestMethod]
        public void depth_4()
        {
            var root = new TreeNode(1);
            var level2 = new TreeNode(1);
            var level3 = new TreeNode(1);
            var level4 = new TreeNode(1);
            root.left = level2;
            level2.left = level3;
            level3.left = level4;

            int depth = solution.MaxDepth(root);

            Assert.AreEqual(4, depth);
        }

        [TestMethod]
        public void right_depth_2()
        {
            var root = new TreeNode(1);
            var level2 = new TreeNode(1);
            root.right = level2;

            int depth = solution.MaxDepth(root);

            Assert.AreEqual(2, depth);
        }


    }
}
