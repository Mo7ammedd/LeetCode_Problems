public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] productC = new int[n];

        int left = 1;
        for (int i = 0; i < n; i++) {
            productC[i] = left;

        }
        int right = 1;
        for (int i = n - 1; i >= 0; i--) {
            productC[i] *= right;

            right *= nums[i];
        }
        return productC;
    }
}