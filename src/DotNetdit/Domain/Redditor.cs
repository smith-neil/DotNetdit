using System;
using DotNetdit.Resources;

namespace DotNetdit.Domain
{
    public class Redditor : RedditObject
    {
        public Redditor() : base(Kinds.Redditor) {
        }

        public int CommentKarma { get; set; }
        public DateTime Created { get; set; }
        public string Id { get; set; }
        public bool IsFriend { get; set; }
        public bool IsGold { get; set; }
        public bool IsMod { get; set; }
        public string Name { get; set; }
        public bool VerifiedEmail { get; set; }
    }
}