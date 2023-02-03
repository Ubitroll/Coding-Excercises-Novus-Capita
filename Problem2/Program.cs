using System.Diagnostics;
using System.IO;

namespace Problem2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary = {"parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };
            string target = "star";

            for (int i = 0; i < dictionary.Length; i++)
            {
                if (CheckAnagram(target, dictionary[i]))
                {
                    Console.WriteLine("{0} is an anagram of {1}", dictionary[i], target);
                }
            }

            Console.ReadLine();

        }

        public static bool CheckAnagram(string targetWord, string checkedWord)
        {
            char[] targetCharArray = targetWord.ToCharArray();
            char[] checkedCharArray = checkedWord.ToCharArray();

            Array.Sort(targetCharArray);
            Array.Sort(checkedCharArray);

            for (int i = 0; i < targetCharArray.Length; i++)
            {
                if (checkedCharArray[i] != targetCharArray[i])
                {
                    return false;
                }
            }

            if (targetCharArray.Length != checkedCharArray.Length)
            {
                return false;
            }
            
            return true;
        }               
    }
}