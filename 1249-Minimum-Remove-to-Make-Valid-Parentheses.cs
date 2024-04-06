public class Solution {
    public string MinRemoveToMakeValid(string s) {
        StringBuilder result = new StringBuilder();
        int openCount = 0;
                foreach (char c in s) {
            if (c == '(') {
                openCount++;
            } else if (c == ')') {
                if (openCount == 0) continue;
                openCount--;
            }
            result.Append(c);
        }
                StringBuilder finalResult = new StringBuilder();
        for (int i = result.Length - 1; i >= 0; i--) {
            if (result[i] == '(' && openCount > 0) {
                openCount--;
                continue;
            }
            finalResult.Insert(0, result[i]);
        }
        
        return finalResult.ToString();
    }
}