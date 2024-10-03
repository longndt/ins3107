using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    internal class Person
    {
        private string name;
        private int age;
        private string address;

        public Person (string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        //use "virtual" keyword for child class to override
        public virtual void showInfo()
        {
            Console.WriteLine("Person Name: " + name);
            Console.WriteLine("Person Age:  " + age);
            Console.WriteLine("Person Address:  " + address);
        }
    }
}
