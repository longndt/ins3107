using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    internal class Cat : Animal
    {
        public void sayHello()
        {
            Console.WriteLine("This is a cat");
        }

        public void makeSound()
        {
            Console.WriteLine("Meo Meo");
        }
    }
}
