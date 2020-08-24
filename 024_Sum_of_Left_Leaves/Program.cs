using System;

namespace _024_Sum_of_Left_Leaves
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Find the sum of all left leaves in a given binary tree.

                Example:
                    1
                   / \
                  2   3
                 / \ 
                4   5

                There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24.
            */

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            var solution = new Solution();

            Console.WriteLine(solution.SumOfLeftLeaves(root) == 4);
        }
    }

    /*
     * Definition for a binary tree node.
     */
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

    public class Solution
    {
        private int _sum;

        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return _sum;
            }

            GoPath(root, false);
            Console.WriteLine(_sum);
            return _sum;
        }

        private void GoPath(TreeNode node, bool lastIsLeft)
        {
            if (node.right != null)
            {
                GoPath(node.right, false);
            }

            if (node.left != null)
            {
                GoPath(node.left, true);
            }

            if (lastIsLeft &&
                node.left == null &&
                node.right == null)
            {
                _sum += node.val;
            }
        }
    }
}
