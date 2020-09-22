using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class VPIterator:Iterator
    {
        private VP vp;
        public VPIterator(VP v)
        {
            vp = v;
        }
        public VP Next()
        {
            return vp;
        }
        public bool hasNext()
        {
            return false;
        }
    }
}
