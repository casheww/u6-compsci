using System;

namespace AllOfTheDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(5);
            
            Console.WriteLine($"full? {q.IsFull}");
            Console.WriteLine($"empty? {q.IsEmpty}");

            for (int i = 0; i < q.MaxCapacity; i++)
            {
                q.Enqueue(i);
            }

            Console.WriteLine($"full? {q.IsFull}");
            Console.WriteLine($"empty? {q.IsEmpty}");

            for (int i = 0; i < 3; i++)
            {
                q.TryDequeue(out int val);
                Console.WriteLine($"removed {val}");
            }
            
            Console.WriteLine($"full? {q.IsFull}");
            Console.WriteLine($"empty? {q.IsEmpty}");
            
            
            
        }
    }
}