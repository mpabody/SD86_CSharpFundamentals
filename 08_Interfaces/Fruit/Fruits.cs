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
}
