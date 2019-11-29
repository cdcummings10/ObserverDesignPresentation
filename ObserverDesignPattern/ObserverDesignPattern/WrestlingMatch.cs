using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class WrestlingMatch
    {
        public WrestlingMatch(string score)
        {
            Score = score;
        }
        public string Score { get; set; }
    }
}
