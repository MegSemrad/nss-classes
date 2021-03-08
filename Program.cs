using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Ashley = new Employee("Ashley ", "Smith", "Manager", DateTime.Now);
            Employee John = new Employee("John ", "Doe", "Assistant Manager", DateTime.Now);
            Employee Trey = new Employee("Trey ", "Ross", "Retail Associate", DateTime.Now);


            Company Tradlands = new Company("Tradlands", DateTime.Now);
            Tradlands.Employees.Add(Ashley);
            Tradlands.Employees.Add(John);
            Tradlands.Employees.Add(Trey);


            Tradlands.ListEmployees(Ashley);
            Tradlands.ListEmployees(John);
            Tradlands.ListEmployees(Trey);


            EmployeeReport(Tradlands);


            void EmployeeReport(Company company)
            {
                foreach (Employee employee in company.Employees)
                {
                    Console.WriteLine($"{employee.FirstName}{employee.LastName} works for {company.Name} as {employee.Title} since {employee.StartDate}.");
                }
            }
        }
    }
}