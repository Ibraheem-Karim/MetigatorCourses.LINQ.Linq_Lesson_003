using FunctionalProgramming;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var femalesWithFnameStartsWithS01 = 
                employees.Filter(x => x.Gender.ToLowerInvariant() == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));
            femalesWithFnameStartsWithS01.Print("Females With Fname Starts With S");


            var femalesWithFnameStartsWithS02 = 
                employees.Where(x => x.Gender.ToLowerInvariant() == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));
            femalesWithFnameStartsWithS02.Print("Females With Fname Starts With S");

        }
    }
}
