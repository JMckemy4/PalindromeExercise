using System;


namespace PalindromeExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            WordSmith wordSmith = new WordSmith();

            string word1 = "racecar";
            string word2 = "hello";

            bool isPalindrome1 = wordSmith.IsAPalindrome(word1);
            bool isPalindrome2 = wordSmith.IsAPalindrome(word2);

            Console.WriteLine($"Is '{word1}' a palindrome? {isPalindrome1}");
            Console.WriteLine($"Is '{word2}' a palindrome? {isPalindrome2}");

            Console.ReadLine();
        }
    }
}
