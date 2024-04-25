using FunctionalProgramming;

namespace Example2UsingQuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;
            evenNumbers.Print("Even numbers");

        }
    }
}
