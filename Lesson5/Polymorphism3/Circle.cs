using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3
{
    class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(string name) : base(name)
        {
        }
        //You must either override this method or mark this class as abstract
        public override void Draw()
        {
            Console.WriteLine("Drawing the {0} Circle", PetName);
        }
    }
}
