namespace Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of primes in the sequence you would like: ");

            int searchedPrime = Convert.ToInt32(Console.ReadLine());

            int currentNumber = 1;
            int count = 0;

            while (count != searchedPrime)
            {
                currentNumber++;
                if (CheckIfPrime(currentNumber))
                {
                    count++;
                }
            }

            Console.WriteLine($"The prime number in position {searchedPrime} in the sequence of prime numbers is {currentNumber}");

            Console.ReadLine();
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