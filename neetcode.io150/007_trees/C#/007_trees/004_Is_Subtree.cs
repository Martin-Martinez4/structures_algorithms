public partial class Solution
{
    /*
        Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

        A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.

        Example 1:


        Input: root = [3,4,5,1,2], subRoot = [4,1,2]
        Output: true
        Example 2:


        Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
        Output: false
        
        Constraints:

        The number of nodes in the root tree is in the range [1, 2000].
        The number of nodes in the subRoot tree is in the range [1, 1000].
        -104 <= root.val <= 104
        -104 <= subRoot.val <= 104

    */

    /*

        - DFS Pre-Order traversal
        - increase level by one on each call
        - Keep Track of the max
        - return the 1 + max of (maxDepth(left), MaxDepth(right))  
      
    */
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {

    }
}