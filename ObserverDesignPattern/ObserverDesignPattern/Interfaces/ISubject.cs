using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Interfaces
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void UnregisterObserver(IObserver observer);
        public void NotifyObserver(WrestlingMatch wrestlingMatch);
    }
}
