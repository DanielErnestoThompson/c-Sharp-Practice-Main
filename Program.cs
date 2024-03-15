using System;

public class Program {
    public static void Main() {
        // Test for balanced parentheses
        TestBalancedParentheses("(()())");  // should return true
        TestBalancedParentheses("(()");     // should return false

        // Test for reversing a string
        TestReverseString("hello");  // should return "olleh"

        // Test for contact list
        TestContactList();

        // Test for reversing linked list
        // You would need to create a linked list similar to the one in TestContactList
        // and then call the Reverse method from ReverseLinkedList class

        // Test for binary search tree operations
        TestBinarySearchTree();

        // Test for tree height calculation
        // You would need to create a tree similar to the one in TestBinarySearchTree
        // and then call the GetHeight method from TreeHeight class
    }

    private static void TestBalancedParentheses(string expression) {
        Console.WriteLine($"Are parentheses in \"{expression}\" balanced? {BalancedParentheses.AreParenthesesBalanced(expression)}");
    }

    private static void TestReverseString(string input) {
        Console.WriteLine($"Reversed string of \"{input}\" is \"{ReverseString.Reverse(input)}\"");
    }

    private static void TestContactList() {
        ContactList contacts = new ContactList();
        contacts.AddContact("Alice");
        contacts.AddContact("Bob");
        Console.WriteLine("Contact List:");
        contacts.DisplayContacts();
    }

    private static void TestBinarySearchTree() {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        Console.WriteLine($"Is 30 in the tree? {bst.Search(30)}");  // should return true
        Console.WriteLine($"Is 100 in the tree? {bst.Search(100)}");  // should return false
    }
}