using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class AsiaServer:Receiver
    {
        public AsiaServer()
        { }
        public void connect()
        {
            Console.WriteLine("You're connected to the Asia server.");
        }
        public void diagnostics()
        {
            Console.WriteLine("The Asia server diagnostics check out OK.");
        }
        public void shutdown()
        {
            Console.WriteLine("Shutting down the Asia server.");
        }
        public void reboot()
        {
            Console.WriteLine("Rebooting the Asia server.");
        }
        public void disconnect()
        {
            Console.WriteLine("You’re disconnected from the Asia server."); 
        }
    }
}
