using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GENERAL_HELP = 3;
            Application app = new Application();
            IntermediateLayer intermediatelayer = new IntermediateLayer(app);
            FrontEnd frontend = new FrontEnd(intermediatelayer);
            frontend.getHelp(GENERAL_HELP);
        }
    }
}
