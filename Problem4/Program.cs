using System.Collections;

namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, space, star;

            ArrayList lineText = new ArrayList();

            int number, count = 1;
            count = 4;
            for (row = 1; row <= 5; row++)
            {
                

                for (space = 1; space <= count; space++)
                {
                    lineText.Add(" ");
                }
                    
                count--;

                for (star = 1; star <= 2 * row - 1; star++)
                {
                    lineText.Add("*");
                }

                Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);

                for (int i = 0; i < lineText.Count; i++)
                {
                    Console.Write(lineText[i]);
                }

                lineText.Clear();
                Console.WriteLine();
            }
            count = 1;
            for (row = 1; row <= 4; row++)
            {
                for (space = 1; space <= count; space++)
                {
                    lineText.Add(" ");
                }
                    
                count++;

                for (star = 1; star <= 2 * (5 - row) - 1; star++)
                {
                    lineText.Add("*");
                }

                Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);

                for (int i = 0; i < lineText.Count; i++)
                {
                    Console.Write(lineText[i]);
                }

                lineText.Clear();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}