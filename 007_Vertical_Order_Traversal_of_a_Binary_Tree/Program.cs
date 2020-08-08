using System;

namespace _007_Vertical_Order_Traversal_of_a_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a binary tree, return the vertical order traversal of its nodes values.
                
                For each node at position (X, Y), its left and right children respectively will be at positions (X-1, Y-1) and (X+1, Y-1).

                Running a vertical line from X = -infinity to X = +infinity, whenever the vertical line touches some nodes, 
                we report the values of the nodes in order from top to bottom (decreasing Y coordinates).

                If two nodes have the same position, then the value of the node that is reported first is the value that is smaller.

                Return an list of non-empty reports in order of X coordinate.  Every report will have a list of values of nodes.

                Example 1:
                     3
                    / \
                   9   20
                       / \
                      15  7
                Input: [3,9,20,null,null,15,7]
                Output: [[9],[3,15],[20],[7]]

                Explanation: 
                    Without loss of generality, we can assume the root node is at position (0, 0):
                    Then, the node with value 9 occurs at position (-1, -1);
                    The nodes with values 3 and 15 occur at positions (0, 0) and (0, -2);
                    The node with value 20 occurs at position (1, -1);
                    The node with value 7 occurs at position (2, -2).

                Note:
                    The tree will have between 1 and 1000 nodes.
                    Each node's value will be between 0 and 1000.
            */
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
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            throw new NotImplementedException();
        }
    }
}
