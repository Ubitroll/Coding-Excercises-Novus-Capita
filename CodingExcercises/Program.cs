namespace CodingExcercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };

            int count = 1;
            int max = 1;

            for (int i = 1; i < sales.Length; i++)
            {
                if (sales[i] == sales[i-1])
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }

            if (count > max)
            {
                Console.WriteLine("The longest chain is {0} long", count);
            }
            else
            {
                Console.WriteLine("The longest chain is {0} long", max);
            }

            Console.ReadLine();
        }
    }
}