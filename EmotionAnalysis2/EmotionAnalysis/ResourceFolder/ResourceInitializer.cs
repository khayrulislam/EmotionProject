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

        public BoosterWord BoosterWord = new BoosterWord();
        public EmoticonLookup EmoticonLookup = new EmoticonLookup();
        public EmotionLookup EmotionLookup = new EmotionLookup();
        public EnglishWord EnglishWord = new EnglishWord();
        public NegatingWord NegatingWord = new NegatingWord();

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

            if (BoosterWord.Initialize(Path.Combine(SentiStrengthDataFolder,BoosterWordFile)) &&
                EmoticonLookup.Initialize(Path.Combine(SentiStrengthDataFolder,EmoticonLookupFile)) &&
                EmotionLookup.Initialize(Path.Combine(SentiStrengthDataFolder,EmotionLookupFile)) &&
                EnglishWord.Initialize(Path.Combine(SentiStrengthDataFolder,EnglishWordFile)) &&
                NegatingWord.Initialize(Path.Combine(SentiStrengthDataFolder,NegatingWordFile))
                )
            {
                Console.WriteLine(NegatingWord.IsNegatingWord("can't"));
                Console.ReadLine();
            }
        }


    }
}
