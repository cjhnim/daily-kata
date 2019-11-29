using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace increasing_order_search_tree.tests
{
    [TestClass]
    public class SolutionTests
    {
        Solution sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void testNullNode()
        {
            TreeNode resultNode = sol.IncreasingBST(null);

            Assert.IsNull(resultNode);
        }

        [TestMethod]
        public void testOneLeafNode()
        {
            var root = new TreeNode(1);

            TreeNode resultNode = sol.IncreasingBST(root);

            AssertIsLeafNode(1, resultNode);

        }

        [TestMethod]
        public void testTwoNode()
        {
            var root = new TreeNode(2);
            var two = new TreeNode(1);

            root.left = two;

            TreeNode resultNode = sol.IncreasingBST(root);

            AssertIsHalfNode(1, resultNode);
            AssertIsLeafNode(2, resultNode.right);
        }

        [TestMethod]
        public void testThreeNode()
        {
            var root = new TreeNode(2);
            var two = new TreeNode(1);
            var three = new TreeNode(3);

            root.left = two;
            root.right = three;

            TreeNode resultNode = sol.IncreasingBST(root);

            AssertIsHalfNode(1, resultNode);
            AssertIsHalfNode(2, resultNode.right);
            AssertIsLeafNode(3, resultNode.right.right);
        }

        [TestMethod]
        public void testFourNode()
        {
            var root = new TreeNode(3);
            var two = new TreeNode(2);
            var three = new TreeNode(4);
            var four = new TreeNode(1);

            root.left = two;
            root.right = three;
            root.left.left = four;


            TreeNode resultNode = sol.IncreasingBST(root);

            AssertIsHalfNode(1, resultNode);
            AssertIsHalfNode(2, resultNode.right);
            AssertIsHalfNode(3, resultNode.right.right);
            AssertIsLeafNode(4, resultNode.right.right.right);
        }

        private static void AssertIsHalfNode(int expectValue, TreeNode resultNode)
        {
            Assert.AreEqual(expectValue, resultNode.val);
            Assert.IsNull(resultNode.left);
            Assert.IsNotNull(resultNode.right);
        }

        private static void AssertIsLeafNode(int expectValue, TreeNode resultNode)
        {
            Assert.AreEqual(expectValue, resultNode.val);
            Assert.IsNull(resultNode.left);
            Assert.IsNull(resultNode.right);
        }
    }
}
