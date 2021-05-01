using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            Person larry = new Person();
            larry.FirstName = "Larry";
            larry.LastName = "Bird";
            Console.WriteLine(larry.FullName);

            Customer sal = new Customer();
            sal.FirstName = "Sal";
            sal.LastName = "Vulcano";
            sal.IsPremium = true;
            Console.WriteLine(sal.FullName);
            Console.WriteLine(sal.IsPremium);

            Employee joe = new Employee(2, new DateTime(2021, 01, 01), "Joe", "Smith", "1234567890", "joeyG@gmail.com");
            Console.WriteLine(joe.Email);

            SalaryEmployee brian = new SalaryEmployee(3, 500000);
            brian.FirstName = "Brian";
            brian.LastName = "Quinn";

            //SalaryEmployee murr = new SalaryEmployee()
        }
    }
}
