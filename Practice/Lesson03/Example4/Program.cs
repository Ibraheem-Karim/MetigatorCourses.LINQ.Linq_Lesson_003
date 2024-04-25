using FunctionalProgramming;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var empMale = employees.Where(x => x.Gender == "male");
            
            var empsWithSalaryOver300k = employees.Where(x => x.Salary >= 300_000);

            empMale.Print("Male employees");

            empsWithSalaryOver300k.Print("Emps With Salary Over 300k");



            //We can also do a query on another query
            var empMaleInHRDepartment =
                empMale.Where(x => x.Department.ToLowerInvariant() == "hr");

            empMaleInHRDepartment.Print("Male employees in HR department");

            Console.ReadKey();
        }
    }
}
