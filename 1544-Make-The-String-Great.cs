public class Solution {
    public string MakeGood(string s) {
        StringBuilder result = new StringBuilder();
        
        foreach (char c in s) {
            if (result.Length > 0 && Math.Abs(c - result[result.Length - 1]) == 32) {
                result.Length--; 
            } else {
                result.Append(c);
            }
        }
        
        return result.ToString();
    }
}