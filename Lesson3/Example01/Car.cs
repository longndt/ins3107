using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    //OOP Class
    //class Car is used to represent for a car in real life
    internal class Car
    {
        //1. Attributes: Variables
        //Note: use "private" modifier for attributes to follow "information hiding" rule
        private string brand;
        private string model;
        private string color;
        private double price;

        //2. Operations: Methods
        //2.1 Constructor
        //Note: 1 class may have zero, 1 or many constructors
        public Car () { }  //empty constructor
        public Car (string brand, string model, string color, double newPrice)
        {
            //we use keyword "this" if variable name & parameter name are similar
            this.brand = brand;
            this.model = model;
            this.color = color;
            //otherwise if variable name & parameter name are different, no need to use "this"
            price = newPrice;
        }
        //2.2 Getter
        public double getPrice()
        {
            return price;
        }
        //2.3 Setter
        public void setNewPrice (double newPrice)
        {
            price = newPrice;
        }
        //2.4 Custom methods
        public void ShowCarInformation ()
        {
            Console.WriteLine("Car brand: " + brand);
            Console.WriteLine("Car model: " + model);
            Console.WriteLine("Car color: " + color);
            Console.WriteLine("Car price: $" + price);
        }
    }
}
