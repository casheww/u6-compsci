using System;

namespace Stacks
{
    public class Stack<T>
    {
        public Stack(int size)
        {
            _items = new T[size];
            TopOfStackPointer = -1;
        }
        
        public void Push(T value)
        {
            if (!IsFull)
            {
                TopOfStackPointer++;
                _items[TopOfStackPointer] = value;
            }
            else
                throw new StackOverflowException();
        }

        public bool TryPop(out T value)
        {
            value = default;
            
            if (!IsEmpty)
            {
                value = _items[TopOfStackPointer];
                TopOfStackPointer--;
                return true;
            }
            
            return false;
        }

        public bool TryPeek(out T value)
        {
            if (!IsEmpty)
            {
                value = _items[TopOfStackPointer];
                return true;
            }

            value = default;
            return default;
        }

        public bool IsEmpty => TopOfStackPointer == -1;

        public bool IsFull => TopOfStackPointer + 1 == MaxCapacity;

        public void DebugPrint()
        {
            Console.WriteLine($"Stack contains {TopOfStackPointer + 1} items:");
            foreach (T val in _items)
            {
                if (val != null)
                    Console.WriteLine($"\t- {val}");
            }
        }
        
        private readonly T[] _items;
        public int MaxCapacity => _items.Length;
        public int TopOfStackPointer { get; private set; }
    }
}
