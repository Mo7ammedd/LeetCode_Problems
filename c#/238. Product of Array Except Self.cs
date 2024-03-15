public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] productCalculated = new int[n];

        int leftProduct = 1;
        for (int i = 0; i < n; i++) {
            productCalculated[i] = leftProduct;

        }
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--) {
            productCalculated[i] *= rightProduct;

            rightProduct *= nums[i];
        }
        return productCalculated;
    }
}