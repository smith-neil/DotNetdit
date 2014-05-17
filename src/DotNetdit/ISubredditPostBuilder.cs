using System.Threading.Tasks;
using DotNetdit.Domain;

namespace DotNetdit
{
    public interface ISubredditPostBuilder
    {
        ISubredditPostBuilder WithTitle(string title);

        ISubredditPostBuilder WithText(string text);

        ISubredditPostBuilder WithLink(string url);

        IUserBuilder<ISubredditPostBuilder> As(string username);

        Post ToPost();

        Task<Post> ToPostAsync();
    }
}