using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class SecureFactory:ConnectionFactory
    {
        public override Connection createConnection(string type)
        {
            if (type.Equals("Oracle"))
            {
                return new SecureOracleConnection();
            }
            else if (type.Equals("SQL Server"))
            {
                return new SecureSQLServerConnection();
            }
            else
                return new SecureMySQLConnection();
        } 
    }
}
