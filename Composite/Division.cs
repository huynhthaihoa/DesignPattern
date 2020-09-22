using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Division:Corporate
    {
        private Corporate[] corporate = new Corporate[100];
        private int number = 0;
        private string name;
        public Division(string n)
        {
            name = n;
        }
        public override string getName()
        {
            return name;
        }
        public override void Add(Corporate c)
        {
            corporate[number++] = c;
        }
        public override Iterator iterator()
        {
            return new DivisionIterator(corporate);
        }
        public override void print()
        {
            Iterator iter = iterator();
            while (iter.hasNext())
            {
                Corporate c = (Corporate)iter.Next();
                c.print();
            }
        }
    }
}
