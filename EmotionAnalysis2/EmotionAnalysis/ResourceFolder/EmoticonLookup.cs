using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class EmoticonLookup
    {

        private readonly Dictionary<string, int> _emoticonDictionary = new Dictionary<string, int>();
        public bool Initialize(string emoticonFileName)
        {
            if (File.Exists(emoticonFileName))
            {
                string[] lines = File.ReadAllLines(emoticonFileName);
                foreach (string line in lines)
                {
                    string[] lineWords = line.Split('\t');
                    _emoticonDictionary[lineWords[0]] = Int32.Parse(lineWords[1]);
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", emoticonFileName);
                return false;
            }
            return true;
        }

        public int GetSentiStrengthValue(string word)
        {
            if (_emoticonDictionary.ContainsKey(word)) return _emoticonDictionary[word];
            return 0;
        }

    }
}