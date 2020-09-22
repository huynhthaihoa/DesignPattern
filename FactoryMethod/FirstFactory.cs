using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class FirstFactory
    {
        protected string type;
        public FirstFactory(string t)
        {
            type = t;
        }
        public Connection createConnection()
        {
            if (type.Equals("Oracle"))
            {
                return new OracleConnection();
            }
            else if (type.Equals("SQL Server"))
            {
                return new SQLServerConnection();
            }
            else
            {
                return new mySQLConnection();
            }
        }
    }
}
