using System;
using System.Collections.Generic;

public class BalancedParentheses {
    public static bool AreParenthesesBalanced(string expression) {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in expression) {
            if (ch == '(') {
                stack.Push(ch);
            } else if (ch == ')') {
                if (stack.Count == 0) {
                    return false;
                }
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}