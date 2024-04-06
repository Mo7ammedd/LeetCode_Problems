/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode[] nodes = new ListNode[100];
        int index = 0;

        while (head != null) {
            nodes[index++] = head;
            head = head.next;
        }

        return nodes[index / 2];
    }
}