public class Solution
{
    public string CustomSortString(string order, string s) =>
        string.Concat(s.OrderBy(order.IndexOf));
}