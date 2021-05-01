using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
                //return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    public class Customer : Person
    {
        public bool IsPremium { get; set; }

        public Customer() { }
        public Customer(bool isPremium)
        {
            IsPremium = isPremium;
        }
    }

    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany { get; set; } // challenge - remove the set and calculate years based on HireDate

        public Employee(int employeeNumber) 
        {
            EmployeeNumber = employeeNumber;
        }
        public Employee (int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email): base (firstName, lastName, phoneNumber, email )
        {
            EmployeeNumber = employeeNumber;
            HireDate = hireDate;
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int employeeNumber, decimal salary) : base(employeeNumber)
        {
            Salary = salary;
        }
        public SalaryEmployee(decimal salary, int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base(employeeNumber, hireDate, firstName, lastName, phoneNumber, email)
        {
            Salary = salary;
        }
    }
}
