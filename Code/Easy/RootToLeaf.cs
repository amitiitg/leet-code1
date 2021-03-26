using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Easy
{
    class RootToLeaf
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return (targetSum == root.val);
            }

            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }

        private bool HasPathInternal(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return (targetSum == root.val);
            }

            return HasPathInternal(root.left, targetSum - root.val) || HasPathInternal(root.right, targetSum - root.val);
        }
    }
}
