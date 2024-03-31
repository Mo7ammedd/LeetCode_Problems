public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        int minPosition = -1, maxPosition = -1, leftBound = -1;
        long answer = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == minK) minPosition = i;
            if(nums[i] == maxK) maxPosition = i;
            if(nums[i] < minK || nums[i] > maxK) leftBound = i;
            answer += Math.Max(0, Math.Min(maxPosition, minPosition) - leftBound);
        }

        return answer;
    }
}