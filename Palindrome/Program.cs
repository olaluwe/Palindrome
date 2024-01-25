using System.Text;
using MortgageCalculator;

namespace Palindrome;

public class Program
{
    public static void Main(string[] args)
    {
        bool shouldContinue = true;
        do
        {
            Console.WriteLine("Please provide a word to test for Palindrome: ");
            string input = $"{Console.ReadLine()}".ToLower();
            bool isPalindrome = false;
            StringBuilder halfStrings = new StringBuilder();
            
            for (var i = 0; i < input.Length/2; i++)
            {
                if (input[i] == input[input.Length - i - 1])
                {
                    isPalindrome = true;
                    halfStrings.Append(input[i].ToString());
                    // Console.WriteLine($"input[{i}]: {input[i]}\ninput[{input.Length - i - 1}]: {input[input.Length - i - 1]}");
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome ? "It is a Palindrome" : "It is not Palindrome");
            Console.WriteLine($"Equal halves of the Palindrome:{halfStrings}");
            Console.Write("Do you want to continue?: ");
            shouldContinue = Validation.GetValidBool("enter [y/n]: ");
        } while (shouldContinue);
    }
}
