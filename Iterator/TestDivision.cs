using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class TestDivision
    {
        private Division division;
        private DivisionIterator iterator;
        public TestDivision()
        {
            //create the Sales division
            division = new Division("Sales");
            //add some VP
            division.Add("Ash");
            division.Add("Bob");
            division.Add("Catherine");
            division.Add("Dianna");
            iterator = division.iterator();
            //loop over the collection of VP,display each one
            while (iterator.hasNext())
            {
                VP vp = iterator.Next();
                vp.print();
            }
        }
        static void Main(string[] args)
        {
            TestDivision t = new TestDivision();
        }
    }
}
