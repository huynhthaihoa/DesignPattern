using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a computer
            Computer computer = new Computer();
            //add devices
            computer = new Disk(computer);
            computer = new CD(computer);
            computer = new Monitor(computer);
            //display the resulting wrapped computer's full configuration
            Console.WriteLine("You are getting " + computer.Description());
        }
    }
}
