using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class RunDiagnosticCommand:Command
    {
        private Receiver receiver;
        public RunDiagnosticCommand(Receiver r)
        {
            receiver = r;
        }
        public void execute()
        {
            receiver.connect();
            receiver.diagnostics();
            receiver.disconnect();
            Console.WriteLine();
        }
        public void undo()
        {
            Console.WriteLine("Can't undo...");
            Console.WriteLine();
        }
    }
}
