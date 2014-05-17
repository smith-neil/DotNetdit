using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetdit.Domain;

namespace DotNetdit
{
    public interface ISubredditGetBuilder
    {
        ISubredditGetBuilder Take(int count);

        ISubredditGetBuilder After(int count);

        ISubredditGetBuilder After(string id);

        Subreddit ToSubreddit();

        Task<Subreddit> ToSubredditAsync();

        IEnumerable<Post> ToPosts();

        Task<IEnumerable<Post>> ToPostsAsync();
    }
}