using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAnalysis.GitHubProjectAnalyzer.Data
{
    public class RepositoryOwner
    {
        public string UserName { get; set; }

        public Uri UserUrl { get; set; }

        public Uri RepositoryUrl { get; set; }

        public Uri GistUrl { get; set; }

        public string UserType { get; set; }

        public int RepositoryCount { get; set; }

        public List<Repository> Repositories { get; set; }

    }
}
