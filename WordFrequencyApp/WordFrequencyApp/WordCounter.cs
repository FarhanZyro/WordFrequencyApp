using System.Collections.Generic;

namespace WordFrequencyApp
{
    class WordCounter
    {
        public Dictionary<string, int> CountWords(List<string> words)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}