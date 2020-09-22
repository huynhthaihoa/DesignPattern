using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class AutomotiveRobot:RobotTemplate
    {
        private string name;
        public AutomotiveRobot(string n)
        {
            name = n;
        }
        public override void test()
        {
            Console.WriteLine("Testing a carburetor...");
        }

        public override void assemble()
        {
            Console.WriteLine("Assembling a carburetor...");
        }

        public override void getParts()
        {
            Console.WriteLine("Getting a carburetor...");
        }
        public string getName()
        {
            return name;
        }
    }
}
