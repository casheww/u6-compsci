using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ArrayBenchmarking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BenchmarkRunner.Run<ArrayBenchmarker>();
        }
    }
    
    [MemoryDiagnoser]
    public class ArrayBenchmarker
    {
        [GlobalSetup]
        public void Setup()
        {
            
            Random rand = new Random();
            indexes = new int[500];
            
            for (int i = 0; i < indexes.Length; i += 2)
            {
                indexes[i] = rand.Next(0, (int)sideLength);
                indexes[i + 1] = rand.Next(0, (int)sideLength);
            }
            
            // set up arrays for the get benchmarks
            TestMultidimensionalArray();
            TestJaggedArray();
            TestCustomArray();
        }

        [Benchmark]
        public void TestMultidimensionalArray()
        {
            mdArray = new int[sideLength, sideLength];

            for (int x = 0; x < sideLength; x++)
            for (int y = 0; y < sideLength; y++)
                mdArray[x, y] = x * y;
        }
        
        [Benchmark]
        public void TestMultidimensionalArray_Get()
        {
            for (int i = 0; i < indexes.Length; i += 2)
            {
                _ = mdArray[indexes[i], indexes[i + 1]];
            }
        }

        [Benchmark]
        public void TestJaggedArray()
        {
            jArray = new int[sideLength][];
            for (int x = 0; x < sideLength; x++)
            {
                jArray[x] = new int[sideLength];
            }

            for (int x = 0; x < sideLength; x++)
            for (int y = 0; y < sideLength; y++)
                jArray[x][y] = x * y;
        }

        [Benchmark]
        public void TestJaggedArray_Get()
        {
            for (int i = 0; i < indexes.Length; i += 2)
            {
                _ = jArray[indexes[i]][indexes[i + 1]];
            }
        }

        [Benchmark]
        public void TestCustomArray()
        {
            cArray = new CustomArray<int>(sideLength, sideLength);

            for (int x = 0; x < sideLength; x++)
            for (int y = 0; y < sideLength; y++)
                cArray[x, y] = x * y;
        }

        [Benchmark]
        public void TestCustomArray_Get()
        {
            for (int i = 0; i < indexes.Length; i += 2)
            {
                _ = cArray[indexes[i], indexes[i + 1]];
            }
        }

        public static int[] indexes;
        
        [Params(50, 100, 500)]
        public static uint sideLength;

        public static int[,] mdArray;
        public static int[][] jArray;
        public static CustomArray<int> cArray;
    }
}