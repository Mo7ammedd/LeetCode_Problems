public class Solution {
    public int MaxDepth(string s) {
        int maxDepth = 0;
        int currentDepth = 0;
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s) {
            if (c == '(') {
                stack.Push(c);
                currentDepth = stack.Count;
                maxDepth = Math.Max(maxDepth, currentDepth);
            } else if (c == ')') {
                stack.Pop();
            }
        }
        
        return maxDepth;
    }
}