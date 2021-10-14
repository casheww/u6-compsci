using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbres = new int[]
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
            int[] numbres1 = new System.Collections.Generic.List<int>(numbres).ToArray();
            
            Console.WriteLine(string.Join(", ", numbres));

            BubbleSort(numbres);
            Console.WriteLine("bubble sort:  " + string.Join(", ", numbres));

            numbres1 = MergeSort(numbres1);
            Console.WriteLine("merge sort:  " + string.Join(", ", numbres1));

            bool sameValues = true;
            for (int i = 0; i < numbres.Length; i++)
            {
                if (numbres[i] != numbres1[i])
                {
                    sameValues = false;
                    break;
                }
            }

            Console.WriteLine($"same? {sameValues}");

        }
        

        private static void BubbleSort(int[] array)
        {
            bool done;
            do
            {
                done = true;
                
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        done = false;
                    }
                }
                
            } while (!done);
        }

        private static int[] MergeSort(int[] array)
        {
            if (array.Length < 3)
                return array;
            
            int mid = array.Length / 2;

            int[] half0 = MergeSort(array[..mid]);
            int[] half1 = MergeSort(array[mid..]);

            return Merge(half0, half1);
        }

        private static int[] Merge(int[] array0, int[] array1)
        {
            int resultLength = array0.Length + array1.Length;
            int[] result = new int[resultLength];
            int mIndex = -1;
            int i0 = 0;
            int i1 = 0;

            bool done = false;
            while (!done)
            {
                bool done0 = i0 == array0.Length;
                bool done1 = i1 == array1.Length;

                if (done0 && done1)
                {
                    done = true;
                }
                else if (done0 || !done1 && array0[i0] > array1[i1])
                {
                    // 0 empty, 1 not empty
                    // OR next item from 0 > next item from 1
                    mIndex++;
                    result[mIndex] = array1[i1];
                    i1++;
                }
                else if (done1 || !done0 && array0[i0] <= array1[i1])
                {
                    // 0 not empty, 1 empty
                    // OR next item from 0 <= next item from 1
                    mIndex++;
                    result[mIndex] = array0[i0];
                    i0++;
                }

            }

            return result;
        }
    }
}
