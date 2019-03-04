using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    //if (list[j] < list[i])
                    //{

                    //}
                }

            }
        }
    }
}
