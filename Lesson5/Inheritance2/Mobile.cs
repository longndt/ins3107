using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //child
    internal class Mobile : ElectronicDevice
    {
        private int quantity;
        private bool bestSeller;

        public Mobile (string name, string origin, int quantity, bool bestSeller) : base (name, origin)
        {
            this.quantity = quantity;
            this.bestSeller = bestSeller;
        }
    }
}
