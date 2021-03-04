using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Employee> Employees { get; set; }

        // Below is a constructor
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>(); //list constructor
        }

        public void ListEmployees(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }
    }

}