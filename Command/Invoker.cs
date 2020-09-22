using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Invoker
    {
        private Command command;
        public Invoker()
        { }
        public void setCommand(Command c)
        {
            command = c;
        }
        public void run()
        {
            command.execute();
        }
    }
}
