using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class TestRentalMethod
    {
        private RentalMethod rentalmethod;
        public TestRentalMethod()
        {
            rentalmethod = new RentalMethod(9);
            rentalmethod.getApplication();
            rentalmethod.checkApplication();
        }
        static void Main(string[] args)
        {
            TestRentalMethod t = new TestRentalMethod();
        }
    }
}
