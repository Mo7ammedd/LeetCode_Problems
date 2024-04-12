public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (num.Length == k) return \0\; 
        
        StringBuilder result = new StringBuilder();
        int digitsToRemove = k;
        
        foreach (char digit in num) {
            while (digitsToRemove > 0 && result.Length > 0 && result[result.Length - 1] > digit) {
                result.Remove(result.Length - 1, 1); 
                digitsToRemove--;
            }
            result.Append(digit);
        }
        
        while (digitsToRemove > 0) {
            result.Remove(result.Length - 1, 1);
            digitsToRemove--;
        }
        
        while (result.Length > 1 && result[0] == '0') {
            result.Remove(0, 1);
        }
        
        return result.ToString();
    }
}