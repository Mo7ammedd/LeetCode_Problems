public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>()); 
        
        foreach (int num in nums) {
            int size = result.Count;
            for (int i = 0; i < size; i++) {
                List<int> newSubset = new List<int>(result[i]);
                newSubset.Add(num);
                result.Add(newSubset);
            }
        }
        
        return result;
    }
}