using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Ashley = new Employee("Ashley", "Smith", "Manager");

            Employee John = new Employee("John", "Doe", "Assistant Manager");

            Employee Trey = new Employee("Trey", "Ross", "Retail Associate");



            Company Tradlands = new Company("Tradlands", DateTime.Now);
            Tradlands.Employees.Add(Ashley);
            Tradlands.Employees.Add(John);
            Tradlands.Employees.Add(Trey);

            Tradlands.ListEmployees(Ashley);
            Tradlands.ListEmployees(John);
            Tradlands.ListEmployees(Trey);


            //  Iterate the company's employee list and generate the
            //     simple report shown above
        }
    }
}



