using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Quick sorted list");
        }
    }
}
