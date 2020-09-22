using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class ShutDownCommand:Command
    {
        private Receiver receiver;
        public ShutDownCommand(Receiver r)
        {
            receiver = r;
        }
        public void execute()
        {
            receiver.connect();
            receiver.shutdown();
            receiver.disconnect();
            Console.WriteLine();
        }
        public void undo()
        {
            Console.WriteLine("Undoing...");
            receiver.connect();
            receiver.reboot();
            receiver.disconnect();
            Console.WriteLine();
        }
    }
}
