using System;

public class Node {
    public string? ContactName { get; set; }
    public Node? Next { get; set; }
}

public class ContactList {
    private Node? head;

    public void AddContact(string name) {
        var newNode = new Node { ContactName = name };
        if (head == null) {
            head = newNode;
        } else {
            newNode.Next = head;
            head = newNode;
        }
    }

    public void DisplayContacts() {
        var current = head;
        while (current != null) {
            Console.WriteLine(current.ContactName);
            current = current.Next;
        }
    }
}