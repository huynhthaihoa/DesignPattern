using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Boss:Observer
    {
        public Boss()
        { }
        public void Update(string operation, string record)
        {
            Console.WriteLine("The boss says a " + operation + " operation was performed on "
                + record);
        }
    }
}
