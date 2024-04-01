public class RotateListSolution
{
    public ListNode RotateRight(ListNode head, int k)
    {

        if (head is null)
            return null;

        if (head.next is null) return head;

        var numberOfNodes = GetCount(head);
        var actualTimesToRun = k % numberOfNodes;

        for (int i = 0; i < actualTimesToRun; i++)
        {
            var secondToLast = GetSecondToLast(head);
            var tempNode = secondToLast.next;
            secondToLast.next = null;
            tempNode.next = head;
            head = tempNode;
        }

        return head;
    }

    private int GetCount(ListNode head)
    {
        if (head is null)
        {
            return 0;
        }

        return 1 + GetCount(head.next);
    }

    private ListNode GetSecondToLast(ListNode head)
    {
        if (head.next.next is null)
        {
            return head;
        }

        return GetSecondToLast(head.next);
    }
}
