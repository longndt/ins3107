using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3
{
    //declare a base class as abstract class
    abstract class Shape
    {
        //attribute (fields)
        private string name;

        //property
        public string PetName { get; set; }
        
        //constructor
        public Shape(string name = "NoName")
        { PetName = name; }

        //abstract method
        public abstract void Draw();

        //non-abstract method
        public void Test()
        {
            Console.WriteLine("Test method");
        }
    }
}
