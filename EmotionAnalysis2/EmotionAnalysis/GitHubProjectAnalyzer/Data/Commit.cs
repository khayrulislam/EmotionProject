using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAnalysis.GitHubProjectAnalyzer.Data
{
    public class Commit
    {

        public CommitAuthor CommitAuthor { get; set; }

        public CommitAuthor Committer { get; set; }

        public string Message { get; set; }

        public Uri CommitURL { get; set; }

        public int CommentCount { get; set; }

        public Uri CommentUrl { get; set; }

        public string CommitSha { get; set; }

        public List<Comment> Comments { get; set; }

    }


    public class CommitAuthor
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Date { get; set; }
    }


    public class Comment
    {
        public Uri CommentUrl { get; set; }

        public string CommitId { get; set; }

        public string Body { get; set; }

        public string CommentId { get; set; }

    }
}
