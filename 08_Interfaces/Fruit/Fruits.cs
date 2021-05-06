using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        // Constructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        // Properties
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; }

        // Class method
        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the banana";
        }

    }

    public class Orange : IFruit
    {
        // Constructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        // Use the same interface method but bodies can be different as long as the return type matches
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }

        // Classes that use interfaces can still have unique properties and methods.
        public string Squeeze()
        {
            return "You squeeze the orange, and juice comes out";
        }
    }

    public class Grape : IFruit
    {
        //public Grape() { }
        public string Name
        {
            get
            {
                return "Grape";
            }
        }
        // Hardsetting property as false
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    // Make an Apple class inheriting from IFruit challenge
}
