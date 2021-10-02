using System;

namespace AllOfTheDataTypes
{
    /// <summary>
    /// Circular queueuueueue.
    /// </summary>
    public class Queue<T>
    {
        public Queue(uint size)
        {
            _items = new T[size];
            _startPointer = -1;
            _endPointer = 0;
        }

        public void Enqueue(T value)
        {
            if (!IsFull)
            {
                _items[EndPointer] = value;
                EndPointer++;
            }
            else
                throw new StackOverflowException();
        }

        public bool TryDequeue(out T value)
        {
            value = default;

            if (!IsEmpty)
            {
                value = _items[StartPointer];
                StartPointer++;
                return true;
            }

            return false;
        }
        
        public bool IsFull => StartPointer == EndPointer;

        public bool IsEmpty => StartPointer + 1 == EndPointer;

        private T[] _items;
        public int MaxCapacity => _items.Length;

        private int StartPointer
        {
            get => _startPointer;
            set => _startPointer = value < MaxCapacity ? value : 0;
        }
        private int _startPointer;

        private int EndPointer
        {
            get => _endPointer;
            set => _endPointer = value < MaxCapacity ? value : 0;
        }
        private int _endPointer;
        
    }
}