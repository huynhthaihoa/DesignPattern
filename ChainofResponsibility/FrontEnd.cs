using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class FrontEnd:Help
    {
        const int FRONT_END_HELP = 1;
        Help successor;
        public FrontEnd(Help s)
        {
            successor = s;
        }
        public void getHelp(int helpConstant)
        {
            if (helpConstant != FRONT_END_HELP)
                successor.getHelp(helpConstant);
            else
                Console.WriteLine("This is front end.");
        }

    }
}
