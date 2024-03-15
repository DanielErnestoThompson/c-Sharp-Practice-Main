# Stack Data Structure Tutorial

## Introduction
A stack is a fundamental data structure that follows the Last In, First Out (LIFO) principle. It's incredibly useful in various scenarios, such as reversing data, maintaining function calls, and backtracking algorithms.

## Example Problem: Reversing a String
**Scenario:** You want to reverse a string to check for palindromes or simply to reverse user input.

**Solution:**
```csharp
public string ReverseString(string input) {
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