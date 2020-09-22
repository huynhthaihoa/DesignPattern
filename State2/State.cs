using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    interface State
    {
        string gotApplication();
        string checkApplication();
        string rentApartment();
        string dispenseKeys();
    }
}
