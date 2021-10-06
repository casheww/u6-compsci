using System;

namespace AllOfTheDataTypes
{
    public class LinearQueue<T>
    {
        public LinearQueue(uint size)
        {
            _items = new T[size];
            _start = -1;
            _end = -1;
        }

        public void Enqueue(T item)
        {
            if (IsEmpty)
                _start = 0;
            else if (IsFull)
                throw new OverflowException();

            _end++;
            _items[_end] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty");

            T first = _items[_start];
            _start++;

            return first;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty");

            return _items[_start];
        }

        public override string ToString()
        {
            string str = "Linear queue\n" +
                         $"\tItems: {Count} \tCapacity: {Capacity}\n" +
                         $"\tStart: {_start} \tEnd: {_end}\n";

            for (int i = _start; i <= _end; i++)
            {
                str += $" {_items[i]} ";
            }

            return str + "\n";
        }

        public bool IsEmpty => _start == -1;

        public bool IsFull => _end == Capacity - 1;

        public int Count => _end - _start + 1;


        private T[] _items;
        private int _start;
        private int _end;
        public int Capacity => _items.Length;

    }
}
