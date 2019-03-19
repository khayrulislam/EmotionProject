using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class NegatingWord
    {
        private readonly Dictionary<string, bool> _negatingWordDictionary = new Dictionary<string, bool>();
        public bool Initialize(string negatingWordFileName)
        {
            if (File.Exists(negatingWordFileName))
            {
                string[] lines = File.ReadAllLines(negatingWordFileName);
                foreach (string line in lines)
                {
                    _negatingWordDictionary[line] = true;
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", negatingWordFileName);
                return false;
            }
            return true;
        }

        public bool IsNegatingWord(string word)
        {
            return _negatingWordDictionary.ContainsKey(word);
        }
    }
}