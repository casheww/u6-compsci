using System;

namespace AllOfTheDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinearQueue();
        }

        private static void TestLinearQueue()
        {
            Console.WriteLine("# LINEAR QUEUE TEST");
            LinearQueue<int> lq = new LinearQueue<int>(8);

            Console.WriteLine($"capacity: {lq.Capacity}");
            Console.WriteLine($"empty? {lq.IsEmpty}");
            Console.WriteLine($"full? {lq.IsFull}");

            for (int i = 3; i < 8; i++)
                lq.Enqueue(i);

            Console.WriteLine(lq);
            Console.WriteLine($"empty? {lq.IsEmpty}");
            Console.WriteLine($"full? {lq.IsFull}");

            for (int i = 0; i < 2; i++)
                lq.Dequeue();

            Console.WriteLine(lq);
            
            for (int i = 0; i < 3; i++)
                lq.Enqueue(i);

            Console.WriteLine(lq);
            Console.WriteLine($"full? {lq.IsFull}");
        }
    }
}