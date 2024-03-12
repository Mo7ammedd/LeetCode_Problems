  public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode currentNode = head;
        List<ListNode> list = new List<ListNode>();

        while (currentNode != null)
        {
            list.Add(currentNode);
            currentNode = currentNode.next;
        }

        if (list.Count == 1)
        {
            return null;
        }
        else if (list.Count == n)
        {
            return head.next;
        }

        list[list.Count - n - 1].next = list[list.Count - n].next;

        return head;
    }
    zzzzzzzzzzzzzzzzzzzzzzzzzz