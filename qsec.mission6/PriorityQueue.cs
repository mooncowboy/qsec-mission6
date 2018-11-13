using System;
using System.Collections.Generic;
using System.Text;

namespace qsec.mission6
{
    public class PriorityQueue<T>
    {
        List<Tuple<T,int, DateTime>> queue = new List<Tuple<T, int, DateTime>>();

        public void Add(T item, int priority)
        {
            queue.Add(new Tuple<T, int, DateTime>(item, priority, DateTime.UtcNow));
        }

        public T GetItem() 
        {
            queue.Sort((x, y) => {
                int result = x.Item3.CompareTo(y.Item3);
                return result == 0 ? x.Item2.CompareTo(y.Item2) : result;
            });

            var item = queue[0].Item1;
            queue.Remove(queue[0]);
                
            return item;
        }
    }
}
