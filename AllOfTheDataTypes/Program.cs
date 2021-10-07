using System;

namespace AllOfTheDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinearQueue();
            Console.WriteLine("\n\n\n");
            TestCircularQueue();
            Console.WriteLine("DONE");
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

        private static void TestCircularQueue()
        {
            Console.WriteLine("# CIRCULAR QUEUE TEST");
            CircularQueue<int> cq = new CircularQueue<int>(8);

            Console.WriteLine($"capacity: {cq.Capacity}");
            Console.WriteLine($"empty? {cq.IsEmpty}");
            Console.WriteLine($"full? {cq.IsFull}");

            for (int i = 3; i < 8; i++)
                cq.Enqueue(i);

            Console.WriteLine(cq);
            Console.WriteLine($"empty? {cq.IsEmpty}");
            Console.WriteLine($"full? {cq.IsFull}");

            for (int i = 0; i < 2; i++)
                cq.Dequeue();

            Console.WriteLine(cq);
            
            for (int i = 0; i < 5; i++)
                cq.Enqueue(i);

            Console.WriteLine(cq);
            Console.WriteLine($"full? {cq.IsFull}");
        }
        
    }
}