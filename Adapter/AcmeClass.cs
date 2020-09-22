using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class AcmeClass
    {
        private string firstname;
        private string lastname;
        public void setFirstName(string f)
        {
            firstname = f;
        }
        public void setLastName(string l)
        {
            lastname = l;
        }
        public string getFirstName()
        {
            return firstname;
        }
        public string getLastName()
        {
            return lastname;
        }
    }
}
