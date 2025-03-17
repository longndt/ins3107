using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3
{
    class Hexagon : Shape
    {
        public Hexagon()
        {
        }
        public Hexagon(string name) : base(name)
        {
        }
        //You must either override this method or mark this class as abstract
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} Hexagon", PetName);
        }
    }
}
