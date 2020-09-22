using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Archiver:Observer
    {
        public Archiver()
        { }
        public void Update(string operation, string record)
        {
            Console.WriteLine("The archiver says a " + operation + " operation was performed on "
                + record);
        }
    }
}
