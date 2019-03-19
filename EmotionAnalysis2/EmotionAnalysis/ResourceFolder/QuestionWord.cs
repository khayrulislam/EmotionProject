using System;
using System.Collections.Generic;
using System.IO;

namespace EmotionAnalysis.ResourceFolder
{
    public class QuestionWord
    {
        private readonly Dictionary<string, bool> _questionWordDictionary = new Dictionary<string, bool>();
        public bool Initialize(string questionWordFileName)
        {
            if (File.Exists(questionWordFileName))
            {
                string[] lines = File.ReadAllLines(questionWordFileName);
                foreach (string line in lines)
                {
                    _questionWordDictionary[line] = true;
                }
            }
            else
            {
                Console.WriteLine("{0} file doesn't exist", questionWordFileName);
                return false;
            }
            return true;
        }

        public bool IsQuestionWord(string word)
        {
            return _questionWordDictionary.ContainsKey(word);
        }
    }
}