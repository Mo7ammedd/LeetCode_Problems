public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        for( int i = s.Length - 1; i >= 0; i-- )
        {
            if(s[i] != ' ')
            {
                count ++;
                if(i == 0 || s[i-1] == ' ') return count;
            }
        }
        return count;
    }
}