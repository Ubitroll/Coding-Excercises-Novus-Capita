namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to find sum of its digits: ");

            string inputNumber = Console.ReadLine();
            int sum = 0;
            char[] numberCharArray = inputNumber.ToCharArray();

            for (int i = 0; i < numberCharArray.Length; i++)
            {
                sum = sum + Int16.Parse(numberCharArray[i].ToString());
            }

            Console.WriteLine("The sum of all the digits in {0} is {1}", inputNumber, sum);

            Console.ReadLine();
        }
    }
}