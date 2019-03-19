using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class BoosterWord
    {
        private Dictionary<string, int> BoosterWordDictionary = new Dictionary<string, int>(); 
        public bool initialize(string boosterWordFileName)
        {
            if (File.Exists(boosterWordFileName))
            {
                string[] lineStrings = File.ReadAllLines(boosterWordFileName);
                foreach (string line in lineStrings)
                {
                    string[] words = line.Split('\t');
                    BoosterWordDictionary[words[0]] = Int32.Parse(words[1]);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", boosterWordFileName);
                return false;
            }

            return false;
        }

        public int getSentiStrengthValue(string word)
        {
            if (BoosterWordDictionary.ContainsKey(word)) return BoosterWordDictionary[word];
            return 0;
        }

    }
}