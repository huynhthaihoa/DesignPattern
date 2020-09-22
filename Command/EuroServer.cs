using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class EuroServer:Receiver
    {
        public EuroServer()
        { }
        public void connect()
        {
            Console.WriteLine("You're connected to the Euro server.");
        }
        public void diagnostics()
        {
            Console.WriteLine("The Euro server diagnostics check out OK.");
        }
        public void shutdown()
        {
            Console.WriteLine("Shutting down the Euro server.");
        }
        public void reboot()
        {
            Console.WriteLine("Rebooting the Euro server.");
        }
        public void disconnect()
        {
            Console.WriteLine("You’re disconnected from the Euro server.");
        } 
    }
}
