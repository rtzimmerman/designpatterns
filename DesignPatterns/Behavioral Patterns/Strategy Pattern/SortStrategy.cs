using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
