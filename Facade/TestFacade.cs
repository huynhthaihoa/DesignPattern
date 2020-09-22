using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class TestFacade
    {
        public TestFacade()
        {
            SimpleProductFacade simpleproductfacade = new SimpleProductFacade();
            simpleproductfacade.setName("printer");
            Console.WriteLine("This product is a " + simpleproductfacade.getName());
        }
        static void Main(string[] args)
        {
            TestFacade t = new TestFacade();
        }
    }
}
