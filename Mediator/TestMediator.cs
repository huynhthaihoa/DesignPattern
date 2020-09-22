using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class TestMediator
    {
        public TestMediator()
        {
            Mediator mediator = new Mediator();
            mediator.getWelcome().go();
        }
        static void Main(string[] args)
        {
            TestMediator test = new TestMediator();
        }
    }
}
