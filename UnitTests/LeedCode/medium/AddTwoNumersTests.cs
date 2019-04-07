using LeedCodeBusiness.Algos.medium;
using Xunit;

namespace UnitTests.LeedCode.medium
{
    public class AddTwoNumersTests
    {
        [Fact]
        public void CheckParsingToLowerCasing()
        {
            //Arrange
            int[] Input1 = { 2, 4, 3 };
            int[] Input2 = { 5, 6, 7 };
            int[] Input3 = { 7, 0, 8 };

            var Atn = new LinkedListTwoNumbers();
            var ll1 = Atn.BuildLinkedList(Input1);
            var ll2 = Atn.BuildLinkedList(Input2);
            var exep = Atn.BuildLinkedList(Input3);

            //Act
            var output = Atn.AddTwoNumbers(ll1, ll2);

            //Assert
            Assert.Equal(exep, output);
        }
    }
}