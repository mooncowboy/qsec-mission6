using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace qsec.mission6
{
    public class DelayedQueue<T> 
    {
        ConcurrentQueue<T> queue = new ConcurrentQueue<T>();
        public void AddAsync(T item, TimeSpan inTime)
        {
            var startTimeSpan = TimeSpan.Zero;
            
            // Should be thread safe..
            var timer = new System.Threading.Timer((e) =>
            {
                queue.Enqueue(item);
            }, null, startTimeSpan, inTime);

        }

        public int QueueSize 
        {
            get
            {
                return queue.Count;
            }
        }

        public T DeQueue()
        {
            T item = default(T);
            var result = queue.TryDequeue(out item);
            return item;
        }
    }
}
