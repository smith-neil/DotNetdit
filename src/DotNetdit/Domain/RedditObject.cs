namespace DotNetdit.Domain
{
    public abstract class RedditObject
    {
        public string Kind { get; private set; }

        protected RedditObject(string kind) {
            Kind = kind;
        }
    }
}