using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        private char[] separation = new[] {' ', '.', ',', '!', '?', ':', '-', '\r', '\n'};
        private Dictionary<string, Dictionary<int, HashSet<int>>> words;

        #region Function Add
        public void Add(int id, string documentText)
        {
            var document = documentText.Split(separation);
            int currentPosition = 0;
            foreach (var words in document)
            {
                AddToWords(words, id, currentPosition);
                currentPosition += words.Length + 1;
            }
        }

        private void AddToWords(string word, int id, int currentPosition)
        {
            if (!words.ContainsKey(word))
            {
                var wordPosition = new HashSet<int>();
                wordPosition.Add(currentPosition);
                words.Add(word, new Dictionary<int, HashSet<int>>());
                words[word].Add(id, wordPosition);
            }
            else if (!words[word].ContainsKey(id))
            {
                words[word].Add(id, new HashSet<int>());
                words[word][id].Add(currentPosition);
            }

            else words[word][id].Add(currentPosition);
        }
        #endregion

        #region Function GetId
        public List<int> GetIds(string word)
        {
            if (words.ContainsKey(word))
            {
                return new List<int>(words[word].Keys);
            }

            else return new List<int>();
        }

        #endregion

        #region Function GetPositions
        public List<int> GetPositions(int id, string word)
        {
            if (words.ContainsKey(word) && words[word].ContainsKey(id))
            {
                return new List<int>(words[word][id]);
            }
            else return new List<int>();
        }
        #endregion

        #region Function Remove
        public void Remove(int id)
        {
            foreach (var word in words.Keys)
            {
                if (words[word].ContainsKey(id))
                    words[word].Remove(id);
            }
        }
        #endregion

        public Indexer()
        {
            words = new Dictionary<string, Dictionary<int, HashSet<int>>>();
        }


    }
}
