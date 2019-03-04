using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    //Context class
    public class SortedList
    {
        private List<string> List = new List<string>();
        private SortStrategy SortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.SortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            this.List.Add(name);
        }

        public void Sort()
        {
            this.SortStrategy.Sort(this.List);

            foreach (var item in this.List)
            {
                Console.WriteLine("" + item);
            }
        }


    }
}
