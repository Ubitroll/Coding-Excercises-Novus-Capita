using System.Security.Cryptography.X509Certificates;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> usableDigits = new List<int>() { 3, 1, 5, 7, 5, 9 };
            int target = 10;
            Tuple<int, int> indices = FindTwoSums(usableDigits, target);

            if(indices.Item1 != usableDigits.Count + 1 || indices.Item2 != usableDigits.Count + 1)
            {
                Console.WriteLine($"{indices.Item1} and {indices.Item2} (or {indices.Item2} and {indices.Item1}) as {usableDigits[indices.Item1]} + {usableDigits[indices.Item2]} = 10");
            }
            else
            {
                Console.WriteLine("Null: There is no pair of indices that equal 10");
            }
            

            Console.ReadLine();
        }

        public static Tuple<int, int> FindTwoSums(List<int> digits, int targetSum)
        {
            int indiceOne;
            int indiceTwo;

            for (int i = 0; i < digits.Count; i++)
            {
                for (int j = 1; j < digits.Count; j++)
                {
                    if (targetSum - digits[i] == digits[j])
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }

            return Tuple.Create(digits.Count + 1, digits.Count + 1);
        }
    }
}