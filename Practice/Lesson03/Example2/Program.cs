using System.Collections;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = numbers.Where(x => x % 2 == 0);


            //Notice that you can't use LINQ on ArrayList because it doesn't have uniform type for its elements
            /*var collection = new ArrayList { true, 1, 2, 3.4 };
            var evenNumbers2 = collection.Where(x => x % 2 == 0);*/


            //You can also use IEnumerable as the type here; this is the type that will be returned anyway
            IEnumerable<int> evenNumbers2 = numbers.Where(x => x % 2 == 0);

            numbers.Add(12);
            numbers.Add(38);
            numbers.Add(20);

            numbers.Remove(6);

            foreach (var x in evenNumbers2)
            {
                Console.WriteLine(x);
            }


        }
    }
}
