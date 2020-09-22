using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Database object
            Database database = new Database();
            //create 3 observers
            Archiver archiver = new Archiver();
            Client client = new Client();
            Boss boss = new Boss();
            //register the observers with the object
            database.registerObserver(archiver);
            database.registerObserver(client);
            database.registerObserver(boss);
            //perform a delete operation on record 1 in the database
            database.editRecord("delete", "record 1");
        }
    }
}
