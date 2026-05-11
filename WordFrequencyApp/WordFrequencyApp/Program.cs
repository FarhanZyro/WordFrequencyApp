using System;
using System.Collections.Generic;

namespace WordFrequencyApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter folder path:");
            string path = Console.ReadLine();

            Console.WriteLine("Enter N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter M:");
            int M = int.Parse(Console.ReadLine());

            FileReader reader = new FileReader();
            TextProcessor processor = new TextProcessor();
            WordCounter counter = new WordCounter();

            List<string> allTexts = reader.ReadAllTextFiles(path);

            List<string> allWords = new List<string>();

            foreach (string text in allTexts)
            {
                allWords.AddRange(processor.ProcessText(text, N, M));
            }

            Dictionary<string, int> result = counter.CountWords(allWords);

            Console.WriteLine("\nWord Frequency:\n");

            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            Console.ReadKey();
        }
    }
}