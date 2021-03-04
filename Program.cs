using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Mandy = new Employee()
            {
                FirstName = "Ashley",
                LastName = "Smith",
                Title = "Manager",
                StartDate = new DateTime(2020, 12, 2),
            };

            Employee John = new Employee()
            {
                FirstName = "John",
                LastName = "Doe",
                Title = "Assistant Manager",
                StartDate = new DateTime(2020, 2, 13),
            };

            Employee Trey = new Employee()
            {
                FirstName = "Trey",
                LastName = "Ross",
                Title = "Retail Associate",
                StartDate = new DateTime(2020, 3, 19),
            };

            Company Tradlands = new Company("Tradlands", DateTime.Now);
            Tradlands.Employees.Add(Mandy);
            Tradlands.Employees.Add(John);
            Tradlands.Employees.Add(Trey);



            //  Iterate the company's employee list and generate the
            //     simple report shown above
        }
    }
}



