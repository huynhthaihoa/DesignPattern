using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class AceToAcmeAdapter:AcmeInterface
    {
        private AceClass aceObject;
        private string firstname;
        private string lastname;
        public AceToAcmeAdapter(AceClass a)
        {
            aceObject = a;
            firstname = aceObject.getName().Split()[0];
            lastname = aceObject.getName().Split()[1];
        }
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
