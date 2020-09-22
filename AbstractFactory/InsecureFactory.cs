using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class InsecureFactory:ConnectionFactory
    {
        public override Connection createConnection(string type)
        {
            if (type.Equals("Oracle"))
            {
                return new InsecureOracleConnection();
            }
            else if (type.Equals("SQL Server"))
            {
                return new InsecureSQLServerConnection();
            }
            else
                return new InsecureMySQLConnection();
        } 
    }
}
