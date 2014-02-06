using DomainModel;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TestDomainModel.PalindromeEvaluationServiceTests
{
    [TestClass]
    public class IsAPalindrome
    {
        [TestMethod]
        public void ShouldReturnTrueWhenLettersAreSameInForwardAndReverseOrder()
        {
            ShouldReturnTrueForPalindrome("MVVM");

        }

        [TestMethod]
        public void ShouldReturnTrueWhenLettersAreSameInForwardAndReverseOrderIgnoringCase()
        {
            ShouldReturnTrueForPalindrome("Bob");
        }

        [TestMethod]
        public void ShouldReturnTrueWhenLettersAreSameInForwardAndReverseOrderIgnoringPunctuationAndWhitespace()
        {
            ShouldReturnTrueForPalindrome(".Mom.Bob? Bob?|+_*&^%$##@!~`./,=Mom?");

        }

        private static void ShouldReturnTrueForPalindrome(string input)
        {
            //--- Arrange ---
            var service = new PalindromeEvaluationService();

            //--- Act ---
            bool result = service.IsAPalindrome(input);

            //--- Assert ---
            Assert.IsTrue(result, "Failed for input: " + input);
        }

        [TestMethod]
        public void ShouldReturnFlaseWhenLettersAreSameInForwardAndReverseOrder()
        {
            ShouldReturnFalseForNonPalindrome("mvvmq");
        }

        [TestMethod]
        public void ShouldReturnFlaseWhenLettersAreSameInForwardAndReverseOrderIgnoringCase()
        {
            ShouldReturnFalseForNonPalindrome("MvVmQ");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenLettersAreSameInForwardAndReverseOrderIgnoringPunctuationAndWhitespace()
        {
            ShouldReturnFalseForNonPalindrome("M v V.m?+_)(*&^%$#@!+=|\\/.,Q");
        }

        private static void ShouldReturnFalseForNonPalindrome(string input)
        {
            //--- Arrange ---
            var service = new PalindromeEvaluationService();

            //--- Act ---
            bool result = service.IsAPalindrome(input);

            //--- Assert ---
            Assert.IsFalse(result, "Failed for input: " + input);
        }
    }
}
