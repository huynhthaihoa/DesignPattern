﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Helicopter : Vehicle
    {
        public Helicopter()
        {
            setGoAlgorithm(new GoByFlyingAlgorithm());
        }
    }
}
