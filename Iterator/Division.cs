using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Division
    {
        private VP[] VPs = new VP[100];
        private int number = 0;
        private string name;

        public string Name
        {
            get { return name; }
        }
        public Division(string n)
        {
            name = n;
        }
        public void Add(string n)
        {
            VP vp = new VP(n, name);
            VPs[number++] = vp;
        }
        public DivisionIterator iterator()
        {
            return new DivisionIterator(VPs);
        }
    }
}
