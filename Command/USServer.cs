using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class USServer:Receiver
    {
        public USServer()
        { }
        public void connect()
        {
            Console.WriteLine("You're connected to the US server.");
        }
        public void diagnostics()
        {
            Console.WriteLine("The US server diagnostics check out OK.");
        }
        public void shutdown()
        {
            Console.WriteLine("Shutting down the US server.");
        }
        public void reboot()
        {
            Console.WriteLine("Rebooting the US server.");
        }
        public void disconnect()
        {
            Console.WriteLine("You’re disconnected from the US server.");
        } 
    }
}
