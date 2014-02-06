using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using MvvmPalindrome.ViewModel;
using System;
using TestMvvmPalindrome.TestDoubles;

namespace TestMvvmPalindrome.MainViewModelTests
{
    [TestClass]
    public class CheckIfInputIsAPalindromeCommand
    {
        [TestMethod]
        public void CanExecuteShouldReturnTrueWhenCommandParameterIsNull()
        {
            //--- Arrange ---
            var viewModel = new MainViewModel(new PalindromeEvaluationServiceDouble());

            //--- Act ---
            bool result = viewModel.CheckIfInputIsAPalindromeCommand.CanExecute(null);

            //--- Assert ---
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanExecuteShouldReturnTrueWhenCommandParameterIsNotNull()
        {
            //--- Arrange ---
            var viewModel = new MainViewModel(new PalindromeEvaluationServiceDouble());

            //--- Act ---
            bool result = viewModel.CheckIfInputIsAPalindromeCommand.CanExecute(new object());

            //--- Assert ---
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExecuteShouldSetCorrectOutputTextWhenCurrentInputIsAPalindrome()
        {
            //--- Arrange ---
            string expectedUserInput = Guid.NewGuid().ToString();

            var palindromeService = new PalindromeEvaluationServiceDouble();
            palindromeService.Expect(expectedUserInput, true);

            var viewModel = new MainViewModel(palindromeService)
            {
                Input = expectedUserInput
            };

            //--- Act ---
            viewModel.CheckIfInputIsAPalindromeCommand.Execute(null);

            //--- Assert ---
            Assert.AreEqual(string.Format("Yay! \"{0}\" is a palindrome!!!", expectedUserInput), viewModel.Output);
        }

        [TestMethod]
        public void ExecuteShouldSetCorrectOutputTextWhenCurrentInputIsNotAPalindrome()
        {
            //--- Arrange ---
            string expectedUserInput = Guid.NewGuid().ToString();

            var palindromeService = new PalindromeEvaluationServiceDouble();
            palindromeService.Expect(expectedUserInput, false);

            var viewModel = new MainViewModel(palindromeService)
            {
                Input = expectedUserInput
            };

            //--- Act ---
            viewModel.CheckIfInputIsAPalindromeCommand.Execute(null);

            //--- Assert ---
            Assert.AreEqual(string.Format("Boo! \"{0}\" is a not palindrome. :-(", expectedUserInput), viewModel.Output);
        }
    }
}
