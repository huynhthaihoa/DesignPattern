using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    interface Receiver
    {
        void connect();
        void diagnostics();
        void reboot();
        void shutdown();
        void disconnect();
    }
}
