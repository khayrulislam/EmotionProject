using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class EmoticonLookup
    {

        private readonly Dictionary<string, int> EmoticonDictionary = new Dictionary<string, int>();
        public bool initialize(string EmoticonFileName)
        {
            if (File.Exists(EmoticonFileName))
            {
                string[] lines = File.ReadAllLines(EmoticonFileName);
                foreach (string line in lines)
                {
                    string[] lineWords = line.Split('\t');
                    EmoticonDictionary[lineWords[0]] = Int32.Parse(lineWords[1]);
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", EmoticonFileName);
                return false;
            }
            return true;
        }

        public int getSentiStrengthValue(string word)
        {
            if (EmoticonDictionary.ContainsKey(word)) return EmoticonDictionary[word];
            return 0;
        }

    }
}