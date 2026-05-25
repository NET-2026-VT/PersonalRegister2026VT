using PersonalRegister2026VT.Helpers;
using PersonalRegister2026VT.UI;

namespace PersonalRegister2026VTTests
{
    public class UtilTests
    {
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
