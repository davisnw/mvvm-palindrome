using System;
using System.Linq;

namespace DomainModel
{
    public class PalindromeEvaluationService : IPalindromeEvaluationService
    {
        public bool IsAPalindrome(string text)
        {
            var forward = text.ToLower().Where(c => Char.IsLetter(c)).ToArray();
            var reverse = forward.Reverse().ToArray();

            return Enumerable.SequenceEqual(forward, reverse);
        }
    }
}
