using System;
using System.Collections.Generic;
using System.IO;

namespace HashDicts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"cwd: {Directory.GetCurrentDirectory()}");
            Console.Write("Enter name of txt >  ");
            string input = Console.ReadLine();

            Dictionary<string, int> wordCounts = ParseText("../../../" + input);
            PrintWordCounts(wordCounts);
        }

        private static Dictionary<string, int> ParseText(string fp)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in File.ReadLines(fp))
            {
                if (wordCounts.ContainsKey(word))
                    wordCounts[word]++;
                else
                    wordCounts[word] = 1;
            }

            return wordCounts;
        }

        private static void PrintWordCounts(Dictionary<string, int> wordCounts)
        {
            foreach (KeyValuePair<string, int> pair in wordCounts)
                Console.WriteLine($"{pair.Key}\t\t\t:\t{pair.Value}");
        }
        
    }
}
