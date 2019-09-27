#include "stdafx.h"
#include "CppUnitTest.h"

#include <vector>
#include "..\MaxBinaryTreeCpp\TreeNode.h"
#include "..\MaxBinaryTreeCpp\BinaryTreeConstructor.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;
using namespace std;

namespace MaxBinaryTreeCppTests
{		
	TEST_CLASS(UnitTest1)
	{
		BinaryTreeConstructor *constructor;

	public:
		TEST_METHOD_INITIALIZE(SetUp)
		{
			constructor = new BinaryTreeConstructor();
		}

		TEST_METHOD_CLEANUP(CleanUp)
		{
			delete constructor;
		}

		TEST_METHOD(New_TreeNode)
		{
			TreeNode *node = new TreeNode(1);

			Assert::AreEqual(1, node->val);
			delete node;
		}

		TEST_METHOD(NullArray)
		{
			vector<int> nums = { };
			TreeNode *root = constructor->constructMaximumBinaryTree(nums);
			Assert::IsNull(root);
		}

		TEST_METHOD(OneArray)
		{
			vector<int> nums = { 1 };
			TreeNode *root = constructor->constructMaximumBinaryTree(nums);
			Assert::AreEqual(1, root->val);
		}

		TEST_METHOD(TwoArray_right)
		{
			vector<int> nums = { 2, 1 };
			TreeNode *root = constructor->constructMaximumBinaryTree(nums);
			Assert::AreEqual(2, root->val);
			Assert::IsNull(root->left);
			Assert::AreEqual(1, root->right->val);
		}

		TEST_METHOD(TwoArray_left)
		{
			vector<int> nums = { 1, 2 };
			TreeNode *root = constructor->constructMaximumBinaryTree(nums);
			Assert::AreEqual(2, root->val);
			Assert::AreEqual(1, root->left->val);
			Assert::IsNull(root->right);
		}

		TEST_METHOD(Final)
		{
			vector<int> nums = { 3, 2, 1, 6, 0, 5 };

			TreeNode *root = constructor->constructMaximumBinaryTree(nums);
			Assert::AreEqual(6,		root->val);
			Assert::AreEqual(3,		root->left->val);
			Assert::AreEqual(5,		root->right->val);
			Assert::IsNull(			root->left->left);
			Assert::AreEqual(2,		root->left->right->val);
			Assert::AreEqual(0,		root->right->left->val);
			Assert::IsNull(			root->right->right);
			Assert::IsNull(			root->left->right->left);
			Assert::AreEqual(1,		root->left->right->right->val);
		}
	};
}