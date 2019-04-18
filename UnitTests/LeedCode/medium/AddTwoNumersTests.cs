using LeedCodeBusiness.Algos.medium;
using Xunit;

namespace UnitTests.LeedCode.medium
{
    public class AddTwoNumersTests
    {
        [Fact]
        public void CheckLinkedListV2()
        {
            int[] Input1 = { 2, 4, 3 };
            int[] Input2 = { 5, 6, 4 };
            int[] Input3 = { 7, 0, 8 };
            ListNode Note1;
            ListNode Note2;
            string Note3;

            for (int i = 0; i < Input1.Length; i++)
            {
                Note1 = new ListNode(Input1[i]);
                Note2 = new ListNode(Input2[i]);
                Note3 = new ListNode(Input3[i]).ToString();
                var ergeb = new LinkedListTwoNumbers().AddTwoNumbersV2(Note1, Note2).ToString();
                Assert.Equal(ergeb, Note3);
            }
        }
    }
}