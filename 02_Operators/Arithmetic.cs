using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            double a = 22;
            double b = 15;

            //Addition
            double sum = a + b;
            Console.WriteLine(sum); //37

            //Subtraction
            double difference = a - b;
            Console.WriteLine(difference); // 7

            //Multiplication
            double product = a * b;
            Console.WriteLine(product); // 330

            //Division
            double quotient = a / b;
            Console.WriteLine(quotient); // 1

            //Remainder (modulus)
            double remainder = a % b;
            Console.WriteLine(remainder); // 7
        }
    }
}
