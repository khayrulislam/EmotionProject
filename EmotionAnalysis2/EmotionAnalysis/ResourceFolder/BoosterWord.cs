using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class BoosterWord
    {
        private readonly Dictionary<string, int> BoosterWordDictionary = new Dictionary<string, int>(); 
        public bool initialize(string boosterWordFileName)
        {
            if (File.Exists(boosterWordFileName))
            {
                string[] lines = File.ReadAllLines(boosterWordFileName);
                foreach (string line in lines)
                {
                    string[] lineWords = line.Split('\t');
                    BoosterWordDictionary[lineWords[0]] = Int32.Parse(lineWords[1]);
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", boosterWordFileName);
                return false;
            }

            return true;
        }

        public int getSentiStrengthValue(string word)
        {
            if (BoosterWordDictionary.ContainsKey(word)) return BoosterWordDictionary[word];
            return 0;
        }

    }
}