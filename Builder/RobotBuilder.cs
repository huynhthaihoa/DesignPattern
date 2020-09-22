using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    interface RobotBuilder
    {
        void addStart();
        void addGetParts();
        void addAssemble();
        void addTest();
        void addStop();
        RobotBuildable getRobot();
    }
}
