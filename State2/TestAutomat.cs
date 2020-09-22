using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    class TestAutomat
    {
        private Automat automat;
        public TestAutomat()
        {
            automat = new Automat(9);
            automat.gotApplication();
            automat.checkApplication();
            automat.rentApartment();
        }
        static void Main(string[] args)
        {
            TestAutomat test = new TestAutomat();
        }
    }
}
