using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a SecureFactory object 
            ConnectionFactory factory = new SecureFactory();
            //create a new secure connection to a database server like Oracle
            Connection connection = factory.createConnection("Oracle");
            //verify that you're now building secure connection
            Console.WriteLine("You're connecting with " + connection.Description());
            ConnectionFactory factory2 = new InsecureFactory();
            Connection connection2 = factory2.createConnection("Oracle");
            Console.WriteLine("You're connecting with " + connection2.Description());
        }
    }
}
