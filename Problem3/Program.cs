namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, space, star;
            string lineText = "";

            for (row = 0; row < 5; row++)

            {

                for (space = 0; space < 5; space++)

                {

                    lineText = lineText + " ";

                }

                for (star = 0; star < 1 + row + row; star++)

                {

                    lineText = lineText + "*";

                }
                Console.SetCursorPosition((Console.WindowWidth - lineText.Length) / 2, Console.CursorTop);

                Console.WriteLine(lineText);

                lineText = "";

            }

            Console.ReadLine();

        }
    }    
}