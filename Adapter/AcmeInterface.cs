using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    interface AcmeInterface
    {
        void setFirstName(string f);
        void setLastName(string l);
        string getFirstName();
        string getLastName();
    }
}
