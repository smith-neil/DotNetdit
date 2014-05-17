namespace DotNetdit
{
    public interface ISubredditService
    {
        ISubredditGetBuilder Get();

        ISubredditGetBuilder GetNew();

        ISubredditGetBuilder GetTop();

        ISubredditGetBuilder GetNext();

        ISubredditPostBuilder Post();

        ISubredditCreateBuilder Create();
    }
}