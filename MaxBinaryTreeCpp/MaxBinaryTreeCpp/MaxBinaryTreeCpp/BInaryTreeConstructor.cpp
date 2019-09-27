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

TreeNode* BinaryTreeConstructor::construct(vector<int>& nums, int startIndex, int endIndex)
{
	if (startIndex == endIndex)
		return NULL;

	int max_index = getMaxIndex(nums, startIndex, endIndex);

	TreeNode *node = new TreeNode(nums[max_index]);
	node->left = construct(nums, startIndex, max_index);
	node->right = construct(nums, max_index + 1, endIndex);

	return node;
}

int BinaryTreeConstructor::getMaxIndex(vector<int>& nums, int startIndex, int endIndex)
{
	int max_index = startIndex;

	for(int i=startIndex; i<endIndex; i++)
	{
		if (nums[i] > nums[max_index])
		{
			max_index = i;
		}
	}

	return max_index;
}