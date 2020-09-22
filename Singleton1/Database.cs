using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton1
{
    class Database
    {
        private int record;
        private string name;
        private static Database singleObject;
        private Database(string s)
        {
            name = s;
            record = 0;
        }
        public static Database getInstance(string s)
        {
            if (singleObject == null)
                singleObject = new Database(s);
            return singleObject;
        }
        public string getName()
        {
            return name;
        }
    }
}
