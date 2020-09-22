using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create FirstFactory object which will create Oracle connections
            FirstFactory firstfactory;
            firstfactory = new FirstFactory("Oracle");
            //store object that the factory creates in a Connection variable
            Connection connection = firstfactory.createConnection();
            //check the connection object that's been created to make sure it's an Oracle connection object
            Console.WriteLine("You are connecting with " + connection.Description());
        }
    }
}
