using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAnalysis.GitHubProjectAnalyzer.Data
{
    public class Repository
    {

        public string Name { get; set; }

        public string Id { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public Uri RepositoryUrl { get; set; }

        public Uri CollaboratorUrl { get; set; }

        public Uri ContributorUrl { get; set; }

        public Uri CommitUrl { get; set; }

        public int CommitCount { get; set; }

        public List<Commit> Commits { get; set; }

        public Uri CommentUrl { get; set; }

        public string Language { get; set; }

        public Uri IssueUrl { get; set; }

    }
}
