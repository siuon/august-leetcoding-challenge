﻿using System.Reflection.Emit;
using System;

namespace _008_Path_Sum_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                You are given a binary tree in which each node contains an integer value.
                
                Find the number of paths that sum to a given value.
                
                The path does not need to start or end at the root or a leaf, 
                but it must go downwards (traveling only from parent nodes to child nodes).
                
                The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.

                Example:
                root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8
                      10
                     /  \
                    5   -3
                   / \    \
                  3   2   11
                 / \   \
                3  -2   1

                Return 3. The paths that sum to 8 are:

                1.  5 -> 3
                2.  5 -> 2 -> 1
                3. -3 -> 11
            */

            var root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(2);
            root.left.left.left = new TreeNode(3);
            root.left.left.right = new TreeNode(-2);
            root.left.right.right = new TreeNode(1);
            root.right = new TreeNode(-3);
            root.right.right = new TreeNode(11);

            var sum = 8;

            var solution = new Solution();

            Console.WriteLine(solution.PathSum(root, sum) == 3);
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
        public int PathSum(TreeNode root, int sum)
        {
            throw new NotImplementedException();
        }
    }
}
