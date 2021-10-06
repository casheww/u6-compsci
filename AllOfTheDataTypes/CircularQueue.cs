using System;

namespace AllOfTheDataTypes
{
    public class CircularQueue<T>
    {
        public CircularQueue(uint size)
        {
            _items = new T[size];
            Start = -1;
            End = -1;
            Count = 0;
        }

        public void Enqueue(T item)
        {
            if (IsEmpty)
                Start = 0;
            else if (IsFull)
                throw new Exception("Queue is full");

            End++;
            _items[End] = item;
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty");

            T first = _items[Start];
            Start++;
            Count--;

            return first;
        }
        
        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty");

            return _items[Start];
        }
        
        public override string ToString()
        {
            string str = "Circular queue\n" +
                         $"\tItems: {Count} \tCapacity: {Capacity}\n" +
                         $"\tStart: {Start} \tEnd: {End}\n";

            if (IsEmpty) return str;

            int index = Start;
            for (int i = 0; i < Count; i++)
            {
                str += $" {_items[index]} ";
                index++;
                if (index >= Capacity) index = 0;
            }

            return str + "\n";
        }


        public bool IsEmpty => Count == 0;
        public bool IsFull => (End + 1) % Capacity == Start;
        

        private T[] _items;
        
        private int Start
        {
            get => _start;
            set => _start = value >= Capacity ? 0 : value;
        }
        private int _start;

        private int End
        {
            get => _end;
            set => _end = value >= Capacity ? 0 : value;
        }
        private int _end;

        public int Capacity => _items.Length;
        public int Count { get; private set; }

    }
}
