using System.Threading.Tasks;

namespace DotNetdit.Web
{
    internal interface IWebAgent
    {
        Task<string> PerformGetAsync(string uri);

        // todo - post
    }
}
