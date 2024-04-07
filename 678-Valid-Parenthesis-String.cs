public class Solution {
    Dictionary<string, bool> dp = new ();
    bool check(string s, int i, int count) {
        if (count < 0) return false;
        if (i == s.Length) {
            return count == 0;
        }

        string key = i.ToString() + count.ToString();
        if (dp.ContainsKey(key)) {
            return dp[key];
        }

        bool result = false;
        if (s[i] == ')') {
            result = check(s, i + 1, count - 1);
        } else if (s[i] == '(') {
            result = check(s, i + 1, count + 1);
        } else {
            result = check(s, i + 1, count) || check(s, i + 1, count - 1) || check(s, i + 1, count + 1);
        }

        dp[key] = result;

        return dp[key];
    }
    public bool CheckValidString(string s) {
        return check(s, 0, 0);
    }
}