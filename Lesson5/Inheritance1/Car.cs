using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    //child class
    //class "Car" inherits/derives from class "Vehicle"
    internal class Car : Vehicle
    {
        private string brand;
        private int year;

        public Car (string name, double price, string color, string brand, int year) : 
            base (name, price, color)
        {
            this.brand = brand;
            this.year = year;
        }

        public void displayDetail ()
        {
            Console.WriteLine("Car brand: " + brand);
            Console.WriteLine("Car manufactured year: " + year);
        }

    }
}
