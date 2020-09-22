using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    abstract class RobotTemplate
    {
        public void go()
        {
            start();
            getParts();
            assemble();
            if(testOK())
                test();
            stop();
        }

        private void stop()
        {
            Console.WriteLine("Stopping...");
        }

        public virtual void test()
        {
            Console.WriteLine("Testing...");
        }

        public virtual void assemble()
        {
            Console.WriteLine("Assembling...");
        }

        public virtual void getParts()
        {
            Console.WriteLine("Getting parts...");
        }

        private void start()
        {
            Console.WriteLine("Starting...");
        }
        public virtual bool testOK()
        {
            return true;
        }
    }
}
