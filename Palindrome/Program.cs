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
            Console.Write("Do you want to continue? (y/n): ");
            shouldContinue = Validation.GetValidBool("");
        } while (shouldContinue);

        bool shouldContinue1 = true;

        // Another implementation
        do
        {
            Console.WriteLine("Please a word to text if it is a palindrome: ");
            string str = $"{Console.ReadLine()}".ToLower().Trim();    // convert the message into a char array
            char[] charMessage = str.ToCharArray();
            // Reverse the chars
            Array.Reverse(charMessage);
            string new_message = new String(charMessage);
            // print it out
            Console.WriteLine(str.Equals(new_message) ? "It is a palindrome" : "Not a palindrome");
            Console.Write("Do you want to continue? (Y/N): ");
            shouldContinue1 = Validation.GetValidBool("");
        }while(shouldContinue1);
    }
}
