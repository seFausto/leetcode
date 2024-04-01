// See https://aka.ms/new-console-template for more information
public class MergeKListsSolution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists is null || lists.Length == 0)
            return null;

        ListNode result = lists[0];
        for (int i = 1; i < lists.Length; i++)
        {
            result = MergeTwoLists(result, lists[i]);
        }

        return result;
    }

    private ListNode MergeTwoLists(ListNode a, ListNode b)
    {
        var result = new ListNode();
        var last = result;

        while (a != null && b != null)
        {
            if (a.val > b.val)
            {
                last.next = b;
                b = b.next;
            }
            else
            {
                last.next = a;
                a = a.next;
            }

            last = last.next;
        }

        last.next = a ?? b;

        return result.next;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
