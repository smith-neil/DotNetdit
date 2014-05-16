using Newtonsoft.Json.Linq;

namespace DotNetdit.Factories
{
    public interface IJTokenFactory
    {
        JToken MakeJToken(string val);
    }
}