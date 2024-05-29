using Employees.Helpers;
using Employees.UI;

namespace Helpers.Tests
{
    public class UtilTests
    {

        public UtilTests()
        {
            
        }

        [Fact]
        public void AskForString_ShouldReturnExpectedString()
        {
            //Arrange
            const string expected = "some value";
            var mockUI = new MockUI();
            mockUI.SetInput = expected;

            //Act
            var actual = Util.AskForString("", mockUI);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}