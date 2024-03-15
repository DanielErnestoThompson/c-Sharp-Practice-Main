
# Linked List Data Structure Tutorial

## Introduction
A linked list is a collection of nodes where each node contains a value and a reference to the next node in the sequence. It offers dynamic size and efficient insertion/deletion operations.

## Example Problem: Contact Management
**Scenario:** You're creating a simple contact management system where you can add and remove contacts.

**Solution:**
```csharp
public class Node {
    public string ContactName { get; set; }
    public Node Next { get; set; }
}

public class ContactList {
    private Node head;

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