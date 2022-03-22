using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookTracker;

namespace BookTracker.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsVaildSelection()
        {
            string selection = "1";
            bool isValid = Program.IsValidSelection(selection);

            Assert.AreEqual(isValid, true);
        }

        [TestMethod]
        public void TestIsVaildInput()
        {
            string input = "";
            bool isValid = Program.IsValidInput(input);

            Assert.AreEqual(isValid, false);
        }

        [TestMethod]
        public void TestGetBookInfo()
        {
            var actualResult = Program.GetBookInfo(new FakeUserInput());

            dynamic expectedResult = new
            {
                Title = "Game of Thrones",
                Author = "G. R. R. Martin",
                Genre = "Fantasy"
             };

            var actualResultString = Newtonsoft.Json.JsonConvert.SerializeObject(actualResult);
            var expectedResultString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResult);

            Assert.AreEqual(actualResultString, expectedResultString);
        }
    }
}
