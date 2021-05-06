using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            Banana banana1 = new Banana();
            // Can't create an interface object
            //IFruit banan = new IFruit();

            // var is like a wildcard argument
            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banna is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            Orange orange = new Orange();

            // Var allows differrent fruits using the IFruit interface to exist together
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Orange(),
                orange
            };
            // Orange exclusive methods still accessible outside of IFruit collection
            orange.Squeeze();

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                // No longer accessible once in a collection
                //fruit.squeeze

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            // Even though the method only takes IFruit, grape still qualifies
            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                // Checking it's of type orange, casting it as orange
                // Pattern Matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange");
                        // Regain orange exlusive properties
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("It's an orange");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("It's a grape");
                    // without pattern matching, cast is necessary
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana");
                }
                else
                {
                    Console.WriteLine("It's a Banana");
                }
            }

        }
    }
}
