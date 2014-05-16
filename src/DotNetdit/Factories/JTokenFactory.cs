using DotNetdit.Utilities;
using Newtonsoft.Json.Linq;

namespace DotNetdit.Factories
{
    public class JTokenFactory : IJTokenFactory
    {
        public JToken MakeJToken(string val) {
            val.ThrowIfNull("val");

            return JToken.Parse(val);
        }
    }
}
