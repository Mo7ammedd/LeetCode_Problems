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
    public bool IsPalindrome(ListNode head) {
        var list = new List<int>();
        while(head != null){
            list.Add(head.val);
            head = head.next;
        }
        if(list.Count == 1)
            return true;
        for(var i = 0; i < list.Count / 2; i++){
            if(list[i] == list[list.Count - 1 - i])
                continue;
            return false;
        }
        return true;
    }
}