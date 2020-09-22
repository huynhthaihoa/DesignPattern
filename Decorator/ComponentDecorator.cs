using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class ComponentDecorator : Computer
    {
        public abstract override string Description();
    }
}
