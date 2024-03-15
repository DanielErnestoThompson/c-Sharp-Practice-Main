using System;
using System.Collections.Generic;

public class ReverseString {
    public static string Reverse(string input) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in input) {
            stack.Push(c);
        }

        string reversed = "";
        while (stack.Count > 0) {
            reversed += stack.Pop();
        }
        return reversed;
    }
}