
using numreverse;
namespace numrevTest
{
    [TestFixture]
    public class ReverseOrderTest
    {
        [Test]
        
        public void ReverseOrderInt_ShouldReturnReversedInteger()
        {
            // Arrange
            NumReversing numReversing = new NumReversing();
            string input = "8765";
            int expectedReversedInt = 5678;

            // Act
            int reversedInt = numReversing.Reverseint(input);

            // Assert
            Assert.AreEqual(expectedReversedInt, reversedInt);
        }



    }

}
