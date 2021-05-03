using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public abstract class Person
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

        public abstract void WhoAmI();
        //{
        //    Console.WriteLine("I am a person");
        //}
    }

    public class Customer : Person
    {
        public bool IsPremium { get; set; }

        public Customer() { }
        public Customer(bool isPremium)
        {
            IsPremium = isPremium;
        }

        public override void WhoAmI()
        {
            //base.WhoAmI();
            Console.WriteLine("I am a customer");
        }
    }

    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        } 

        public Employee(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }
        public Employee(int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base(firstName, lastName, phoneNumber, email)
        {
            EmployeeNumber = employeeNumber;
            HireDate = hireDate;
        }
        public override void WhoAmI()
        {
            Console.WriteLine("I am an Employee");
            //base.WhoAmI();
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
