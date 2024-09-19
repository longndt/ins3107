using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Mobile
    {
        private string name;
        private double price;
        private int year;

        public Mobile (string name, double price, int year)
        {
            this.name = name;
            this.price = price;
            this.year = year;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Mobile name: " + name);
            Console.WriteLine("Mobile price: $" + price);
            Console.WriteLine("Mobile year: " + year);
        }
    }
}
