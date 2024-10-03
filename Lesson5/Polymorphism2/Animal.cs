using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    internal interface Animal
    {
        //we can only declare methods in interface
        //variables are not allowed in interface

        //we can only declare method without content
        public void sayHello();
        public void makeSound();
    }
}
