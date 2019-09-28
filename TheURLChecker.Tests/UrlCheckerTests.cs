using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheURLChecker.Tests
{
    [TestClass]
    public class UrlCheckerTests
    {
        [TestMethod]
        public void Test_ValidURL()
        {
            // ARRANGE
            UrlChecker checker = new UrlChecker();
            string url = "http://www.ucll.be";

            // ACT
            bool isValid = checker.CheckUrl(url);

            // ASSERT
            Assert.IsTrue(isValid, "Dit zou een geldige url moeten zijn.");
        }

        [TestMethod]
        public void Test_InvalidURL()
        {
            // ARRANGE
            UrlChecker checker = new UrlChecker();
            string url = "foo";

            // ACT
            bool isValid = checker.CheckUrl(url);

            // ASSERT
            Assert.IsFalse(isValid, "Dit zou een ongeldige url moeten zijn.");
        }
    }
}
