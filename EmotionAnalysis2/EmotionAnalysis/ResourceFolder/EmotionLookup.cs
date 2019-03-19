using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class EmotionLookup
    {
        private readonly Dictionary<string, int> _emotionDictionary = new Dictionary<string, int>();
        public bool Initialize(string emotionFileName)
        {
            if (File.Exists(emotionFileName))
            {
                string[] lines = File.ReadAllLines(emotionFileName);
                foreach (string line in lines)
                {
                    string[] lineWords = line.Split('\t');
                    _emotionDictionary[lineWords[0]] = Int32.Parse(lineWords[1]);
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", emotionFileName);
                return false;
            }

            return true;
        }

        public int GetSentiStrengthValue(string word)
        {
            if (_emotionDictionary.ContainsKey(word)) return _emotionDictionary[word];
            return 0;
        }
    }
}