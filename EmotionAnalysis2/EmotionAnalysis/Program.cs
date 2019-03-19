using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmotionAnalysis.ResourceFolder;

namespace EmotionAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            new ResourceInitializer().InitializeAllTheResources();
        }
    }
}
