using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class DivisionIterator:Iterator
    {
        private Corporate[] corporate;
        private int location = 0;
        public DivisionIterator(Corporate[] c)
        {
            corporate = c;
        }
        public VP Next()
        {
            return (VP)corporate[location++];
        }
        public bool hasNext()
        {
            if (location < corporate.Length && corporate[location] != null)
            {
                return true;
            }
            return false;
        }

    }
}
