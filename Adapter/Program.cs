using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //create AceClass object 
            AceClass aceObject = new AceClass();
            aceObject.setName("Bruce Wayne");
            //pass this AceClass object to an AceToAcmeAdapter object
            AceToAcmeAdapter adapter = new AceToAcmeAdapter(aceObject);
            //use Acme methods
            Console.WriteLine("Customer's first name:" + adapter.getFirstName());
            Console.WriteLine("Customer's last name:" + adapter.getLastName());
        }
    }
}
