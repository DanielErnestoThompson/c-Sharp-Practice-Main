using System;

public class TreeNode {
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}

public class BinarySearchTree {
    private TreeNode? root;

    public void Insert(int value) {
        root = InsertRecursively(root, value);
    }

    private TreeNode InsertRecursively(TreeNode? current, int value) {
        if (current == null) {
            return new TreeNode { Value = value };
        }
        if (value < current.Value) {
            current.Left = InsertRecursively(current.Left, value);
        } else if (value > current.Value) {
            current.Right = InsertRecursively(current.Right, value);
        }
        return current;
    }

    public bool Search(int value) {
        return SearchRecursively(root, value);
    }

    private bool SearchRecursively(TreeNode? current, int value) {
        if (current == null) {
            return false;
        }
        if (value == current.Value) {
            return true;
        }
        return value < current.Value ? SearchRecursively(current.Left, value) : SearchRecursively(current.Right, value);
    }
}