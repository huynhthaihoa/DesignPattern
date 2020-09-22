using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Application:Help
    {
        public Application()
        { }
        public void getHelp(int helpConstant)
        {
            Console.WriteLine("This is application.");
        }
    }
}
