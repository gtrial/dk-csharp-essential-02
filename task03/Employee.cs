using System;
namespace task03
{
    public class Employee
    {
        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        private string FirstName { get; set; }
        private string LastName { get; set; }

        private static void CalculateSalaryAndTax(int employeePositionType, double workTerm, out double salary, out double tax)
        {
            salary = ((employeePositionType == 1) ? 100 : 200) * (1 + workTerm * 0.1);
            tax = 0.38 * salary;
        }

        public void PrintEmployeeInfo()
        {
            CalculateSalaryAndTax(1, 2, out var salary, out var tax);
            Console.WriteLine($"FirstName: {FirstName}\n" +
                $"LastName: {LastName}\n" +
                $"Salary: {salary}\n" +
                $"Tax: {tax}");
        }
    }
}
