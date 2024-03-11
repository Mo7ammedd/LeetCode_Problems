
public class Solution {
    public void ReorderList(ListNode head) {
        var st = new System.Collections.Generic.Stack<ListNode>();
        var qu = new System.Collections.Generic.Queue<ListNode>();

        ListNode slow = head, fast = head;
        while(fast!=null && fast.next!=null){
            qu.Enqueue(slow);
            slow = slow.next;
            fast = fast.next.next;
        }
        while(slow!=null){
            st.Push(slow);
            slow = slow.next;
        }

        ListNode current = head;
        while (st.Count > 0 || qu.Count > 0) {
            if (qu.Count > 0) {
                current.next = qu.Dequeue();
                current = current.next;
            }
            if (st.Count > 0) {
                current.next = st.Pop();
                current = current.next;
            }
        }
        current.next = null; 

    }
}