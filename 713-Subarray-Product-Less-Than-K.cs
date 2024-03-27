public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k <= 1)
            return 0;
        int res = 0;
        int prod = 1;
        for(int left =0, right =0; right <nums.Length; right++) {
            prod *= nums[right];

            while(prod >= k)
                prod /= nums[left++];
            
            res += right - left + 1;
        }

        return res;
    }
}