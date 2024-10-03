using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //parent
    //sealed class ElectronicDevice
    //use "sealed" keyword to protec children classes
    //to inherit from parent class
    internal class ElectronicDevice
    {
        private string name;
        private string origin;
        
        public ElectronicDevice (string n, string o)
        {
            name = n;
            origin = o;
        }

        public void showDevice()
        {
            Console.WriteLine("Device name: " + name);
            Console.WriteLine("Device origin: " + origin);
        }
    }
}
