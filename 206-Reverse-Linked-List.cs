public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode cur = head;
        ListNode prev = null;
        ListNode nxt = null;
        while (cur != null)
        {
            nxt = cur.next;
            cur.next = prev;
            prev = cur;
            cur = nxt;
        }

        return prev;
    }
}