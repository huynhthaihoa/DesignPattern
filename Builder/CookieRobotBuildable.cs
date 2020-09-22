using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Builder
{
    class CookieRobotBuildable:RobotBuildable
    {
        private ArrayList actions;
        public CookieRobotBuildable()
        { }
        public void loadActions(ArrayList a)
        {
            actions = a;
        }
        public void go()
        {
            
        }
    }
}
