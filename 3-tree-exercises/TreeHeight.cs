using System;

public class TreeHeight {
    // This assumes that the TreeNode class is defined as in BinarySearchTree.cs

    public static int GetHeight(TreeNode? node) {
        if (node == null) {
            return -1;
        }
        return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
    }
}