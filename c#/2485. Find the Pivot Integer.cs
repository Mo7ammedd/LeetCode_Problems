public class Solution {
    public int PivotInteger(int n) {
        double pivot = Math.Sqrt((n * (n + 1)) / 2);
        if(pivot - Math.Floor(pivot) == 0)
            return (int)pivot;
        return -1;
    }
}




