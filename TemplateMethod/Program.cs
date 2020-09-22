using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create objects
            AutomotiveRobot automotiveRobot = new AutomotiveRobot("Automotive Robot");
            CookieRobot cookieRobot = new CookieRobot("Cookie Robot");
            Console.WriteLine(automotiveRobot.getName() + ":");
            //call go method
            automotiveRobot.go();
            Console.WriteLine();
            Console.WriteLine(cookieRobot.getName() + ":");
            cookieRobot.go();
        }
    }
}
