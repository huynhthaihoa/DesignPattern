using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database;
            database = Database.getInstance("products");
            Console.WriteLine("This is the " + database.getName() + " database.");
            database = Database.getInstance("employees");
            Console.WriteLine("This is the " + database.getName() + " database.");
        }
    }
}
