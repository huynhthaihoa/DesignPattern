using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class AceClass:AceInterface
    {
        string name;
        public void setName(string s)
        {
            name = s;
        }
        public string getName()
        {
            return name;
        }
    }
}
