using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class VP
    {
        private string name;

        public string Name
        {
            get { return name; }
        }
        private string division;
        public VP(string n, string d)
        {
            name = n;
            division = d;
        }
        public void print()
        {
            Console.WriteLine("Name:" + name + ".Division:" + division);
        }
    }
}
