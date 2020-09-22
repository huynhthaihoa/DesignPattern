using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class StreetRunner : Vehicle
    {
        public StreetRunner()
        {
            setGoAlgorithm(new GoByWalkingAlgorithm());
        }
    }
}
