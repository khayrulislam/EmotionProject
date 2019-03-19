using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class BoosterWord
    {
        private readonly Dictionary<string, int> _boosterWordDictionary = new Dictionary<string, int>(); 
        public bool Initialize(string boosterWordFileName)
        {
            if (File.Exists(boosterWordFileName))
            {
                string[] lines = File.ReadAllLines(boosterWordFileName);
                foreach (string line in lines)
                {
                    string[] lineWords = line.Split('\t');
                    _boosterWordDictionary[lineWords[0]] = Int32.Parse(lineWords[1]);
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", boosterWordFileName);
                return false;
            }

            return true;
        }

        public int GetSentiStrengthValue(string word)
        {
            if (_boosterWordDictionary.ContainsKey(word)) return _boosterWordDictionary[word];
            return 0;
        }

    }
}