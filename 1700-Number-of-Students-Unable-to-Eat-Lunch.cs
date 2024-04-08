public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int[] eat = new int[2];
        foreach (int student in students)
            eat[student]++;

        foreach (int sandwich in sandwiches) {
            if (eat[sandwich] > 0)
                eat[sandwich]--; 
            else
                break; 
        }

        return eat[0] + eat[1];
    }
}