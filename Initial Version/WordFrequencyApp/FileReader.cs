using System;
using System.Collections.Generic;
using System.IO;

namespace WordFrequencyApp
{
    class FileReader
    {
        public List<string> ReadAllTextFiles(string folderPath)
        {
            List<string> texts = new List<string>();

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Directory does not exist.");
                return texts;
            }

            string[] files = Directory.GetFiles(folderPath, "*.txt");

            foreach (string file in files)
            {
                try
                {
                    string content = File.ReadAllText(file);
                    texts.Add(content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {file}");
                }
            }

            return texts;
        }
    }
}