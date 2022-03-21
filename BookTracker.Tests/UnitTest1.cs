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
    }
}
