using System;
using System.Collections.Generic;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(
            Dictionary<string, string> nextWords,
            string phraseBeginning,
            int wordsCount)
        {
            string result = string.Empty;

            for (int i = 0; i < wordsCount; ++i)
            {
                string[] s = phraseBeginning.Split(' ');
                if (s.Length == 0) break;

                if (s.Length >= 2) {
                    if (nextWords.ContainsKey(string.Format("{0} {1}", s[s.Length - 2], s[s.Length - 1]))) {
                        phraseBeginning += " " + nextWords[string.Format("{0} {1}", s[s.Length - 2], s[s.Length - 1])];
                        continue;
                    }
                }
                if (nextWords.ContainsKey(s[s.Length - 1])) {
                    phraseBeginning += " " + nextWords[s[s.Length - 1]];
                    continue;
                }
                break;
            }


            return phraseBeginning;
        }
    }
}

