using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //child
    //use ":" (colon) symbol to make child class inherit from parent class
    internal class Laptop : ElectronicDevice
    {
        private double price;
        private string color;

        //use "base" keyword to inherit from parent's constructor
        public Laptop (string name, string origin, double price, string color) : base (name, origin)
        {
            this.price = price;
            this.color = color;
        }
    }
}
