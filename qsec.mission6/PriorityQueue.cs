using System;
using System.Collections.Generic;
using System.Text;

namespace qsec.mission6
{
    public class PriorityQueue<T>
    {
        List<Tuple<T,int>> queue = new List<Tuple<T, int>>();

        public void Add(T item, int priority)
        {
            queue.Add(new Tuple<T, int>(item, priority));
        }
    }
}
