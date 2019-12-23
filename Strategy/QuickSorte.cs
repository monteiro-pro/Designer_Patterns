using System;
using System.Collections.Generic;

namespace Strategy
{
    public class QuickSorte : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list ");
        }
    }
}
