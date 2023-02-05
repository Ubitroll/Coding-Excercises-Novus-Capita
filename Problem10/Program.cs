namespace Problem10
{
    internal class Program
    {        static void Main(string[] args)
        {
            Console.WriteLine("Which number would you like to find the next prime after: ");

            int searchedNumber = Int32.Parse(Console.ReadLine());

            int nextPrime = FindNextPrime(searchedNumber);

            Console.WriteLine($"The next Prime number after {searchedNumber} is {nextPrime}");

            Console.ReadLine();
        }

        static int FindNextPrime(int number)
        {
            if (number <= 1)
            {
                return 2;
            }

            int prime = number;
            bool primeFound = false;

            while (!primeFound)
            {
                prime++;

                if (CheckIfPrime(prime))
                {
                    primeFound = true;
                }
            }

            return prime;
        }

        static bool CheckIfPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number <= 3)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i = i + 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}