using System;
using DotNetdit.Domain;

namespace DotNetdit
{
    public class Reddit
    {
        public ISubredditService Subreddit(string name) {
            throw new NotImplementedException();
        }

        public IPostService Post(string id) {
            throw new NotImplementedException();
        }

        public IPostService Post(Post post) {
            throw new NotImplementedException();
        }

        public IRedditorService User(string username) {
            throw new NotImplementedException();
        }

        public IUserService Me() {
            throw new NotImplementedException();
        }

        public ITimerService Every(int count) {
            throw new NotImplementedException();
        }

        public IAuthService Login() {
            throw new NotImplementedException();
        }
    }
}
