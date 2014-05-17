using System;
using System.Collections.Generic;
using DotNetdit.Resources;

namespace DotNetdit.Domain
{
    public class Post : RedditObject
    {
        public Post() : base(Kinds.Post) {}

        public Subreddit Subreddit { get; set; }

        public Redditor ApprovedBy { get; set; }
        public Redditor Author { get; set; }
        public string AuthorFlairCssClass { get; set; }
        public string AuthorFlairText { get; set; }
        public Redditor BannedBy { get; set; }
        public bool Clicked { get; set; }
        public DateTime Created { get; set; }
        //public bool Distinguished { get; set; }
        public int Downvotes { get; set; }
        public bool Edited { get; set; }
        public string FullName { get; set; }
        public int Gilded { get; set; }
        public bool Hidden { get; set; }
        public string Id { get; set; }
        public bool IsSelfPost { get; set; }
        public int? Likes { get; set; }
        public string LinkDomain { get; set; }
        public string LinkFlairCssClass { get; set; }
        public string LinkFlairText { get; set; }
        public string LinkUrl { get; set; }
        // media
        public int CommentCount { get; set; }
        public int? ReportCount { get; set; }
        public bool Over18 { get; set; }
        public string Permalink { get; set; }
        public bool Saved { get; set; }
        public int Score { get; set; }
        public bool Stickied { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
        public int Upvotes { get; set; }
        public string Url { get; set; }
        public bool Visited { get; set; }

        public IList<Comment> Comments { get; set; } 
    }
}