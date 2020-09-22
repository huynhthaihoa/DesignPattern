using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Client:Observer
    {
        public Client()
        { }
        public void Update(string operation, string record)
        {
            Console.WriteLine("The client says a " + operation + " operation was performed on "
                + record);
        }
    }
}
