public partial class Solution
{
    /*
        Given the root of a binary tree, return its maximum depth.

        A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

        Example 1:

        Input: root = [3,9,20,null,null,15,7]
        Output: 3
        Example 2:

        Input: root = [1,null,2]
        Output: 2

        Constraints:

        The number of nodes in the tree is in the range [0, 104].
        -100 <= Node.val <= 100

    */

    /*

        - DFS Pre-Order traversal
        - increase level by one on each call
        - Keep Track of the max
        - return the 1 + max of (maxDepth(left), MaxDepth(right))  
      
    */
    public int MaxDepth(TreeNode root)
    {
        if(root == null) return 0;

        return  1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
    public int MaxDepth2(TreeNode root) {
        if(root == null)
            return 0;
        int maxDepth = 1;
        int maxDepthRight = 1;
        int maxDepthLeft = 1;
        if(root.right == null && root.left == null){
            return maxDepth;
        }
        if(root.right != null){
            maxDepthRight = MaxDepth(root.right);
        }
        if(root.left != null){
            maxDepthLeft = MaxDepth(root.left);
        }
        maxDepth = 1 + Math.Max(maxDepthRight,maxDepthLeft);
        return maxDepth;
    }
}