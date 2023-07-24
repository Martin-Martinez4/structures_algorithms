public partial class Solution
{
    /*
        Given the root of a binary tree, invert the tree, and return its root.

        Example 1:

        Input: root = [4,2,7,1,3,6,9]
        Output: [4,7,2,9,6,3,1]
        Example 2:

        Input: root = [2,1,3]
        Output: [2,3,1]
        Example 3:

        Input: root = []
        Output: []
        

        Constraints:

        The number of nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100

    */
    /*  *
        * Definition for a binary tree node.
        * public class TreeNode {
        *     public int val;
        *     public TreeNode left;
        *     public TreeNode right;
        *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        *         this.val = val;
        *         this.left = left;
        *         this.right = right;
        *     }
        * }
    */
    /*
        - Save the left child in a temp node
        - Make the left Child the right child
        - Make the right child the temp child
        - Do it recusively with the 
            - left child
            - then the right child
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

    public TreeNode InvertTree(TreeNode root)
    {

        if (root == null) return null;

        TreeNode tempNode = root.left;
        root.left = root.right;
        root.right = tempNode;

        InvertTree(root.left);
        InvertTree(root.right);
        
        return root;

    }
}