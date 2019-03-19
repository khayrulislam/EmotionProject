using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAnalysis.ResourceFolder
{
    public class ResourceInitializer
    {

        public BoosterWord boosterWord = new BoosterWord();
        public EmoticonLookup emoticonLookup = new EmoticonLookup();
        public EmotionLookup emotionLookup = new EmotionLookup();

        private string SentiStrengthDataFolder = @"..\..\SentiStrengthDataFolder";
        private string BoosterWordFile = "BoosterWordList.txt";
        private string EmoticonLookupFile = "EmoticonLookupTable.txt";
        private string EmotionLookupFile = "EmotionLookupTable.txt";
        private string EnglishWordFile = "EnglishWordList.txt";
        private string IdiomLookupFile = "IdiomLookupTable.txt";
        private string NegatingWordFile = "NegatingWordList.txt";
        private string QuestionWordFile = "QuestionWords.txt";
        private string SlangLookupFile = "SlangLookupTable.txt";

        public void InitializeAllTheResources()
        {

            if (boosterWord.initialize(Path.Combine(SentiStrengthDataFolder,BoosterWordFile)) &&
                emoticonLookup.initialize(Path.Combine(SentiStrengthDataFolder,EmoticonLookupFile)) &&
                emotionLookup.initialize(Path.Combine(SentiStrengthDataFolder,EmotionLookupFile)))
            {
                Console.WriteLine(emotionLookup.getSentiStrengthValue("bug"));
                Console.ReadLine();
            }
        }


    }
}
