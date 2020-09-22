using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class IntermediateLayer:Help
    {
        const int INTERMEDIATE_LAYER_HELP = 2;
        Help successor;
        public IntermediateLayer(Help s)
        {
            successor = s;
        }
        public void getHelp(int helpConstant)
        {
            if (helpConstant != INTERMEDIATE_LAYER_HELP)
                successor.getHelp(helpConstant);
            else
                Console.WriteLine("This is intermediate layer.");
        }
    }
}
