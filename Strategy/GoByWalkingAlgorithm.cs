﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class GoByWalkingAlgorithm : GoAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Now I'm going by walking.");
        }
    }
}
