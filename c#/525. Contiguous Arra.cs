public class Solution {
    public int FindMaxLength(int[] nums) {
        int max = 0;
        var map = new Dictionary<int, int>();
        map[0] = 0;
        int sum = 0;
        for(int i = 1; i <= nums.Length; i++) {
            sum+=nums[i-1];
            var key = 2*sum - i;
            if(map.ContainsKey(key)) {
                max = Math.Max(max, i - map[key]);
            }
            else {
                map[key] = i;
            }
        }

        return max;
    }
}