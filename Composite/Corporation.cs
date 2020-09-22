using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Composite
{
    class Corporation:Corporate
    {
        private ArrayList corporate = new ArrayList();
        public Corporation()
        {
 
        }
        public override void Add(Corporate c)
        {
            corporate.Add(c);
        }
        public override void print()
        {
            Iterator iter = ((Corporate)corporate[0]).iterator();
            while (iter.hasNext())
            {
                Corporate c = (Corporate)iter.Next();
                c.print();
            }
        }
    }
}
