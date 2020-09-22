using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class VP:Corporate
    {
        private string name;
        private string division;
        public VP(string n,string d)
        {
            name = n;
            division = d;
        }
        public override string getName()
        {
            return name;
        }
        public override Iterator iterator()
        {
            return new VPIterator(this);
        }
        public override void print()
        {
            Console.WriteLine("Name:" + name + ".Division:" + division);
        }
    }
}
