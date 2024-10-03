using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    //inherit from interface similar to
    //make inherit from class
    internal class Dog : Animal
    {
        public void sayHello()
        {
            Console.WriteLine("This is a dog");
        }

        public void makeSound()
        {
            Console.WriteLine("Gau Gau");
        }
    }
}
