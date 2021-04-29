using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        //Vehicle
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            Indicator indicator = new Indicator();
            // Cannot be set outside of class, private set
            //indicator.IsFlashing = true;
            Console.WriteLine(indicator.IsFlashing);
            indicator.TurnOn();
            Console.WriteLine(indicator.IsFlashing);

        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 100000, VehicleType.Plane);

            Console.WriteLine($" I rode on spaceship, it was the {rocket.Make}");

            rocket.Model = "Constellation";

            Console.WriteLine($"That ship is a {rocket.Model}");
        }

        // Greeter
        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>();
            students.Add("Hannan");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }


            string greeting = greeterInstance.GetRandomGreeting();
            greeterInstance.SaySomething(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.5, 100.9);
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1988, 04, 11));
            Console.WriteLine(age);
        }

        // Person
        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Michael", "Pabody", new DateTime(2000, 01, 31));
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Age);

            //Why empty constructors can be unhelpful, missing data
            Person jake = new Person();
            jake.FirstName = "Jacob";
            jake.DateOfBirth = new DateTime(1991, 05, 04);
            Console.WriteLine(jake.FullName);
            Console.WriteLine(jake.Age);

            person.LastName = "Torr";
            Console.WriteLine(person.FullName);

            // Single statement instance of new'ing up a person
            Person andrew = new Person()
            {
                FirstName = "Andrew",
                LastName = "Torr",
                DateOfBirth = new DateTime(1950, 12, 25)
            };

            //Asserting with a test that these two are equal
            Assert.AreEqual("Jacob", jake.FirstName);
            // Asserting that these are not equal
            //Assert.AreNotEqual("Jacob", jake.FirstName);
            // Commented, because it fails, as expected.
        }

        // Within the scope of the namespace, but outside of a method
        // Field type variable
        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 01, 31));

        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("X-Wing", "Starship",1000,VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make} {_person.Transport.Model}");

            _person.Transport.Make = "T16 Skyhopper";
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make}");

            Person blank = new Person();
            Console.WriteLine($"Fullname: {blank.FullName}");

            Console.WriteLine($"Unset class: {blank.Transport}");
            Console.WriteLine($"Unset struct: {blank.DateOfBirth}");
            Console.WriteLine($"Age: {blank.Age}");
        }

    }
}
