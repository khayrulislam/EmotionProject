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

        private BoosterWord bosBoosterWord = new BoosterWord();

        private string SentiStrengthDataFolder = @"..\..\SentiStrengthDataFolder";
        private string BoosterWordListFile = "BoosterWordList.txt";
        private string EmoticonLookupListFile = "EmoticonLookupTable.txt";
        private string EmotionLookupListFile = "EmotionLookupTable.txt";
        private string EnglishWordListFile = "EnglishWordList.txt";
        private string IdiomLookupListFile = "IdiomLookupTable.txt";
        private string NegatingWordListFile = "NegatingWordList.txt";
        private string QuestionWordListFile = "QuestionWords.txt";
        private string SlangLookupListFile = "SlangLookupTable.txt";

        public void InitializeAllTheResources()
        {

            if (bosBoosterWord.initialize(Path.Combine(SentiStrengthDataFolder,BoosterWordListFile)))
            {
                return;
            }
        }


    }
}
