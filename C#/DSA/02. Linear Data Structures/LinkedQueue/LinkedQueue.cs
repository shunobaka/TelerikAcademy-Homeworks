using System.Collections.Generic;
namespace LinkedQueue
{
    public class LinkedQueue<T>
    {
        LinkedList<T> items = new LinkedList<T>();

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public void Clear()
        {
            this.items.Clear();
        }

        public bool Contains(T item)
        {
            return this.items.Contains(item);
        }

        public void Enqueue(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);

            items.AddLast(newNode);
        }

        public T Peek()
        {
            var item = items.First.Value;

            return item;
        }

        public T Dequeue()
        {
            var item = items.First.Value;

            items.RemoveFirst();

            return item;
        }
    }
}
