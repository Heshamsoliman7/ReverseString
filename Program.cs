namespace ReverseString
{

    public class Program
    {
        public static void Main()
        {
            string input = "A man, a plan, a canal, Panama!";
            bool isPalindrome = IsValidPalindrome(input);
            Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
        }

        public static bool IsValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                // Skip non-alphanumeric characters from the left
                while (left < right && !Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                // Skip non-alphanumeric characters from the right
                while (left < right && !Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }

}

