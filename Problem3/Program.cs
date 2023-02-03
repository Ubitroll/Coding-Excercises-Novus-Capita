namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, space, star;

            for (row = 0; row < 5; row++)

            {

                for (space = 0; space < 5 - row; space++)

                {

                    Console.Write(" ");

                }

                for (star = 0; star < 1 + row + row; star++)

                {

                    Console.Write("*");

                }

                Console.WriteLine();

            }

            Console.ReadLine();

        }
    }    
}