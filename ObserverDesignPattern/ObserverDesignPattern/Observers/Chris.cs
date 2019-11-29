using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Observers
{
    class Chris : IObserver
    {
        public List<WrestlingMatch> Results { get; set; } = new List<WrestlingMatch>();

        public void Update(WrestlingMatch wrestlingMatch)
        {
            Results.Add(wrestlingMatch);
        }
    }
}
