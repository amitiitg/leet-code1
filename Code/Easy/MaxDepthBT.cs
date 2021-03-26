using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Easy
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class MaxDepthBT
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return GetMax(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

        private int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
