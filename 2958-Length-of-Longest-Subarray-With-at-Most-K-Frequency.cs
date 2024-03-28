public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        int ans = 0;
        int start = 0;
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        for (int end = 0; end < nums.Length; end++) {
            int num = nums[end];
            if (!frequency.ContainsKey(num))
                frequency[num] = 0;
            frequency[num]++;

            while (frequency.ContainsKey(num) && frequency[num] > k) {
                int leftNum = nums[start];
                frequency[leftNum]--;
                if (frequency[leftNum] == 0)
                    frequency.Remove(leftNum);
                start++;
            }

            ans = Math.Max(ans, end - start + 1);
        }

        return ans;
    }
}