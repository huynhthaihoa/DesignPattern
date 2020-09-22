using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public abstract class Vehicle
    {
        private GoAlgorithm goalgorithm;
        public Vehicle()
        { }
        public void setGoAlgorithm(GoAlgorithm algorithm)
        {
            goalgorithm = algorithm;
        }
        public void Go()
        {
            Console.WriteLine("Ready...");
            goalgorithm.Go();
            Console.WriteLine("Finished!");
        }
    }
}
