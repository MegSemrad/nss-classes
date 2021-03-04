using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        public void ListEmployees(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }
    }

}