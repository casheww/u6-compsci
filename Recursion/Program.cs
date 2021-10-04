using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(FactorialTests));
        }

    }

    public class FactorialTests
    {
        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public int FactorialLoop(int n)
        {
            for (int i = n - 1; i > 0; i--)
                n *= i;

            return n;
        }
        
        [Benchmark]
        [ArgumentsSource(nameof(Numbers))]
        public int FactorialRecursive(int n)
        {
            if (n > 1)
                n *= FactorialRecursive(n - 1);
            return n;
        }

        public IEnumerable<int> Numbers()
        {
            yield return 10;
            yield return 100;
        }
    }
    
}