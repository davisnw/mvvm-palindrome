using DomainModel;
using System.Collections.Generic;

namespace TestMvvmPalindrome.TestDoubles
{
    /// <summary>
    /// Normally, I would pull in a mocking library such as https://github.com/Moq/.
    /// </summary>
    public class PalindromeEvaluationServiceDouble : IPalindromeEvaluationService
    {
        private Dictionary<string, bool> _expectations = new Dictionary<string,bool>();

        public void Expect(string text, bool result)
        {
            _expectations.Add(text, result);
        }

        public bool IsAPalindrome(string text)
        {
            return _expectations[text];
        }
    }
}
