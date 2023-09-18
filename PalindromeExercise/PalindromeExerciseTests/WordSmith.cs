using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExerciseTests
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
           
            input = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            string reversed = new string(input.Reverse().ToArray());

            return input == reversed;
        }
    }
}
