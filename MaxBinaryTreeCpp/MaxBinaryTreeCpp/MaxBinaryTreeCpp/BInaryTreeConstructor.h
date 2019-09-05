#pragma once
#include <vector>
#include "TreeNode.h"
using namespace std;

class BinaryTreeConstructor
{
public:
	BinaryTreeConstructor();
	~BinaryTreeConstructor();
	TreeNode* constructMaximumBinaryTree(vector<int>& nums);
	TreeNode* construct(vector<int>& nums, int offset, int len);

	int getMaxIndex(vector<int>& nums, int offset, int len);

};

