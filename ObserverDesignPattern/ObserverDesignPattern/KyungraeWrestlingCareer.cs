using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class KyungraeWrestlingCareer : ISubject
    {
        private List<IObserver> _observers { get; set; } = new List<IObserver>();

        public void SendMatchResult()
        {
            Console.WriteLine("What happened in the match today?");
            string matchResult = Console.ReadLine();
            Console.WriteLine("\n");
            WrestlingMatch match = new WrestlingMatch(matchResult);
            NotifyObserver(match);
        }

        public void NotifyObserver(WrestlingMatch wrestlingMatch)
        {
            foreach(var observer in _observers)
            {
                observer.Update(wrestlingMatch);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
