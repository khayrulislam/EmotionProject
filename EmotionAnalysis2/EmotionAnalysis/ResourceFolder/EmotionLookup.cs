using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class EmotionLookup
    {
        private readonly Dictionary<string, int> EmotionDictionary = new Dictionary<string, int>();
        public bool initialize(string EmotionFileName)
        {
            if (File.Exists(EmotionFileName))
            {
                string[] lines = File.ReadAllLines(EmotionFileName);
                foreach (string line in lines)
                {
                    string[] lineWords = line.Split('\t');
                    EmotionDictionary[lineWords[0]] = Int32.Parse(lineWords[1]);
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", EmotionFileName);
                return false;
            }

            return true;
        }

        public int getSentiStrengthValue(string word)
        {
            if (EmotionDictionary.ContainsKey(word)) return EmotionDictionary[word];
            return 0;
        }
    }
}