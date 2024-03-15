# Tree Data Structure Tutorial

## Introduction
A tree is a non-linear data structure that simulates a hierarchical tree structure with nodes connected by edges. It's especially useful in scenarios like representing hierarchies, facilitating fast search and modification operations.

## Example Problem: Binary Search Tree Operations
**Scenario:** Implement a binary search tree (BST) with insert and search functionalities.

**Solution:**
```csharp
public class TreeNode {
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
}

public class BinarySearchTree {
    private TreeNode root;

    public void Insert(int value) {
        root = InsertRecursively(root, value);
    }

    private TreeNode InsertRecursively(TreeNode current, int value) {
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

    private bool SearchRecursively(TreeNode current, int value) {
        if (current == null) {
            return false;
        }
        if (value == current.Value) {
            return true;
        }
        return value < current.Value ? SearchRecursively(current.Left, value) : SearchRecursively(current.Right, value);
    }
}