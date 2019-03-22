using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmotionAnalysis.ResourceFolder;
using Octokit;

namespace EmotionAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ResourceInitializer().InitializeAllTheResources();

            var x= nothingAsync();
            Console.ReadLine();
        }


        static async Task<int> nothingAsync()
        {
            var url = new Uri("https://api.github.com/khayrulislam/EmotionProject");
            var client = new GitHubClient(new ProductHeaderValue("olife"));

            //var repository = client.Git.Reference.GetAll("khayrulislam", "EmotionProject").ToString();
            var repository = await client.Repository.Commit.GetAll("khayrulislam", "EmotionProject");
            Console.WriteLine(" write ");

            Console.WriteLine(repository);
            

            return 0;
        }
    }
}
