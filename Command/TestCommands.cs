using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class TestCommands
    {
        public TestCommands()
        {
            Invoker invoker = new Invoker();
            InvokerPlus invokerplus = new InvokerPlus();
            //create the receivers
            AsiaServer asiaServer = new AsiaServer();
            EuroServer euroServer = new EuroServer();
            USServer usServer = new USServer();
            //Create the commands
            ShutDownCommand shutDownAsia = new ShutDownCommand(asiaServer);
            RunDiagnosticCommand runDiagnosticsAsia = new RunDiagnosticCommand(asiaServer);
            RebootCommand rebootAsia = new RebootCommand(asiaServer);
            ShutDownCommand shutDownEuro = new ShutDownCommand(euroServer);
            RunDiagnosticCommand runDiagnosticsEuro = new RunDiagnosticCommand(euroServer);
            RebootCommand rebootEuro = new RebootCommand(euroServer);
            ShutDownCommand shutDownUS = new ShutDownCommand(usServer);
            RunDiagnosticCommand runDiagnosticsUS = new RunDiagnosticCommand(usServer);
            RebootCommand rebootUS = new RebootCommand(usServer);
            //Create the invokers to run methods
            invoker.setCommand(shutDownAsia);
            invoker.run();
            invoker.setCommand(rebootAsia);
            invoker.run();
            invoker.setCommand(runDiagnosticsAsia);
            invoker.run();
            invoker.setCommand(shutDownEuro);
            invoker.run();
            invoker.setCommand(runDiagnosticsEuro);
            invoker.run();
            invoker.setCommand(rebootUS);
            invoker.run();
            invokerplus.setCommand(shutDownAsia);
            invokerplus.run();
            invokerplus.setCommand(rebootAsia);
            invokerplus.run();
            invokerplus.setCommand(runDiagnosticsAsia);
            invokerplus.run();
            invokerplus.undo();
            invokerplus.undo();
            invokerplus.undo();
        }
        static void Main(string[] args)
        {
            TestCommands t = new TestCommands();
        }
    }
}
