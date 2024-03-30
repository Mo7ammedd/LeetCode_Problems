public class Solution
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        var lastOccur = new Dictionary<int, int>();
        int subArrs = 0;

        for (int l = -1, r = 0, u = 0; r < nums.Length; r++)
        {
            lastOccur[nums[r]] = r;

            while (lastOccur[nums[u]] != u) u++;

            if (lastOccur.Count > k)
            {
                l = u++;
                lastOccur.Remove(nums[l]);
                
                while (lastOccur[nums[u]] != u) u++;
            }

            if (lastOccur.Count == k) subArrs += u - l;
        }

        return subArrs;
    }
}