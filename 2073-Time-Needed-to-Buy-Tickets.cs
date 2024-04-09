public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int n = tickets.Length;
        int time = 0;

        for (int i = 0; i < n; i++) {
            if (i <= k) {
                time += Math.Min(tickets[k], tickets[i]);
            } else {
                time += Math.Min(tickets[k] - 1, tickets[i]);
            }
        }

        return time;
    }
}