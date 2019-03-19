using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class EnglishWord
    {
        private readonly Dictionary<string, bool> _englishWordDictionary = new Dictionary<string, bool>();
        public bool Initialize(string englishWordFileName)
        {
            if (File.Exists(englishWordFileName))
            {
                string[] lines = File.ReadAllLines(englishWordFileName);
                foreach (string line in lines)
                {
                    _englishWordDictionary[line] = true;
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", englishWordFileName);
                return false;
            }
            return true;
        }

        public bool IsCorrectSpelling(string word)
        {
            return _englishWordDictionary.ContainsKey(word);
        }
    }
}