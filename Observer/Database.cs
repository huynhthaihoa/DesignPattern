using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer
{
    class Database:Subject
    {
        private List<Observer> observers;
        private string operation;
        private string record;
        public Database()
        {
            observers = new List<Observer>();
        }
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }
        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(operation, record);
            }
        }
        public void editRecord(string Operation,string Record)
        {
            operation = Operation;
            record = Record;
            notifyObservers();
        }
    }
}
