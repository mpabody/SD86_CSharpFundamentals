using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 16;

            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine(isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? numOne : 20;

            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "True" : "False");
        }
    }
}
