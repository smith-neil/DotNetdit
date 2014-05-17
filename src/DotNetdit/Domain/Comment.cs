using System;
using System.Collections.Generic;
using DotNetdit.Resources;

namespace DotNetdit.Domain
{
    public class Comment : RedditObject
    {
        public Comment() : base(Kinds.Comment) {
        }

        public Comment Parent { get; set; }

        public Redditor ApprovedBy { get; set; }
        public Redditor Author { get; set; }
        public string AuthorFlairCssClass { get; set; }
        public string AuthorFlairText { get; set; }
        public Redditor BannedBy { get; set; }
        public string Body { get; set; }
        public string BodyHtml { get; set; }
        public DateTime Created { get; set; }
        //public bool Distinguished { get; set; }
        public int Downvotes { get; set; }
        public bool Edited { get; set; }
        public int Gilded { get; set; }
        public string Id { get; set; }
        public int? Likes { get; set; }
        public string LinkId { get; set; }
        public string FullName { get; set; }
        public int? ReportCount { get; set; }
        public IList<Comment> Replies { get; set; }         
        public bool Saved { get; set; }
        public bool ScoreHidden { get; set; }
        public string SubredditName { get; set; }
        public string SubredditId { get; set; }
        public int Upvotes { get; set; }

        public Post Post { get; set; }
    }
}