#include "stdafx.h"
#include "BInaryTreeConstructor.h"


BinaryTreeConstructor::BinaryTreeConstructor()
{
}


BinaryTreeConstructor::~BinaryTreeConstructor()
{
}

TreeNode* BinaryTreeConstructor::constructMaximumBinaryTree(vector<int>& nums) {
	
	return construct(nums, 0, nums.size());
}

TreeNode* BinaryTreeConstructor::construct(vector<int>& nums, int offset, int len)
{
	if (offset == len)
		return NULL;

	int max_index = getMaxIndex(nums, offset, len);

	TreeNode *node = new TreeNode(nums[max_index]);
	node->left = construct(nums, offset, max_index);
	node->right = construct(nums, max_index + 1, len);

	return node;
}

int BinaryTreeConstructor::getMaxIndex(vector<int>& nums, int offset, int len)
{
	int max = nums[offset];
	int max_index = offset;

	for(int i=offset; i<len; i++)
	{
		if (nums[i] > max)
		{
			max = nums[i];
			max_index = i;
		}
	}

	return max_index;
}