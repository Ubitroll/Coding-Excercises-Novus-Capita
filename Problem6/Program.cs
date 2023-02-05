namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string to find if it is a palindrome: ");

            string input = Console.ReadLine();
            string reverseInput = "";

            char[] inputCharArray = input.ToLower().ToCharArray();

            for (int i = inputCharArray.Length; i > 0; i--)
            {
                reverseInput = reverseInput + inputCharArray[i - 1];
            }

            char[] reversedCharArray = reverseInput.ToCharArray();

            if (CheckPalindrome(inputCharArray, reversedCharArray))
            {
                Console.WriteLine("The input string {0} is a palindrome.", input);
            }
            else
            {
                Console.WriteLine("The input string {0} is not a palindrome", input);
            }

            Console.ReadLine();
        }

        public static bool CheckPalindrome(char[] inputArray, char[] reversedArray)
        {
            for (int j = 0; j < reversedArray.Length; j++)
            {
                if (inputArray[j] != reversedArray[j])
                {
                    return false;
                }

            }

            return true;
        }
    }
}