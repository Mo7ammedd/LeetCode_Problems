  public bool HasCycle(ListNode head) {
        Dictionary<ListNode, int> dt = new Dictionary<ListNode, int>();
        while (head != null){
            if (dt.ContainsKey(head)){
                return true;
            }
            else 
            dt[head] = 1;  
            head = head.next;
        }
        return false;
    }
    zzzzzzzzzz