using System;

public class ReverseLinkedList {
    // This assumes that the Node and ContactList classes are defined as in ContactList.cs

    public static Node? Reverse(Node? head) {
        Node? prev = null;
        Node? current = head;
        Node? next = null;
        while (current != null) {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}