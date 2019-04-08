namespace LeedCodeBusiness.Algos.medium
{
    // 2
    public class LinkedListTwoNumbers
    {
        public ListNode AddTwoNumbersV2(ListNode l1, ListNode l2)
        {
            return Add(l1, l2, 0);
        }

        private ListNode Add(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            var value = (l1?.Val ?? 0) + (l2?.Val ?? 0) + carry;

            return new ListNode(value % 10) { Next = Add(l1?.Next, l2?.Next, value / 10) };
        }
    }
}