public class Solution {
    public int Trap(int[] height) {
        int n = height.Length, res = 0;
        
        int[] left = new int[n], right = new int[n];

        left[0] = 0;
        right[n - 1] = 0;

        for (int i = 1; i < n; i++)
        {
            left[i] = Math.Max(height[i - 1], left[i - 1]);
            right[n - i - 1] = Math.Max(height[n - i], right[n - i]);
        }

        for (int i = 0; i < n; i++)
        {
            var w = Math.Min(left[i], right[i]) - height[i];
            res += Math.Max(0, w);
        }

        return res;
    }
}