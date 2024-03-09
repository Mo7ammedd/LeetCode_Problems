using System;

public class Sol
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("mohammed", "ahmedmoh"));
        Console.WriteLine(IsAnagram("rat", "car"));
    }

    public static bool IsAnagram(string s, string t)
    {
        char[] s1 = s.ToCharArray();
        char[] s2 = t.ToCharArray();

        Array.Sort(s1);
        Array.Sort(s2);

        return new string(s1).Equals(new string(s2));
    }
}
