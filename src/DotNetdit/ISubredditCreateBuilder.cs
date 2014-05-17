using System.Threading.Tasks;
using DotNetdit.Domain;

namespace DotNetdit
{
    public interface ISubredditCreateBuilder
    {
        ISubredditCreateBuilder WithName(string name);

        Subreddit ToSubreddit();

        Task<Subreddit> ToSubredditAsync();
    }
}