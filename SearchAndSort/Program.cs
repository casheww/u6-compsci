using System;

namespace SearchAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[]
            {
                1,
                6,
                -237,
                420,
                -69,
                389589,
                -2498,
                43
            };
            int[] numbers1 = new System.Collections.Generic.List<int>(numbers).ToArray();

            int searchTarget = numbers[(new Random()).Next(numbers.Length)];
            
            Console.WriteLine(string.Join(", ", numbers));

            Sort.BubbleSort(numbers);
            Console.WriteLine("bubble sort:  " + string.Join(", ", numbers));

            numbers1 = Sort.MergeSort(numbers1);
            Console.WriteLine("merge sort:  " + string.Join(", ", numbers1));

            bool sameValues = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers1[i])
                {
                    sameValues = false;
                    break;
                }
            }

            Console.WriteLine($"same? {sameValues}");

            Console.WriteLine("\n\nSEARCHING:\n");
            Console.WriteLine(string.Join(", ", numbers));

            if (Search.LinearSearch(numbers, searchTarget, out int index))
                Console.WriteLine($"linear search found {searchTarget} at {index}");
            else
                Console.WriteLine("!!! value not found");
            
            if (Search.BinarySearch(numbers, searchTarget, out index))
                Console.WriteLine($"binary search found {searchTarget} at {index}");
            else
                Console.WriteLine("!!! value not found");

        }

    }
}
