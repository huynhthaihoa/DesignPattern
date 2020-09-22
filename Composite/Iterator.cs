using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    interface Iterator
    {
        VP Next();
        bool hasNext();
    }
}
