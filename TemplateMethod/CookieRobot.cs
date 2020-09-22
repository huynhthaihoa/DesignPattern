using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class CookieRobot:RobotTemplate
    {
        private string name;
        public CookieRobot(string n)
        {
            name = n;
        }
        public override void test()
        {
            Console.WriteLine("Crunching a cookie...");
        }

        public override void assemble()
        {
            Console.WriteLine("Baking a cookie...");
        }

        public override void getParts()
        {
            Console.WriteLine("Getting flour and sugar...");
        }
        public string getName()
        {
            return name;
        }
        public override bool testOK()
        {
            return false;
        }
    }
}
