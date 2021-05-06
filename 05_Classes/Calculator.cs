using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        //write a method that takes in two numbers and returns the sum of those two numnbers as an double


        public double GetSum(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            Console.WriteLine(sumSolution);
            return sumSolution;
        }

        public void DisplaySum()
        {
            double sum = GetSum(5, 6);
        }

        //subtraction
        //multiplication
        //division

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
