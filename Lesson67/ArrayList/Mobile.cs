using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList123
{
    //OOP Class
    internal class Mobile
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Mobile (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void showMobileInfo()
        {
            Console.WriteLine("Mobile name:  " + Name);
            Console.WriteLine("Mobile price: $ " + Price);
        }
    }
}
