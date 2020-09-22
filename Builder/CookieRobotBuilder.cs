using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Builder
{
    class CookieRobotBuilder:RobotBuilder
    {
        private CookieRobotBuildable robot;
        private ArrayList actions;
        public CookieRobotBuilder()
        {
            robot = new CookieRobotBuildable();
            actions = new ArrayList();
        }
        public void addStart()
        {
            actions.Add(1);
        }
        public void addGetParts()
        {
            actions.Add(2);
        }
        public void addAssemble()
        {
            actions.Add(3);
        }
        public void addTest()
        {
            actions.Add(4);
        }
        public void addStop()
        {
            actions.Add(5);
        }
        public RobotBuildable getRobot()
        {
            robot.loadActions(actions);
            return robot;
        }
    }
}
