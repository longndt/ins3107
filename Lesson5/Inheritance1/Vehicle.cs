using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    //Parent class
    internal class Vehicle
    {
        //Attributes (Variables)
        private string name;
        private double price;
        private string color;

        //Behaviours (Methods)
        public Vehicle (string name, double price, string color)
        {
            this.name = name;
            this.price = price;
            this.color = color;
        }

        public string getName ()
        {
            return name;
        }

        public void setPrice (double price)
        {
            this.price = price;
        }

        public void displayInfo ()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Color: " + color);
        }
    }
}
