using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequencyApp
{
    class TextProcessor
    {
        public List<string> ProcessText(string text, int N, int M)
        {
            List<string> words = new List<string>();

            // Convert to lowercase
            text = text.ToLower();

            // Remove punctuation
            text = Regex.Replace(text, @"[^\w\s]", " ");

            // Split words
            string[] tokens = text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string word in tokens)
            {
                string processedWord = word;

                // Version 2 rule
                if (word.Length > N && word.Length > M)
                {
                    processedWord = word.Substring(0, word.Length - M);
                }

                words.Add(processedWord);
            }

            return words;
        }
    }
}