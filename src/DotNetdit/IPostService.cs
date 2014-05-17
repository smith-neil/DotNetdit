using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetdit.Domain;

namespace DotNetdit
{
    public interface IPostService
    {
        IPostGetBuilder Get();

        IPostGetBuilder GetExtra();

        IPostCreateBuilder Comment();
    }

    public interface IPostCreateBuilder
    {
        IPostCreateBuilder WithText(string text);

        IUserBuilder<IPostCreateBuilder> As(string username);

        Comment ToComment();

        Task<Comment> ToCommentAsync();
    }

    public interface IPostGetBuilder
    {
        Post ToPost();

        Task<Post> ToPostAsync();

        IEnumerable<Comment> ToComments();

        Task<IEnumerable<Comment>> ToCommentsAsync();
    }
}