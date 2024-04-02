public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> dict =   new Dictionary<char,char>();
        HashSet<char> hSet = new HashSet<char>();

        for(int i = 0; i< s.Length;i++)
        {
            var sChar = s[i];
            var tChar = t[i];
            if (!dict.ContainsKey(sChar))
            {
                if(hSet.Contains(tChar))
                {
                    return false;
                }
                dict.Add(sChar, tChar);
                hSet.Add(tChar);
            }
            else    
            {
                if(tChar != dict[sChar])
                {
                    return false;
                }
            }
        }

        return true;
    }
}