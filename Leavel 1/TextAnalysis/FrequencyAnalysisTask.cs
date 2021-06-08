using System.Collections.Generic;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            return GetMostFrequentNextWords(GetFrequencyDictionary(text));
        }

        private static Dictionary<string, Dictionary<string, int>> GetFrequencyDictionary(List<List<string>> text)
        {
            var frequencyDictionary = new Dictionary<string, Dictionary<string, int>>();
            foreach (var sentence in text)
            {
                for (int i = 0; i < sentence.Count - 1; i++)
                {
                    AddWordInFrequencyDictionary(frequencyDictionary, sentence[i], sentence[i + 1]);
                    if (i < sentence.Count - 2)
                    {
                        AddWordInFrequencyDictionary(frequencyDictionary,
                                                     $"{sentence[i]} {sentence[i + 1]}", sentence[i + 2]);
                    }
                }
            }

            return frequencyDictionary;
        }

        private static void AddWordInFrequencyDictionary(Dictionary<string,
                                                         Dictionary<string, int>
                                                         > frequencyDictionary,
                                                         string word, string continuation)
        {
            if (frequencyDictionary.ContainsKey(word))
            {
                if (frequencyDictionary[word].ContainsKey(continuation))
                {
                    frequencyDictionary[word][continuation]++;
                }
                else
                {
                    frequencyDictionary[word].Add(continuation, 1);
                }
            }
            else
            {
                frequencyDictionary.Add(word, new Dictionary<string, int> { { continuation, 1 } });
            }
        }

        private static Dictionary<string, string> GetMostFrequentNextWords(Dictionary<string,
                                                                           Dictionary<string, int>> frequencyDictionary)
        {
            var result = new Dictionary<string, string>();

            foreach (var words in frequencyDictionary)
                result.Add(words.Key, GetNoteMostFrequentNextWords(words));

            return result;
        }

        private static string GetNoteMostFrequentNextWords(KeyValuePair<string, Dictionary<string, int>> words)
        {
            var mostFrequentNextWords = "";
            var mostFrequencyNumber = 0;
            foreach (var nextWords in words.Value)
            {
                if (nextWords.Value >= mostFrequencyNumber)
                {
                    if (nextWords.Value == mostFrequencyNumber)
                    {
                        if (string.CompareOrdinal(mostFrequentNextWords, nextWords.Key) > 0)
                        {
                            mostFrequentNextWords = nextWords.Key;
                            mostFrequencyNumber = nextWords.Value;
                        }
                    }
                    else
                    {
                        mostFrequentNextWords = nextWords.Key;
                        mostFrequencyNumber = nextWords.Value;
                    }
                }
            }

            return mostFrequentNextWords;
        }
    }
}