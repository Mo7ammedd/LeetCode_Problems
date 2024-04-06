public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        int maxFrequency = 0;
        int totalFrequencies = 0;

        foreach (int num in nums) {
            int frequency = frequencies.TryGetValue(num, out int currentFrequency) ? currentFrequency + 1 : 1;
            frequencies[num] = frequency;

            if (frequency > maxFrequency) {
                maxFrequency = frequency;
                totalFrequencies = frequency;
            }
            else if (frequency == maxFrequency) {
                totalFrequencies += frequency;
            }
        }

        return totalFrequencies;
    }
}