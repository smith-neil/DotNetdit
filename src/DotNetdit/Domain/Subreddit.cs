using System.Collections.Generic;
using DotNetdit.Resources;

namespace DotNetdit.Domain
{
    public class Subreddit : RedditObject
    {
        public Subreddit() : base(Kinds.Subreddit) {}

        public Redditor Creator { get; set; }

        public string After { get; set; }
        public string Before { get; set; }
        public string Name { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
