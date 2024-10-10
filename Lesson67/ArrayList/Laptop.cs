using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList123
{
    //OOP Class
    internal class Laptop
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Laptop (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void showLaptopInfo ()
        {
            Console.WriteLine("Laptop name:  " + Name);
            Console.WriteLine("Laptop price: $ " + Price);
        }
    }
}
