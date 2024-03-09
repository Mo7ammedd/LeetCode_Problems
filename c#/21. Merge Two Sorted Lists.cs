
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            if(list1 == list2) return list1;

            ListNode dummyHead = new ListNode(-1); 

            ListNode current = dummyHead;


            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
             
            if (list1 != null)
            {
                current.next = list1;
            }

            if (list2 != null)
            {
                current.next = list2;
            }

            return dummyHead.next; 
    }
}