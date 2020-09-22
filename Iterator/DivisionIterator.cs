using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class DivisionIterator:Iterator
    {
        private VP[] VPs;
        private int location = 0;
        public DivisionIterator(VP[] v)
        {
            VPs = v;
        }
        public VP Next()
        {
            return VPs[location++];
        }
        public bool hasNext()
        {
            if (location < VPs.Length && VPs[location] != null)
            {
                return true;
            }
            return false;
        }
    }
}
