using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Interfaces
{
    public interface IObserver
    {
        public void Update(WrestlingMatch wrestlingMatch);
        public List<WrestlingMatch> Results { get; set; }
    }
}
