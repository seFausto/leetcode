public class SwapNodesInPairs
{
    public ListNode SwapPairs(ListNode head)
    {

        if (head is null)
            return null;
        if (head.next is null)
            return head;

        return SwapNodes(head, head.next);
    }

    private ListNode SwapNodes(ListNode node1, ListNode node2)
    {
        if (node1 is null) return node1;

        if (node2 is null) return node1;

        if (node2.next is null)
        {
            var tempNode = node1;
            tempNode.next = null;
            node1 = node2;
            node1.next = tempNode;
        }
        else
        {
            var childNode = SwapNodes(node2.next, node2.next?.next);
            var tempNode = node1;
            tempNode.next = childNode;
            node1 = node2;
            node1.next = tempNode;
        }

        return node1;
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