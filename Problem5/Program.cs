using System.Collections;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string to be swapped around: ");

            string input = Console.ReadLine();

            char[] inputArray= input.ToCharArray();

            string output = "";

            for (int i = inputArray.Length; i > 0; i--)
            {
                output = output + inputArray[i-1];
            }

            Console.WriteLine("The reversed string is: ");

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}