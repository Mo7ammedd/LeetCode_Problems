public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        
        int nonPosIdx = 0;
        for (int i = 0; i < n; i++) {
            if (nums[i] <= 0) {
                int temp = nums[i];
                nums[i] = nums[nonPosIdx];
                nums[nonPosIdx] = temp;
                nonPosIdx++;
            }
        }
        
        for (int i = nonPosIdx; i < n; i++) {
            int num = Math.Abs(nums[i]);
            if (num <= n - nonPosIdx && nums[num - 1 + nonPosIdx] > 0) {
                nums[num - 1 + nonPosIdx] *= -1;
            }
        }
        
        for (int i = nonPosIdx; i < n; i++) {
            if (nums[i] > 0) {
                return i - nonPosIdx + 1;
            }
        }
        
        return n - nonPosIdx + 1;
    }
}